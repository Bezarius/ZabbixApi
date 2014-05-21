namespace ZabbixApi.DataModel.DiscoveredService
{
    public class Exists
    {
        /// <summary>
        /// IDs of discovered services.
        /// </summary>
        public string[] dserviceid;

        /// <summary>
        /// Name of the node the discovered services must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the discovered services must belong to.
        /// </summary>
        public string[] nodeids;
    }
}