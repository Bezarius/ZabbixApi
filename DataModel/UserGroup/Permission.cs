namespace ZabbixApi.DataModel.UserGroup
{
    public class Permission
    {
        /// <summary>
        /// </summary>
        /// <param name="id">ID of the host group to add permission to.</param>
        /// <param name="permission">
        /// Access level to the host group.
        /// Possible values:
        /// 0 - access denied;
        /// 2 - read-only access;
        /// 3 - read-write access.</param>
        public Permission(string id, int permission)
        {
            this.id = id;
            this.permission = permission;
        }

        /// <summary>
        /// ID of the host group to add permission to.
        /// </summary>
        public string id;

        /// <summary>
        /// Access level to the host group.
        /// Possible values:
        /// 0 - access denied;
        /// 2 - read-only access;
        /// 3 - read-write access.
        /// </summary>
        public int permission;
    }
}