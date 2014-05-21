using ZabbixApi.Common;

namespace ZabbixApi.DataModel.DiscoveryRule
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only discovery rules that created the given discovered hosts.
        /// </summary>
        public string[] dhostids;

        /// <summary>
        /// Return only discovery rules with the given IDs.
        /// </summary>
        public string[] druleids;

        /// <summary>
        /// Return only discovery rules that created the given discovered services.
        /// </summary>
        public string[] dserviceids;

        /// <summary>
        /// Return discovery checks used by the discovery rule in the dchecks property. Supports count.
        /// </summary>
        public string selectDChecks;

        /// <summary>
        /// Return the discovered hosts that the discovery rule created in the dhosts property. Supports count.
        /// </summary>
        public string selectDHosts;

        /// <summary>
        /// 
        ///Limits the number of records returned by subselects.
        /// Applies to the following subselects:
        /// selectDChecks - results will be sorted by dcheckid;
        /// selectDHosts - results will be sorted by dhostsid.
        /// </summary>
        public int limitSelects;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// druleid and name.
        /// </summary>
        public string[] sortfield;
    }
}