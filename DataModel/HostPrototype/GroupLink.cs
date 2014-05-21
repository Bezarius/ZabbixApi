namespace ZabbixApi.DataModel.HostPrototype
{
    public class GroupLink
    {
        /// <summary>
        /// </summary>
        /// <param name="groupid">ID of the host group.</param>
        public GroupLink(string groupid)
        {
            this.groupid = groupid;
        }

        /// <summary>
        ///  ID of the group link.
        /// </summary>
        public string group_prototypeid;

        /// <summary>
        /// ID of the host group.
        /// </summary>
        public string groupid;

        /// <summary>
        ///  ID of the host prototype
        /// </summary>
        public string hostid;

        /// <summary>
        ///  ID of the parent template group link.
        /// </summary>
        public string templateid;
    }
}