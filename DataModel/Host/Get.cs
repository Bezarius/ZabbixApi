using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Host
{
    public class Get : CommonGet
    {
        /// <summary>
        ///  Return only hosts that belong to the given groups.
        /// </summary>
        public string[] groupids;

        /// <summary>
        ///  Return only hosts that have the given applications.
        /// </summary>
        public string[] applicationids;

        /// <summary>
        ///  Return only hosts that are related to the given discovered services.
        /// </summary>
        public string[] dserviceids;

        /// <summary>
        ///  Return only hosts that have the given graphs.
        /// </summary>
        public string[] graphids;

        /// <summary>
        ///  Return only hosts with the given host IDs.
        /// </summary>
        public string[] hostids;

        /// <summary>
        ///  Return only hosts that have the given web checks.
        /// </summary>
        public string[] httptestids;

        /// <summary>
        ///  Return only hosts that use the given interfaces.
        /// </summary>
        public string[] interfaceids;

        /// <summary>
        ///  Return only hosts that have the given items.
        /// </summary>
        public string[] itemids;

        /// <summary>
        ///  Return only hosts that are affected by the given maintenances.
        /// </summary>
        public string[] maintenanceids;

        /// <summary>
        ///  Return only monitored hosts.
        /// </summary>
        public string monitored_hosts;

        /// <summary>
        ///  Return only proxies.
        /// </summary>
        public string proxy_hosts;

        /// <summary>
        ///  Return only hosts that are monitored by the given proxies.
        /// </summary>
        public string[] proxyids;

        /// <summary>
        ///  Return both hosts and templates.
        /// </summary>
        public string templated_hosts;

        /// <summary>
        ///  Return only hosts that are linked to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        ///  Return only hosts that have the given triggers.
        /// </summary>
        public string[] triggerids;

        /// <summary>
        /// Return only hosts that have items. Overrides the with_monitored_items and with_simple_graph_items parameters.
        /// </summary>
        public string with_items;

        /// <summary>
        /// Return only hosts that have applications.
        /// </summary>
        public string with_applications;

        /// <summary>
        /// Return only hosts that have graphs.
        /// </summary>
        public string with_graphs;

        /// <summary>
        /// Return only hosts that have web checks. Overrides the with_monitored_httptests parameter.
        /// </summary>
        public string with_httptests;

        /// <summary>
        /// Return only hosts that have enabled web checks.
        /// </summary>
        public string with_monitored_httptests;

        /// <summary>
        /// Return only hosts that have enabled items. Overrides the with_simple_graph_items parameter.
        /// </summary>
        public string with_monitored_items;

        /// <summary>
        /// Return only hosts that have enabled triggers. All of the items used in the trigger must also be enabled.
        /// </summary>
        public string with_monitored_triggers;

        /// <summary>
        /// Return only hosts that have items with numeric type of information.
        /// </summary>
        public string with_simple_graph_items;

        /// <summary>
        /// Return only hosts that have triggers. Overrides the with_monitored_triggers parameter.
        /// </summary>
        public string with_triggers;

        /// <summary>
        /// Return only hosts that have inventory data.
        /// </summary>
        public string withInventory;

        /// <summary>
        /// Return the host groups that the host belongs to in the groups property.
        /// </summary>
        public string selectGroups;

        /// <summary>
        /// Return the applications from the host in the applications property. Support count.
        /// </summary>
        public string selectApplications;

        /// <summary>
        /// Return the low level discoveries from the host in the discoveries property. Supports count.
        /// </summary>
        public string selectDiscoveries;

        /// <summary>
        ///  Return the LLD rule that created the host in the discoveryRule property.
        /// </summary>
        public string selectDiscoveryRule;

        /// <summary>
        /// Return the graphs from the host in the graphs property. Supports count.
        /// </summary>
        public string selectGraphs;

        /// <summary>
        ///  Return the host discovery object in the hostDiscovery property. The host discovery object links a discovered host to a host prototype or a host prototypes to an LLD rule and has the following properties:host - (string) host of the host prototype;hostid - (string) ID of the discovered host or host prototype; parent_hostid - (string) ID of the host prototype from which the host has been created; parent_itemid - (string) ID of the LLD rule that created the discovered host; lastcheck - (timestamp) time when the host was last discovered; ts_delete - (timestamp) time when a host that is no longer discovered will be deleted.
        /// </summary>
        public string selectHostDiscovery;

        /// <summary>
        /// Return the web scenarios from the host in the httpTests property. Supports count.
        /// </summary>
        public string selectHttpTests;

        /// <summary>
        /// Return the host interfaces in the interfaces property. Supports count.
        /// </summary>
        public string selectInterfaces;

        /// <summary>
        /// Return the host inventory from the host in the inventory property. Possible values are true to return all of the data, or an array of property names to return only specific properties.
        /// </summary>
        public string selectInventory;

        /// <summary>
        /// Return the items from the host in the items property. Supports count.
        /// </summary>
        public string selectItems;

        /// <summary>
        /// Return the macros from the host in the macros property.
        /// </summary>
        public string selectMacros;

        /// <summary>
        /// Return the templates that the host is linked to in the parentTemplates property. Supports count.
        /// </summary>
        public string selectParentTemplates;

        /// <summary>
        /// Return the screens from the host in the screens property. Supports count.
        /// </summary>
        public string selectScreens;

        /// <summary>
        /// Return the triggers from the host in the triggers property. Supports count.
        /// </summary>
        public string selectTriggers;

        /// <summary>
        /// Return only those results that exactly match the given filter. Accepts an array, where the keys are property names, and the values are either a single value or an array of values to match against. Allows filtering by interface properties.
        /// </summary>
        public object filter;

        /// <summary>
        ///  Limits the number of records returned by subselects. Applies to the following subselects: selectParentTemplates - results will be sorted by host; selectInterfaces; selectItems - sorted by name; selectDiscoveries - sorted by name; selectTriggers - sorted by description; selectGraphs - sorted by name; selectApplications - sorted by name; selectScreens - sorted by name.
        /// </summary>
        public int? limitSelects;

        /// <summary>
        /// Return results that match the given wildcard search. Accepts an array, where the keys are property names, and the values are strings to search for. If no additional options are given, this will perform a LIKE ”%…%” search. Allows searching by interface properties. Works only with text fields.
        /// </summary>
        public object search;

        /// <summary>
        ///  Sort the result by the given properties. Possible values are: hostid, host, name, status.
        /// </summary>
        public string[] sortfield;
    }
}