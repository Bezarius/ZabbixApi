using ZabbixApi.Common;

namespace ZabbixApi.DataModel.DiscoveredService
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only discovered services with the given IDs.
        /// </summary>
        public int[] dserviceids;

        /// <summary>
        /// Return only discovered services that belong to the given discovered hosts.
        /// </summary>
        public string[] dhostids;

        /// <summary>
        /// Return only discovered services that have been detected by the given discovery checks.
        /// </summary>
        public string[] dcheckids;

        /// <summary>
        /// Return only discovered services that have been detected by the given discovery rules.
        /// </summary>
        public string[] druleids;

        /// <summary>
        /// Return the discovery rule that detected the service as an array in the drules property.
        /// </summary>
        public string selectDRules;

        /// <summary>
        /// Return the discovered host that service belongs to as an array in the dhosts property.
        /// </summary>
        public string selectDHosts;

        /// <summary>
        /// Return the hosts with the same IP address as the service in the hosts property. Supports count.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// 
        ///Limits the number of records returned by subselects.
        /// Applies to the following subselects:
        /// selectHosts - result will be sorted by hostid.
        /// </summary>
        public int limitSelects;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// dserviceid, dhostid and ip.
        /// </summary>
        public string[] sortfield;
    }
}