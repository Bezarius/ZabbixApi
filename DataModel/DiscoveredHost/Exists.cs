namespace ZabbixApi.DataModel.DiscoveredHost
{
    public class Exists
    {
        /// <summary>
        /// IDs of the discovered hosts.
        /// </summary>
        public string[] dhostid;

        /// <summary>
        /// Name of the node the discovered hosts must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the discovered hosts must belong to.
        /// </summary>
        public string[] nodeids;
    }
}