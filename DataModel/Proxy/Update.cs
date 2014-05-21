namespace ZabbixApi.DataModel.Proxy
{
    public class Update : Proxy
    {
        /// <summary>
        /// Hosts to be monitored by the proxy. If a host is already monitored by a different proxy, it will be reassigned to the current proxy. The hosts must have the hostid property defined.
        /// </summary>
        public Host.Host[] hosts;

        /// <summary>
        /// Host interface to be created for the passive proxy. Required for passive proxies.
        /// </summary>
        public ProxyInterface @interface;

        /// <summary>
        /// </summary>
        /// <param name="host">Name of the proxy.</param>
        /// <param name="status">
        /// Type of proxy.
        /// Possible values:
        /// 5 - active proxy;
        /// 6 - passive proxy.
        /// </param>
        public Update(string host, int status)
            : base(host, status)
        {
        }
    }
}