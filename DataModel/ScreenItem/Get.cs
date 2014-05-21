using ZabbixApi.Common;

namespace ZabbixApi.DataModel.ScreenItem
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only screen items with the given IDs.
        /// </summary>
        public string[] screenitemids;

        /// <summary>
        /// Return only screen items that belong to the given screen.
        /// </summary>
        public string[] screenids;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// screenitemid and screenid.
        /// </summary>
        public string[] sortfield;
    }
}