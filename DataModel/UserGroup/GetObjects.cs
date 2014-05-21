namespace ZabbixApi.DataModel.UserGroup
{
    public class GetObjects : UserGroup
    {
        /// <summary>
        /// Name of the user group.
        /// </summary>
        public string name;

        /// <summary>
        /// Name of the node the user groups must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the user groups must belong to.
        /// </summary>
        public string[] nodeids;

        /// <summary>
        /// </summary>
        /// <param name="name">Name of the user group.</param>
        public GetObjects(string name)
            : base(name)
        {
        }
    }
}