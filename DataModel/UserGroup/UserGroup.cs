namespace ZabbixApi.DataModel.UserGroup
{
    public class UserGroup
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the user group.</param>
        public UserGroup(string name)
        {
            this.name = name;
        }

        /// <summary>
        ///  ID of the user group.
        /// </summary>
        public string usrgrpid;

        /// <summary>
        /// Name of the user group.
        /// </summary>
        public string name;

        /// <summary>
        /// Whether debug mode is enabled or disabled.
        /// Possible values are:
        /// 0 - (default) disabled;
        /// 1 - enabled.
        /// </summary>
        public int debug_mode;

        /// <summary>
        /// Frontend authentication method of the users in the group.
        /// Possible values:
        /// 0 - (default) use the system default authentication method;
        /// 1 - use internal authentication;
        /// 2 - disable access to the frontend.
        /// </summary>
        public int gui_access;

        /// <summary>
        /// Whether the user group is enabled or disabled.
        /// Possible values are:
        /// 0 - (default) enabled;
        /// 1 - disabled.
        /// </summary>
        public int users_status;
    }
}
