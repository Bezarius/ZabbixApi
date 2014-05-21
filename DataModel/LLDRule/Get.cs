using ZabbixApi.Common;

namespace ZabbixApi.DataModel.LLDRule
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only LLD rules with the given IDs.
        /// </summary>
        public string[] itemids;

        /// <summary>
        /// Return only LLD rules that belong to the given hosts.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// If set to true return only LLD rules inherited from a template.
        /// </summary>
        public bool inherited;

        /// <summary>
        /// Return only LLD rules use the given host interfaces.
        /// </summary>
        public string[] interfaceids;

        /// <summary>
        /// If set to true return only enabled LLD rules that belong to monitored hosts.
        /// </summary>
        public bool monitored;

        /// <summary>
        /// If set to true return only LLD rules that belong to templates.
        /// </summary>
        public bool templated;

        /// <summary>
        /// Return only LLD rules that belong to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Returns the host that the LLD rule belongs to as an array in the hosts property.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// Returns graph prototypes that belong to the LLD rule in the graphs property. Supports count.
        /// </summary>
        public string selectGraphs;

        /// <summary>
        /// Returns host prototypes that belong to the LLD rule in the hostPrototypes property. Supports count.
        /// </summary>
        public string selectHostPrototypes;

        /// <summary>
        /// Returns item prototypes that belong to the LLD rule in the items property. Supports count.
        /// </summary>
        public string selectItems;

        /// <summary>
        /// Returns trigger prototypes that belong to the LLD rule in the triggers property. Supports count.
        /// </summary>
        public string selectTriggers;

        /// <summary>
        /// Return only those results that exactly match the given filter. Accepts an array, where the keys are property names, and the values are either a single value or an array of values to match against. Supports additional filters: host - technical name of the host that the LLD rule belongs to.
        /// </summary>
        public object filter;

        /// <summary>
        /// Limits the number of records returned by subselects. Applies to the following subselects: selctItems; selectGraphs; selectTriggers.
        /// </summary>
        public int limitSelects;

        /// <summary>
        /// Sort the result by the given properties. Possible values are: itemid, name, key_, delay, type and status.
        /// </summary>
        public string[] sortfield;
    }
}