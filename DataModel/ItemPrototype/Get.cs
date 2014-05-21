using ZabbixApi.Common;

namespace ZabbixApi.DataModel.ItemPrototype
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only item prototypes that belong to the given LLD rules.
        /// </summary>
        public string[] discoveryids;

        /// <summary>
        /// Return only item prototypes that are used in the given graph prototypes.
        /// </summary>
        public string[] graphids;

        /// <summary>
        /// Return only item prototypes that belong to the given hosts.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// If set to true return only item prototypes inherited from a template.
        /// </summary>
        public bool inherited;

        /// <summary>
        /// Return only item prototypes with the given IDs.
        /// </summary>
        public string[] itemids;

        /// <summary>
        /// If set to true return only enabled item prototypes that belong to monitored hosts.
        /// </summary>
        public bool monitored;

        /// <summary>
        /// If set to true return only item prototypes that belong to templates.
        /// </summary>
        public bool templated;

        /// <summary>
        /// Return only item prototypes that belong to the given templates.
        /// </summary>
        public string[] templateids;

        /// <summary>
        /// Return only item prototypes that are used in the given trigger prototypes.
        /// </summary>
        public string[] triggerids;

        /// <summary>
        /// Return applications that the item prototype belongs to in the applications property. Does not support shorten or arrays of properties.
        /// </summary>
        public string selectApplications;

        /// <summary>
        /// 
        ///Return graph prototypes that the item prototype is used in in the graphs property.
        /// Supports count;
        /// does not support shorten or arrays of properties.
        /// </summary>
        public string selectGraphs;

        /// <summary>
        /// Returns the host that the item prototype belongs to as an array in the hosts property. Does not support shorten.
        /// </summary>
        public string selectHosts;

        /// <summary>
        /// 
        ///Return trigger prototypes that the item prototype is used in in the triggers property.
        /// Supports count;
        /// does not support shorten or arrays of properties.
        /// </summary>
        public string selectTriggers;

        /// <summary>
        /// 
        ///Return only those results that exactly match the given filter. Accepts an array, where the keys are property names, and the values are either a single value or an array of values to match against.
        /// Supports additional filters:
        /// host - technical name of the host that the item prototype belongs to.
        /// </summary>
        public object filter;

        /// <summary>
        /// 
        ///Limits the number of records returned by subselects.
        /// Applies to the following subselects:
        /// selectGraphs - results will be sorted by name;
        /// selectTriggers - results will be sorted by description.
        /// </summary>
        public int limitSelects;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// itemid, name, key_, delay, type and status.
        /// </summary>
        public string[] sortfield;
    }
}