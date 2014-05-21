using ZabbixApi.Common;

namespace ZabbixApi.DataModel.HostPrototype
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only host prototypes with the given IDs.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Return only host prototype that belong to the given LLD rules.
        /// </summary>
        public string[] discoveryids;

        /// <summary>
        /// If set to true return only items inherited from a template.
        /// </summary>
        public bool inherited;

        /// <summary>
        /// Return the LLD rule that the host prototype belongs to in the discoveryRule property.
        /// </summary>
        public string selectDiscoveryRule;

        /// <summary>
        /// Return the group links of the host prototype in the groupLinks property.
        /// </summary>
        public string selectGroupLinks;

        /// <summary>
        /// Return the group prototypes of the host prototype in the groupPrototypes property.
        /// </summary>
        public string selectGroupPrototypes;

        /// <summary>
        /// Return the host prototype inventory in the inventory property. Possible values are true to return all of the data, or an array of property names to return only specific properties.
        /// </summary>
        public bool[] selectInventory;

        /// <summary>
        /// Return the host that the host prototype belongs to in the parentHost property.
        /// </summary>
        public string selectParentHost;

        /// <summary>
        /// Return the templates linked to the host prototype in the templates property.
        /// </summary>
        public string selectTemplates;
    }
}