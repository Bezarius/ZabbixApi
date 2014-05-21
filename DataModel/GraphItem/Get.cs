using ZabbixApi.Common;

namespace ZabbixApi.DataModel.GraphItem
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only graph items with the given IDs.
        /// </summary>
        public string[] gitemids;

        /// <summary>
        /// Return only graph items that belong to the given graphs.
        /// </summary>
        public string[] graphids;

        /// <summary>
        /// Return only graph items with the given item IDs.
        /// </summary>
        public string[] itemids;

        /// <summary>
        /// Return only graph items with the given type. Refer to the graph item object page for a list of supported graph item types.
        /// </summary>
        public int type;

        /// <summary>
        /// 
        ///Return additional data about the item and the host.
        /// Adds the following properties to each graph item:
        /// key_ - (string) key of the item;
        /// hostid - (string) ID of the host;
        /// flags - (string) origin of the item;
        /// host - (string) technical name of the host.
        /// </summary>
        public string expandData;

        /// <summary>
        /// Return the graph that the item belongs to as an array in the graphs property.
        /// </summary>
        public string selectGraphs;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// gitemid.
        /// </summary>
        public string[] sortfield;
    }
}