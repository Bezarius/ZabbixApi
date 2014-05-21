using ZabbixApi.Common;

namespace ZabbixApi.DataModel.DiscoveredHost
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only discovered hosts with the given IDs.
        /// </summary>
        public int[] dhostids;

        /// <summary>
        /// Return only discovered hosts that have been created by the given discovery rules.
        /// </summary>
        public string[] druleids;

        /// <summary>
        /// Return only discovered hosts that are running the given services.
        /// </summary>
        public string[] dserviceids;

        /// <summary>
        /// Return the discovery rule that detected the host as an array in the drules property.
        /// </summary>
        public string selectDRules;

        /// <summary>
        /// Return the discovered services running on the host in the dservices property. Supports count.
        /// </summary>
        public string selectDServices;

        /// <summary>
        /// 
        ///Limits the number of records returned by subselects.
        /// Applies to the following subselects:
        /// selectDServices - results will be sorted by dserviceid.
        /// </summary>
        public int limitSelects;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// dhostid and druleid.
        /// </summary>
        public string[] sortfield;
    }
}