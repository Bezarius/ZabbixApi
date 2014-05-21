using ZabbixApi.Common;

namespace ZabbixApi.DataModel.UserGroup
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only user groups with the given status. Refer to the user group page for a list of supported statuses.
        /// </summary>
        public int status;

        /// <summary>
        /// Return only user groups that contain the given users.
        /// </summary>
        public string[] userids;

        /// <summary>
        /// Return only user groups with the given IDs.
        /// </summary>
        public string[] usrgrpids;

        /// <summary>
        /// Return only user groups with the given frontend authentication method. Refer to the user group page for a list of supported methods.
        /// </summary>
        public int with_gui_access;

        /// <summary>
        /// Return the users from the user group in the users property.
        /// </summary>
        public string selectUsers;

        /// <summary>
        /// Limits the number of records returned by subselects.
        /// </summary>
        public int limitSelects;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// usrgrpid, name.
        /// </summary>
        public string[] sortfield;
    }
}