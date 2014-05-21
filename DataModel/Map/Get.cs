using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Map
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only maps with the given IDs.
        /// </summary>
        public string[] sysmapids;

        /// <summary>
        /// Adds global map URLs to the corresponding map elements and expands macros in all map element URLs.
        /// </summary>
        public bool expandUrls;

        /// <summary>
        /// Returns the icon map used on the map in the iconmap property. Does not support shorten or arrays of properties.
        /// </summary>
        public string selectIconMap;

        /// <summary>
        /// Returns map links between elements in the links property. Does not support shorten or arrays of properties.
        /// </summary>
        public string selectLinks;

        /// <summary>
        /// Returns the map elements from the map in the selements property. Does not support shorten or arrays of properties.
        /// </summary>
        public string selectSelements;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// name, width and height.
        /// </summary>
        public string[] sortfield;
    }
}