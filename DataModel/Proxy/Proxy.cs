namespace ZabbixApi.DataModel.Proxy
{
    public class Proxy
    {
        /// <summary>
        /// </summary>
        /// <param name="host">Name of the proxy.</param>
        /// <param name="status">
        /// Type of proxy.
        /// Possible values:
        /// 5 - active proxy;
        /// 6 - passive proxy.</param>
        public Proxy(string host, int status)
        {
            this.host = host;
            this.status = status;
        }

        /// <summary>
        ///  ID of the proxy.
        /// </summary>
        public string proxyid;

        /// <summary>
        /// Name of the proxy.
        /// </summary>
        public string host;

        /// <summary>
        /// Type of proxy.
        /// Possible values:
        /// 5 - active proxy;
        /// 6 - passive proxy.
        /// </summary>
        public int status;

        /// <summary>
        /// Description of the proxy.
        /// </summary>
        public string description;

        /// <summary>
        ///  Time when the proxy last connected to the server.
        /// </summary>
        public long lastaccess;
    }
}
