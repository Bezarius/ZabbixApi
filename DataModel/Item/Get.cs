using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Item
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only items with the given IDs.
        /// </summary>
        public int[] itemids;

        /// <summary>
        /// Return only items that belong to the hosts from the given groups.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Return only items that belong to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Return only items that belong to the given hosts.
        /// </summary>
        public int[] hostids;

        /// <summary>
        /// Return only items that are monitored by the given proxies.
        /// </summary>
        public string[] proxyids;

        /// <summary>
        /// Return only items that use the given host interfaces.
        /// </summary>
        public string[] interfaceids;

        /// <summary>
        /// Return only items that are used in the given graphs.
        /// </summary>
        public string[] graphids;

        /// <summary>
        /// Return only items that are used in the given triggers.
        /// </summary>
        public string[] triggerids;

        /// <summary>
        /// Return only items that belong to the given applications.
        /// </summary>
        public string[] applicationids;

        /// <summary>
        /// Include web items in the result.
        /// </summary>
        public bool? webitems;

        /// <summary>
        /// If set to true return only items inherited from a template.
        /// </summary>
        public bool? inherited;

        /// <summary>
        /// If set to true return only items that belong to templates.
        /// </summary>
        public bool? templated;

        /// <summary>
        /// If set to true return only enabled items that belong to monitored hosts.
        /// </summary>
        public bool? monitored;

        /// <summary>
        /// Return only items that belong to a group with the given name.
        /// </summary>
        public string group;

        /// <summary>
        /// Return only items that belong to a host with the given name.
        /// </summary>
        public string host;

        /// <summary>
        /// Return only items that belong to an application with the given name.
        /// </summary>
        public string application;

        /// <summary>
        /// If set to true return only items that are used in triggers.
        /// </summary>
        public bool? with_triggers;

        /// <summary>
        /// Returns the host that the item belongs to as an array in the hosts property.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// Returns the host interface used by the item to as an array in the interfaces property.
        /// </summary>
        public string selectInterfaces;

        /// <summary>
        /// Return triggers that the item is used in in the triggers property. Supports count.
        /// </summary>
        public string selectTriggers;

        /// <summary>
        /// Return graphs that contain the item in the graphs property. Supports count.
        /// </summary>
        public string selectGraphs;

        /// <summary>
        /// Return the applications that the item belongs to in the applications property.
        /// </summary>
        public string selectApplications;

        /// <summary>
        /// Return the LLD rule that created the item in the discoveryRule property.
        /// </summary>
        public string selectDiscoveryRule;

        /// <summary>
        /// Return the item discovery object in the itemDiscovery property.
        /// The item discovery objects links the item to an item prototype and has the following properties:
        /// itemdiscoveryid - (string) ID of the item discovery;
        /// itemid - (string) ID of the discovered item;
        /// parent_itemid - (string) ID of the item prototype from which the item has been created;
        /// key_ - (string) key of the item prototype;
        /// lastcheck - (timestamp) time when the item was last discovered;
        /// ts_delete - (timestamp) time when an item that is no longer discovered will be deleted.
        /// </summary>
        public string selectItemDiscovery;

        /// <summary>
        /// Return only those results that exactly match the given filter. Accepts an array, where the keys are property names, and the values are either a single value or an array of values to match against.
        /// Supports additional filters:
        /// host - technical name of the host that the item belongs to.
        /// </summary>
        public object filter;

        /// <summary>
        /// Limits the number of records returned by subselects.
        /// Applies to the following subselects:
        /// selectGraphs - results will be sorted by name;
        /// selectTriggers - results will be sorted by description.
        /// </summary>
        public int? limitSelects;

        /// <summary>
        /// Sort the result by the given properties.
        /// Possible values are:
        /// itemid, name, key_, delay, history, trends, type and status.
        /// </summary>
        public string[] sortfield;
    }
}