namespace USATU_Networks_LW_1
{
    public struct PingRequestInfo
    {
        public string IP { get; private set; }
        public string Status { get; private set; }

        public float ResponseTime { get; private set; }

        public string HostName { get; private set; }

        public PingRequestInfo(string ip, string status, float responseTime = PingStatus.NoResponseTime,
            string hostName = PingStatus.NoHostName) : this()
        {
            IP = ip;
            Status = status;
            ResponseTime = responseTime;
            HostName = hostName;
        }
    }
}