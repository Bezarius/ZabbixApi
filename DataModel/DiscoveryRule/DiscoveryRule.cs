namespace ZabbixApi.DataModel.DiscoveryRule
{
    public class DiscoveryRule
    {
        /// <summary>
        /// </summary>
        /// <param name="iprange">One or several IP ranges to check separated by commas. Refer to the network discovery configuration section for more information on supported formats of IP ranges.</param>
        /// <param name="name">Name of the discovery rule.</param>
        public DiscoveryRule(string iprange, string name)
        {
            this.iprange = iprange;
            this.name = name;
        }

        /// <summary>
        ///  ID of the discovery rule.
        /// </summary>
        public string druleid;

        /// <summary>
        /// One or several IP ranges to check separated by commas. Refer to the network discovery configuration section for more information on supported formats of IP ranges.
        /// </summary>
        public string iprange;

        /// <summary>
        /// Name of the discovery rule.
        /// </summary>
        public string name;

        /// <summary>
        /// Execution interval of the discovery rule in seconds.
        /// Default: 3600.
        /// </summary>
        public int delay;

        /// <summary>
        ///  Time when the discovery rule will be executed next.
        /// </summary>
        public long nextcheck;

        /// <summary>
        /// ID of the proxy used for discovery.
        /// </summary>
        public string proxy_hostid;

        /// <summary>
        /// Whether the discovery rule is enabled.
        /// Possible values:
        /// 0 - (default) enabled;
        /// 1 - disabled.
        /// </summary>
        public int status;
    }
}
