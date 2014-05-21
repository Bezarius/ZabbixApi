using ZabbixApi.Common;

namespace ZabbixApi.DataModel.IconMap
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only icon maps with the given IDs.
        /// </summary>
        public string[] iconmapids;

        /// <summary>
        /// Return only icon maps that are used in the given maps.
        /// </summary>
        public string[] sysmapids;

        /// <summary>
        /// Return used icon mappings in the mappings property.
        /// </summary>
        public string selectMappings;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// iconmapid and name.
        /// </summary>
        public string[] sortfield;
    }
}