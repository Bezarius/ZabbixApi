namespace ZabbixApi.DataModel.HostInterface
{
    public class Exists
    {
        /// <summary>
        /// DNS of the host interfaces.
        /// </summary>
        public string[] dns;

        /// <summary>
        /// IDs of the hosts that the host interfaces must belong to.
        /// </summary>
        public string[] hostid;

        /// <summary>
        /// Host interface IDs.
        /// </summary>
        public string[] interfaceid;

        /// <summary>
        /// IPs of the host interfaces.
        /// </summary>
        public string[] ip;

        /// <summary>
        /// Name of the node the host interfaces must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the node the host interfaces must belong to.
        /// </summary>
        public string[] nodeids;
    }
}