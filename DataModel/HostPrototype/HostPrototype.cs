namespace ZabbixApi.DataModel.HostPrototype
{
    public class HostPrototype
    {
        /// <summary>
        /// </summary>
        /// <param name="host">Technical name of the host prototype.</param>
        public HostPrototype(string host)
        {
            this.host = host;
        }

        /// <summary>
        ///  ID of the host prototype.
        /// </summary>
        public string hostid;

        /// <summary>
        /// Technical name of the host prototype.
        /// </summary>
        public string host;

        /// <summary>
        /// Visible name of the host prototype.
        /// Default:
        /// host property value.
        /// </summary>
        public string name;

        /// <summary>
        /// Status of the host prototype.
        /// Possible values are:
        /// 0 - (default) monitored host;
        /// 1 - unmonitored host.
        /// </summary>
        public int status;

        /// <summary>
        ///  ID of the parent template host prototype.
        /// </summary>
        public string templateid;
    }
}
