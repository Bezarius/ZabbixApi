namespace ZabbixApi.DataModel.HostGroup
{
    public class HostGroup
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the host group.</param>
        public HostGroup(string name)
        {
            this.name = name;
        }

        /// <summary>
        ///  ID of the host group.
        /// </summary>
        public string groupid;

        /// <summary>
        /// Name of the host group.
        /// </summary>
        public string name;

        /// <summary>
        /// Origin of the host group. 
        /// Possible values:
        ///  0 - a plain host group;
        ///  4 - a discovered host group.
        /// </summary>
        public int flags;

        /// <summary>
        ///  Whether the group is used internally by the system. An internal group cannot be deleted.
        ///  Possible values:
        ///  0 - (default) not internal;
        ///  1 - internal.
        /// </summary>
        public int @internal;
    }
}
