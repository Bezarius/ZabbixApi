using ZabbixApi.Common;

namespace ZabbixApi.DataModel.HostInterface
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only host interfaces used by the given hosts.
        /// </summary>
        public int[] hostids;

        /// <summary>
        /// Return only host interfaces with the given IDs.
        /// </summary>
        public string[] interfaceids;

        /// <summary>
        /// Return only host interfaces used by the given items.
        /// </summary>
        public string[] itemids;

        /// <summary>
        /// Return only host interfaces used by items in the given triggers.
        /// </summary>
        public string[] triggerids;

        /// <summary>
        /// Return the items that use the interface in the items property. Supports count.
        /// </summary>
        public string selectItems;

        /// <summary>
        /// Return the host that uses the interface as an array in the hosts property.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// Limits the number of records returned by subselects. Applies to the following subselects: selectItems.
        /// </summary>
        public int limitSelects;

        /// <summary>
        /// Sort the result by the given properties. Possible values are: interfaceid, dns, ip.
        /// </summary>
        public string[] sortfield;
    }
}