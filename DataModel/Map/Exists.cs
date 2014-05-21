namespace ZabbixApi.DataModel.Map
{
    public class Exists
    {
        /// <summary>
        /// Names of the maps.
        /// </summary>
        public string[] name;

        /// <summary>
        /// Name of the node the maps must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the maps must belong to.
        /// </summary>
        public string[] nodeids;

        /// <summary>
        /// IDs of the maps.
        /// </summary>
        public string[] sysmapid;
    }
}