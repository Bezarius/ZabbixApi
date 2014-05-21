using ZabbixApi.Common;

namespace ZabbixApi.DataModel.GraphPrototype
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only graph prototypes that belong to the given discovery rules.
        /// </summary>
        public string[] discoveryids;

        /// <summary>
        /// Return only graph prototypes with the given IDs.
        /// </summary>
        public string[] graphids;

        /// <summary>
        /// Return only graph prototypes that belong to hosts in the given host groups.
        /// </summary>
        public string[] groupids;

        /// <summary>
        /// Return only graph prototypes that belong to the given hosts.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// If set to true return only graph prototypes inherited from a template.
        /// </summary>
        public bool inherited;

        /// <summary>
        /// Return only graph prototypes that contain the given item prototypes.
        /// </summary>
        public string[] itemids;

        /// <summary>
        /// If set to true return only graph prototypes that belong to templates.
        /// </summary>
        public bool templated;

        /// <summary>
        /// Return only graph prototypes that belong to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Return the LLD rule that the graph prototype belongs to in the discoveryRule property.
        /// </summary>
        public string selectDiscoveryRule;

        /// <summary>
        /// Return the graph items used in the graph prototype in the gitems property.
        /// </summary>
        public string selectGraphItems;

        /// <summary>
        /// Return the host groups that the graph prototype belongs to in the groups property.
        /// </summary>
        public string selectGroups;

        /// <summary>
        /// Return the hosts that the graph prototype belongs to in the hosts property.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// Return the items and item prototypes used in the graph prototype in the items property.
        /// </summary>
        public string selectItems;

        /// <summary>
        /// Return the templates that the graph prototype belongs to in the templates property.
        /// </summary>
        public string selectTemplates;

        /// <summary>
        /// Return only those results that exactly match the given filter. Accepts an array, where the keys are property names, and the values are either a single value or an array of values to match against.
        /// Supports additional filters:
        /// host - technical name of the host that the graph prototype belongs to;
        /// hostid - ID of the host that the graph prototype belongs to.
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