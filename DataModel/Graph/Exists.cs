namespace ZabbixApi.DataModel.Graph
{
    public class Exists
    {
        /// <summary>
        /// Technical names of the hosts that the graphs belong to.
        /// </summary>
        public string[] host;

        /// <summary>
        /// IDs of the hosts that the graphs belong to.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Names of the graphs.
        /// </summary>
        public string[] name;

        /// <summary>
        /// Name of the node the graphs must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// ID of the node the graphs must belong to.
        /// </summary>
        public string[] nodeids;
    }
}