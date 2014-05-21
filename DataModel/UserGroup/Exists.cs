namespace ZabbixApi.DataModel.UserGroup
{
    public class Exists
    {
        /// <summary>
        /// Names of the user groups.
        /// </summary>
        public string[] name;

        /// <summary>
        /// Name of the node the user groups must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the user groups must belong to.
        /// </summary>
        public string[] nodeids;
    }
}