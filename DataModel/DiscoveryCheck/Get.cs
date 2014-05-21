using ZabbixApi.Common;

namespace ZabbixApi.DataModel.DiscoveryCheck
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only discovery checks with the given IDs.
        /// </summary>
        public string[] dcheckids;

        /// <summary>
        /// Return only discovery checks that belong to the given discovery rules.
        /// </summary>
        public string[] druleids;

        /// <summary>
        /// Return only discovery checks that have detected the given discovered services.
        /// </summary>
        public string[] dserviceids;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// dcheckid and druleid.
        /// </summary>
        public string[] sortfield;
    }
}