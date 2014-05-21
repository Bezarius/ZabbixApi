using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Screen
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only screens with the given IDs.
        /// </summary>
        public string[] screenids;

        /// <summary>
        /// Return only screen that contain the given screen items.
        /// </summary>
        public string[] screenitemids;

        /// <summary>
        /// Return the screen items that are used in the screen.
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