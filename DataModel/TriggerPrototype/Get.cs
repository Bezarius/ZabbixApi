using ZabbixApi.Common;

namespace ZabbixApi.DataModel.TriggerPrototype
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only enabled trigger prototypes that belong to monitored hosts.
        /// </summary>
        public bool? active;

        /// <summary>
        /// Return only trigger prototypes that contain items from the given applications.
        /// </summary>
        public string[] applicationids;

        /// <summary>
        /// Return only trigger prototypes that belong to the given LLD rules.
        /// </summary>
        public string[] discoveryids;

        /// <summary>
        /// Return only triggers that use the given functions. Refer to the supported trigger functions page for a list of supported functions.
        /// </summary>
        public string[] functions;

        /// <summary>
        /// Return only trigger prototypes that belong to hosts from the host groups with the given name.
        /// </summary>
        public string group;

        /// <summary>
        /// Return only trigger prototypes that belong to hosts from the given host groups.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Return only trigger prototypes that belong to hosts with the given name.
        /// </summary>
        public string host;

        /// <summary>
        /// Return only trigger prototypes that belong to the given hosts.
        /// </summary>
        public int[] hostids;

        /// <summary>
        /// If set to true return only trigger prototypes inherited from a template.
        /// </summary>
        public bool? inherited;

        /// <summary>
        /// If set to true return only enabled trigger prototypes that belong to hosts in maintenance.
        /// </summary>
        public bool? maintenance;

        /// <summary>
        /// Return only trigger prototypes with severity greater or equal than the given severity.
        /// </summary>
        public int min_severity;

        /// <summary>
        /// Return only enabled trigger prototypes that belong to monitored hosts and contain only enabled items.
        /// </summary>
        public bool monitored;

        /// <summary>
        /// If set to true return only trigger prototypes that belong to templates.
        /// </summary>
        public bool? templated;

        /// <summary>
        /// Return only trigger prototypes that belong to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Return only trigger prototypes with the given IDs.
        /// </summary>
        public string[] triggerids;

        /// <summary>
        /// Return additional data about the first host in the trigger expression.
        /// Adds the following properties to each trigger prototype:
        /// hostname - (string) visible name of the host;
        /// host - (string) technical name of the host;
        /// hostid - (string) ID of the host.
        /// </summary>
        public bool? expandData;

        /// <summary>
        /// Expand functions and macros in the trigger expression.
        /// </summary>
        public bool? expandExpression;

        /// <summary>
        /// Return the LLD rule that the trigger prototype belongs to.
        /// </summary>
        public string selectDiscoveryRule;

        /// <summary>
        /// Return functions used in the trigger prototype in the functions property.
        /// The function objects represents the functions used in the trigger expression and has the following properties:
        /// functionid - (string) ID of the function;
        /// itemid - (string) ID of the item used in the function;
        /// function - (string) name of the function;
        /// parameter - (string) parameter passed to the function.
        /// </summary>
        public string selectFunctions;

        /// <summary>
        /// Return the host groups that the trigger prototype belongs to in the groups property.
        /// </summary>
        public string selectGroups;

        /// <summary>
        /// Return the hosts that the trigger prototype belongs to in the hosts property.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// Return items and item prototypes used the trigger prototype in the items property.
        /// </summary>
        public string selectItems;

        /// <summary>
        /// 
        ///Return only those results that exactly match the given filter. Accepts an array, where the keys are property names, and the values are either a single value or an array of values to match against.
        /// Supports additional filters:
        /// host - technical name of the host that the trigger prototype belongs to;
        /// hostid - ID of the host that the trigger prototype belongs to.
        /// </summary>
        public object filter;

        /// <summary>
        /// 
        ///Limits the number of records returned by subselects.
        /// Applies to the following subselects:
        /// selectHosts - results will be sorted by host.
        /// </summary>
        public int? limitSelects;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// triggerid, description, status and priority.
        /// </summary>
        public string[] sortfield;
    }
}