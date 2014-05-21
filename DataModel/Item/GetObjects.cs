namespace ZabbixApi.DataModel.Item
{
    public class GetObjects : Item
    {
        /// <summary>
        /// Technical name of the host that the item belongs to.
        /// </summary>
        public string[] host;

        /// <summary>
        /// Name of the node the items must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// ID of the node the items must belong to.
        /// </summary>
        public string[] nodeids;
    }
}