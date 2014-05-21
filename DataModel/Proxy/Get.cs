using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Proxy
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only proxies with the given IDs.
        /// </summary>
        public string[] proxyids;

        /// <summary>
        /// Return hosts monitored by the proxy in the hosts property.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// Return the proxy interface used by a passive proxy in the interface property.
        /// </summary>
        public string selectInterface;

        /// <summary>
        /// Sort the result by the given properties.
        /// Possible values are:
        /// hostid, host and status.
        /// </summary>
        public string[] sortfield;
    }
}