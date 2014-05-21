namespace ZabbixApi.DataModel.GraphPrototype
{
    public class Exists
    {
        /// <summary>
        /// Technical names of the hosts that the graph prototypes belong to.
        /// </summary>
        public string[] host;

        /// <summary>
        /// IDs of the hosts that the graph prototypes belong to.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Names of the graph prototypes.
        /// </summary>
        public string[] name;

        /// <summary>
        /// Name of the node the graph prototypes must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// ID of the node the graph prototypes must belong to.
        /// </summary>
        public string[] nodeids;
    }
}