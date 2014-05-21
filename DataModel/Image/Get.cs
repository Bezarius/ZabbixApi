using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Image
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only images with the given IDs.
        /// </summary>
        public string[] imageids;

        /// <summary>
        /// Return images that are used on the given maps.
        /// </summary>
        public string[] sysmapids;

        /// <summary>
        /// Return the Base64 encoded image in the image property.
        /// </summary>
        public bool select_image;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// imageid and name.
        /// </summary>
        public string[] sortfield;
    }
}