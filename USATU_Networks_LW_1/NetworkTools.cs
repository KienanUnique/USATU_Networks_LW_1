using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace USATU_Networks_LW_1
{
    public static class NetworkTools
    {
        private const int TimeOut = 100;
        private const int MaxCountOfRunningSendRequestTasks = 50;

        private static string GetHostName(string checkIP)
        {
            try
            {
                return Dns.GetHostEntry(checkIP).HostName;
            }
            catch
            {
                return PingStringConstants.NoHostName;
            }
        }

        private static PhysicalAddress GetNetworkInterfaceMAC(NetworkInterface networkInterface)
        {
            return networkInterface.GetPhysicalAddress();
        }

        private static IPAddress GetNetworkMask(NetworkInterface networkInterface)
        {
            foreach (var unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
            {
                if (!unicastAddress.IsDnsEligible) continue;
                return unicastAddress.IPv4Mask;
            }

            return IPAddress.None;
        }

        private static IPAddress GetLocalIP(NetworkInterface networkInterface)
        {
            foreach (var unicastAddress in networkInterface.GetIPProperties().UnicastAddresses)
            {
                if (!unicastAddress.IsDnsEligible) continue;
                return unicastAddress.Address;
            }

            return IPAddress.None;
        }

        private static IPAddress GetNetworkAddress(IPAddress address, IPAddress mask)
        {
            var ipAddress = BitConverter.ToUInt32(address.GetAddressBytes(), 0);
            var ipMaskV4 = BitConverter.ToUInt32(mask.GetAddressBytes(), 0);
            var broadCastIpAddress = ipAddress & ipMaskV4;

            return new IPAddress(BitConverter.GetBytes(broadCastIpAddress));
        }

        private static IPAddress GetBroadcastAddress(IPAddress address, IPAddress mask)
        {
            var ipAddress = BitConverter.ToUInt32(address.GetAddressBytes(), 0);
            var ipMaskV4 = BitConverter.ToUInt32(mask.GetAddressBytes(), 0);
            var broadCastIpAddress = ipAddress | ~ipMaskV4;

            return new IPAddress(BitConverter.GetBytes(broadCastIpAddress));
        }

        private static PingRequestInfo CheckStatusByIP(string checkIP)
        {
            try
            {
                var ping = new Ping();
                var reply = ping.Send(checkIP, TimeOut);
                if (reply != null && reply.Status == IPStatus.Success)
                {
                    return new PingRequestInfo(checkIP, PingStringConstants.Ok, reply.RoundtripTime, GetHostName(checkIP));
                }

                return new PingRequestInfo(checkIP, PingStringConstants.NotOk);
            }
            catch
            {
                return new PingRequestInfo(checkIP, PingStringConstants.Error);
            }
        }

        private static int[] GetIntPartsFromStringIP(string address)
        {
            var addressPartsString = address.Split('.');
            var addressPartsInt = new int[4];
            for (int i = 0; i < addressPartsString.Length; i++)
            {
                if (addressPartsString[i] != string.Empty)
                {
                    addressPartsInt[i] = int.Parse(addressPartsString[i]);
                }
            }

            return addressPartsInt;
        }

        private static ObservableCollection<PingRequestInfo> SortPingRequestsByIP(
            IEnumerable<PingRequestInfo> collectionToSort)
        {
            return new ObservableCollection<PingRequestInfo>(
                collectionToSort.OrderBy(i =>
                    ulong.Parse(i.IP.Split('.')[0]) * 16581375 +
                    ulong.Parse(i.IP.Split('.')[1]) * 65025 +
                    ulong.Parse(i.IP.Split('.')[2]) * 255 +
                    ulong.Parse(i.IP.Split('.')[3])));
        }

        public static ObservableCollection<PingRequestInfo> GetScannedRangeOfIP(string fromAddress, string toAddress)
        {
            var pingRequestInfos = new ObservableCollection<PingRequestInfo>();
            var fromAddressIntParts = GetIntPartsFromStringIP(fromAddress);
            var toAddressIntParts = GetIntPartsFromStringIP(toAddress);
            var sendRequestTasks = new List<Task>();
            var addressBuilder = new StringBuilder();
            for (var part1 = fromAddressIntParts[0]; part1 <= toAddressIntParts[0]; part1++)
            {
                for (var part2 = part1 == fromAddressIntParts[0] ? fromAddressIntParts[1] : 0;
                     part2 <= (part1 == toAddressIntParts[0] ? toAddressIntParts[1] : 255);
                     part2++)
                {
                    for (var part3 = part2 == fromAddressIntParts[1] ? fromAddressIntParts[2] : 0;
                         part3 <= (part2 == toAddressIntParts[1] ? toAddressIntParts[2] : 255);
                         part3++)
                    {
                        for (var part4 = part3 == fromAddressIntParts[2] ? fromAddressIntParts[3] : 0;
                             part4 <= (part3 == toAddressIntParts[2] ? toAddressIntParts[3] : 255);
                             part4++)
                        {
                            addressBuilder.Append(part1);
                            addressBuilder.Append(".");
                            addressBuilder.Append(part2);
                            addressBuilder.Append(".");
                            addressBuilder.Append(part3);
                            addressBuilder.Append(".");
                            addressBuilder.Append(part4);

                            if (sendRequestTasks.Count >= MaxCountOfRunningSendRequestTasks)
                            {
                                Task.WaitAll(sendRequestTasks.ToArray());
                                sendRequestTasks.Clear();
                            }

                            var sendRequestTask =
                                new Task(
                                    (address) => { pingRequestInfos.Add(CheckStatusByIP(address.ToString())); },
                                    addressBuilder.ToString());
                            sendRequestTasks.Add(sendRequestTask);
                            sendRequestTask.Start();

                            addressBuilder.Clear();
                        }
                    }
                }
            }

            Task.WaitAll(sendRequestTasks.ToArray());
            return SortPingRequestsByIP(pingRequestInfos);
        }

        public static bool IsCorrectIP(string checkIP)
        {
            var isCorrectIP = true;
            try
            {
                IPAddress.Parse(checkIP);
            }
            catch
            {
                isCorrectIP = false;
            }

            return isCorrectIP;
        }

        public static NetworkInformation GetFirstActiveInterfaceStatus()
        {
            var activeInterface = NetworkInterface.GetAllNetworkInterfaces()
                .First(i => i.OperationalStatus == OperationalStatus.Up);
            var networkMask = GetNetworkMask(activeInterface);
            var localAddress = GetLocalIP(activeInterface);
            var addressMAC = GetNetworkInterfaceMAC(activeInterface);
            var broadcastAddress = GetBroadcastAddress(localAddress, networkMask);
            var networkAddress = GetNetworkAddress(localAddress, networkMask);
            return new NetworkInformation(networkMask.ToString(), broadcastAddress.ToString(),
                networkAddress.ToString(), addressMAC.ToString());
        }
    }
}