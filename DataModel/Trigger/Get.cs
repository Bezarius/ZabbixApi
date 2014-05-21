using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Trigger
{
    /// <summary>
    /// The method allows to retrieve triggers according to the given parameters.
    /// </summary>
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only triggers with the given IDs.
        /// </summary>
        public int[] triggerids;

        /// <summary>
        /// Return only triggers that belong to hosts from the given host groups.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Return only triggers that belong to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Return only triggers that belong to the given hosts.
        /// </summary>
        public int[] hostids;

        /// <summary>
        /// Return only triggers that contain the given items.
        /// </summary>
        public int[] itemids;

        /// <summary>
        /// Return only triggers that contain items from the given applications.
        /// </summary>
        public string[] applicationids;

        /// <summary>
        /// Return only triggers that use the given functions. Refer to the supported trigger functions page for a list of supported functions.
        /// </summary>
        public string[] functions;

        /// <summary>
        /// Return only triggers that belong to hosts from the host groups with the given name.
        /// </summary>
        public string group;

        /// <summary>
        /// Return only triggers that belong to hosts with the given name.
        /// </summary>
        public string host;

        /// <summary>
        /// If set to true return only triggers inherited from a template.
        /// </summary>
        public bool? inherited;

        /// <summary>
        /// If set to true return only triggers that belong to templates.
        /// </summary>
        public bool? templated;

        /// <summary>
        /// Return only enabled triggers that belong to monitored hosts and contain only enabled items.
        /// </summary>
        public string monitored;

        /// <summary>
        /// Return only enabled triggers that belong to monitored hosts.
        /// </summary>
        public string active;

        /// <summary>
        /// If set to true return only enabled triggers that belong to hosts in maintenance.
        /// </summary>
        public bool? maintenance;

        /// <summary>
        /// Return only triggers that have unacknowledged events.
        /// </summary>
        public string withUnacknowledgedEvents;

        /// <summary>
        /// Return only triggers with all events acknowledged.
        /// </summary>
        public string withAcknowledgedEvents;

        /// <summary>
        /// Return only triggers with the last event unacknowledged.
        /// </summary>
        public string withLastEventUnacknowledged;

        /// <summary>
        /// Skip triggers in a problem state that are dependent on other triggers.
        /// </summary>
        public string skipDependent;

        /// <summary>
        /// Return only triggers that have changed their state after the given time.
        /// </summary>
        public string lastChangeSince;

        /// <summary>
        /// Return only triggers that have changed their state before the given time.
        /// </summary>
        public string lastChangeTill;

        /// <summary>
        /// Return only triggers that have recently been in a problem state.
        /// </summary>
        public string only_true;

        /// <summary>
        /// Return only triggers with severity greater or equal than the given severity.
        /// </summary>
        public string min_severity;

        /// <summary>
        /// Return additional data about the first host in the trigger expression.
        /// Adds the following properties to each trigger: 
        ///  hostname - (string) visible name of the host; 
        ///  host - (string) technical name of the host; 
        ///  hostid - (string) ID of the host.
        /// </summary>
        public string expandData;

        /// <summary>
        /// Expand macros in the trigger comment.
        /// </summary>
        public bool? expandComment;

        /// <summary>
        /// Expand macros in the name of the trigger.
        /// </summary>
        public bool? expandDescription;

        /// <summary>
        /// Expand functions and macros in the trigger expression.
        /// </summary>
        public bool? expandExpression;

        /// <summary>
        /// Return the host groups that the trigger belongs to in the groups property.
        /// </summary>
        public string selectGroups;

        /// <summary>
        ///  Return the hosts that the trigger belongs to in the hosts property.
        /// </summary>
        public string selectHosts = "extend";

        /// <summary>
        /// Return items contained by the trigger in the items property.
        /// </summary>
        public string[] selectItems;

        /// <summary>
        /// Return functions used in the trigger in the functions property. 
        /// The function objects represents the functions used in the trigger expression and has the following properties: 
        /// functionid - (string) ID of the function; 
        /// itemid - (string) ID of the item used in the function;
        /// function - (string) name of the function;
        /// parameter - (string) parameter passed to the function.
        /// </summary>
        public string selectFunctions = "extend";

        /// <summary>
        /// Return triggers that the trigger depends on in the dependencies property.
        /// </summary>
        public string selectDependencies = "extend";

        /// <summary>
        /// Return the low-level discovery rule that created the trigger.
        /// </summary>
        public string selectDiscoveryRule = "extend";

        /// <summary>
        /// Return the last significant trigger event in the lastEvent property.
        /// </summary>
        public string selectLastEvent;

        /// <summary>
        /// Return only those results that exactly match the given filter.
        /// Accepts an array, where the keys are property names, and the values are either a single value or an array of values to match against. 
        /// Supports additional filters: 
        /// host - technical name of the host that the trigger belongs to; 
        /// hostid - ID of the host that the trigger belongs to.
        /// </summary>
        public object filter;

        /// <summary>
        /// Limits the number of records returned by subselects. 
        /// Applies to the following subselects: 
        /// selectHosts - results will be sorted by host.
        /// </summary>
        public int? limitSelects;


        /// <summary>
        /// Sort the result by the given properties. 
        /// Possible values are: triggerid, description, status, priority, lastchange and hostname.
        /// </summary>
        public string[] sortfield;
    }
}