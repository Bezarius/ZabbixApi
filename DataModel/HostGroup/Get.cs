using ZabbixApi.Common;

namespace ZabbixApi.DataModel.HostGroup
{
    public class Get : CommonGet
    {
        /// <summary>
        ///  Return only host groups that contain hosts or templates with the given graphs.
        /// </summary>
        public string[] graphids;

        /// <summary>
        ///  Return only host groups with the given host group IDs.
        /// </summary>
        public string[] groupids;

        /// <summary>
        ///  Return only host groups that contain the given hosts.
        /// </summary>
        public string[] hostids;

        /// <summary>
        ///  Return only host groups that are affected by the given maintenances.
        /// </summary>
        public string[] maintenanceids;

        /// <summary>
        ///  Return only host groups that contain monitored hosts.
        /// </summary>
        public string monitored_hosts;

        /// <summary>
        ///  Return only host groups that do not contain proxies.
        /// </summary>
        public string not_proxy_hosts;

        /// <summary>
        ///  Return only host groups that contain hosts.
        /// </summary>
        public string real_hosts;

        /// <summary>
        ///  Return only host groups that contain templates.
        /// </summary>
        public string templated_hosts;

        /// <summary>
        ///  Return only host groups that contain the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        ///  Return only host groups that contain hosts or templates with the given triggers.
        /// </summary>
        public string[] triggerids;

        /// <summary>
        ///  Return only host groups that contain hosts with applications.
        /// </summary>
        public string with_applications;

        /// <summary>
        ///  Return only host groups that contain hosts with graphs.
        /// </summary>
        public string with_graphs;

        /// <summary>
        ///  Return only host groups that contain hosts or templates.
        /// </summary>
        public string with_hosts_and_templates;

        /// <summary>
        ///  Return only host groups that contain hosts with web checks. Overrides the with_monitored_httptests parameter.
        /// </summary>
        public string with_httptests;

        /// <summary>
        ///  Return only host groups that contain hosts or templates with items. Overrides the with_monitored_items andwith_simple_graph_items parameters.
        /// </summary>
        public string with_items;

        /// <summary>
        ///  Return only host groups that contain hosts with enabled web checks.
        /// </summary>
        public string with_monitored_httptests;

        /// <summary>
        ///  Return only host groups that contain hosts or templates with enabled items. Overrides the with_simple_graph_items parameter.
        /// </summary>
        public string with_monitored_items;

        /// <summary>
        ///  Return only host groups that contain hosts with enabled triggers. All of the items used in the trigger must also be enabled.
        /// </summary>
        public string with_monitored_triggers;

        /// <summary>
        ///  Return only host groups that contain hosts with numeric items.
        /// </summary>
        public string with_simple_graph_items;

        /// <summary>
        ///  Return only host groups that contain hosts with triggers. Overrides the with_monitored_triggers parameter.
        /// </summary>
        public string with_triggers;

        /// <summary>
        ///  Return the LLD rule that created the host group in the discoveryRule property.
        /// </summary>
        public string selectDiscoveryRule;

        /// <summary>
        ///  Return the host group discovery object in the groupDiscovery property. The host group discovery object links a discovered host group to a host group prototype and has the following properties: 
        /// </summary>
        public string selectGroupDiscovery;

        /// <summary>
        ///  Return the hosts that belong to the host group in the hosts property. Supports count.
        /// </summary>
        public string selectHosts;

        /// <summary>
        ///  Return the templates that belong to the host group in the templates property. Supports count.
        /// </summary>
        public string selectTemplates;

        /// <summary>
        ///  Limits the number of records returned by subselects. Applies to the following subselects: selectHosts - results will be sorted by host; selectTemplates - results will be sorted by host.
        /// </summary>
        public int limitSelects;

        /// <summary>
        ///  Sort the result by the given properties. Possible values are: groupid, name.
        /// </summary>
        public string[] sortfield;
    }
}