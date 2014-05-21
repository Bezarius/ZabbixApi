namespace ZabbixApi.DataModel.HostGroup
{
    public class GetObjects
    {
        /// <summary>
        ///  Host group IDs.
        /// </summary>
        public string[] groupid;

        /// <summary>
        ///  Names of the host groups.
        /// </summary>
        public string[] name;

        /// <summary>
        ///  Name of the node the host groups must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        ///  IDs of the nodes the host groups must belong to.
        /// </summary>
        public string[] nodeids;
    }
}