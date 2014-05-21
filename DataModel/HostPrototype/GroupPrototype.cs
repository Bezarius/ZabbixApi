namespace ZabbixApi.DataModel.HostPrototype
{
    public class GroupPrototype
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the group prototype.</param>
        public GroupPrototype(string name)
        {
            this.name = name;
        }

        /// <summary>
        ///  ID of the group prototype.
        /// </summary>
        public string group_prototypeid;

        /// <summary>
        /// Name of the group prototype.
        /// </summary>
        public string name;

        /// <summary>
        ///  ID of the host prototype
        /// </summary>
        public string hostid;

        /// <summary>
        ///  ID of the parent template group prototype.
        /// </summary>
        public string templateid;
    }
}