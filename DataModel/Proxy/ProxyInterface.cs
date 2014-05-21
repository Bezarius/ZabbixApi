namespace ZabbixApi.DataModel.Proxy
{
    public class ProxyInterface
    {
        /// <summary>
        /// </summary>
        /// <param name="dns">DNS name to connect to. Can be empty if connections are made via IP address.</param>
        /// <param name="ip">IP address to connect to. Can be empty if connections are made via DNS names.</param>
        /// <param name="port">Port number to connect to.</param>
        /// <param name="useip">
        /// Whether the connection should be made via IP address.
        /// Possible values are:
        /// 0 - connect using DNS name;
        /// 1 - connect using IP address.</param>
        public ProxyInterface(string dns, string ip, string port, int useip)
        {
            this.dns = dns;
            this.ip = ip;
            this.port = port;
            this.useip = useip;
        }

        /// <summary>
        ///  ID of the interface.
        /// </summary>
        public string interfaceid;

        /// <summary>
        /// DNS name to connect to. Can be empty if connections are made via IP address.
        /// </summary>
        public string dns;

        /// <summary>
        /// IP address to connect to. Can be empty if connections are made via DNS names.
        /// </summary>
        public string ip;

        /// <summary>
        /// Port number to connect to.
        /// </summary>
        public string port;

        /// <summary>
        /// 
        ///Whether the connection should be made via IP address.
        /// Possible values are:
        /// 0 - connect using DNS name;
        /// 1 - connect using IP address.
        /// </summary>
        public int useip;

        /// <summary>
        ///  ID of the proxy the interface belongs to.
        /// </summary>
        public string hostid;
    }
}