using ZabbixApi.Common;

namespace ZabbixApi.DataModel.User
{
    public class Get : CommonGet
    {
        /// <summary>
        /// Return only users that use the given media.
        /// </summary>
        public string[] mediaids;

        /// <summary>
        /// Return only users that use the given media types.
        /// </summary>
        public string[] mediatypeids;

        /// <summary>
        /// Return only users with the given IDs.
        /// </summary>
        public string[] userids;

        /// <summary>
        /// Return only users that belong to the given user groups.
        /// </summary>
        public string[] usrgrpids;

        /// <summary>
        /// Adds additional information about user permissions.
        /// Adds the following properties for each user:
        /// gui_access - (integer) user's frontend authentication method. Refer to the gui_access property of the user group object for a list of possible values. debug_mode - (integer) indicates whether debug is enabled for the user.
        /// Possible values:
        /// 0 - debug disabled, 1 - debug enabled. users_status - (integer) indicates whether the user is disabled.
        /// Possible values:
        /// 0 - user enabled, 1 - user disabled.
        /// </summary>
        public bool getAccess;

        /// <summary>
        /// Return media used by the user in the medias property.
        /// </summary>
        public string selectMedias;

        /// <summary>
        /// Return media types used by the user in the mediatypes property.
        /// </summary>
        public string selectMediatypes;

        /// <summary>
        /// Return user groups that the user belongs to in the usrgrps property.
        /// </summary>
        public string selectUsrgrps;

        /// <summary>
        /// 
        ///Sort the result by the given properties.
        /// Possible values are:
        /// userid and alias.
        /// </summary>
        public string[] sortfield;
    }
}