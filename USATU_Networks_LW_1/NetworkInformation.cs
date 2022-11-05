namespace USATU_Networks_LW_1
{
    public struct NetworkInformation
    {
        public string NetworkMask { get; private set; }
        public string BroadcastAddress { get; private set; }
        public string NetworkAddress { get; private set; }
        public string MAC { get; private set; }

        public NetworkInformation(string networkMask, string broadcastAddress, string networkAddress, string mac) :
            this()
        {
            NetworkMask = networkMask;
            BroadcastAddress = broadcastAddress;
            NetworkAddress = networkAddress;
            MAC = mac;
        }
    }
}