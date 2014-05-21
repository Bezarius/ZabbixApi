using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Graph
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only graphs with the given IDs.
        /// </summary>
        public string[] graphids;

        /// <summary>
        /// Return only graphs that belong to hosts in the given host groups.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Return only graph that belong to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Return only graphs that belong to the given hosts.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Return only graphs that contain the given items.
        /// </summary>
        public string[] itemids;

        /// <summary>
        /// If set to true return only graphs that belong to templates.
        /// </summary>
        public bool templated;

        /// <summary>
        /// If set to true return only graphs inherited from a template.
        /// </summary>
        public bool inherited;

        /// <summary>
        /// Expand macros in the graph name.
        /// </summary>
        public string expandName;

        /// <summary>
        /// Return the host groups that the graph belongs to in the groups property.
        /// </summary>
        public string selectGroups;

        /// <summary>
        /// Return the templates that the graph belongs to in the templates property.
        /// </summary>
        public string selectTemplates;

        /// <summary>
        /// Return the hosts that the graph belongs to in the hosts property.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// Return the items used in the graph in the items property.
        /// </summary>
        public string selectItems;

        /// <summary>
        /// Return the graph items used in the graph in the gitems property.
        /// </summary>
        public string selectGraphItems;

        /// <summary>
        /// Return the low-level discovery rule that created the graph in the discoveryRule property.
        /// </summary>
        public string selectDiscoveryRule;

        /// <summary>
        /// Return only those results that exactly match the given filter. Accepts an array, where the keys are property names, and the values are either a single value or an array of values to match against.
        /// Supports additional filters:
        /// host - technical name of the host that the graph belongs to;
        /// hostid - ID of the host that the graph belongs to.
        /// </summary>
        public object filter;

        /// <summary>
        /// Sort the result by the given properties.
        /// Possible values are:
        /// graphid, name and graphtype.
        /// </summary>
        public string[] sortfield;
    }
}