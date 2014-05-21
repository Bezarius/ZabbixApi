namespace ZabbixApi.DataModel.DiscoveryRule
{
    public class Exists
    {
        /// <summary>
        /// IDs of discovery rules.
        /// </summary>
        public string[] druleids;

        /// <summary>
        /// Names of discovery rules.
        /// </summary>
        public string[] name;

        /// <summary>
        /// Name of the node the discrovery rules must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the discrovery rules must belong to.
        /// </summary>
        public string[] nodeids;
    }
}