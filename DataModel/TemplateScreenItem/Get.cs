using ZabbixApi.Common;

namespace ZabbixApi.DataModel.TemplateScreenItem
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only template screen items that belong to the given template screens.
        /// </summary>
        public string[] screenids;

        /// <summary>
        /// Return only template screen items with the given IDs.
        /// </summary>
        public string[] screenitemids;

        /// <summary>
        /// Returns an additional real_resourceid property for each template screen item, that belongs to a screen from the given hosts or templates. The real_resourceid property contains the ID of object displayed on the screen.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Sort the result by the given properties.
        /// Possible values are:
        /// screenitemid and screenid.
        /// </summary>
        public string[] sortfield;
    }
}