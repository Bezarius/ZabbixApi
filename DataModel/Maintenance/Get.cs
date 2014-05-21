using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Maintenance
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only maintenances that are assigned to the given host groups.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Return only maintenances that are assigned to the given hosts.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Return only maintenances with the given IDs.
        /// </summary>
        public string[] maintenanceids;

        /// <summary>
        /// Return host groups assigned to the maintenance in the groups property. Does not support shorten.
        /// </summary>
        public string selectGroups;

        /// <summary>
        /// Return hosts assigned to the maintenance in the hosts property. Does not support shorten.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// (added in 2.0.3) Return the maintenance's time periods in the timeperiods property. Does not support shorten.
        /// </summary>
        public string selectTimeperiods;

        /// <summary>
        /// Sort the result by the given properties.
        /// Possible values are:
        /// maintenanceid, name and maintenance_type.
        /// </summary>
        public string[] sortfield;
    }
}