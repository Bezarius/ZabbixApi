using ZabbixApi.Common;

namespace ZabbixApi.DataModel.TemplateScreen
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only template screens that belong to the given hosts.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Return only template screens with the given IDs.
        /// </summary>
        public string[] screenids;

        /// <summary>
        /// Return only template screens that contain the given screen items.
        /// </summary>
        public string[] screenitemids;

        /// <summary>
        /// Return only template screens that belong to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Do not return inherited template screens.
        /// </summary>
        public bool noInheritance;

        /// <summary>
        /// Return the screen items that are used in the template screen in the screenitems property.
        /// </summary>
        public string selectScreenItems;

        /// <summary>
        /// Sort the result by the given properties.
        /// Possible values are:
        /// screenid and name.
        /// </summary>
        public string[] sortfield;
    }
}