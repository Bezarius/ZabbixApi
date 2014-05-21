namespace ZabbixApi.DataModel.UserGroup
{
    public class MassUpdate
    {
        /// <summary>
        /// </summary>
        /// <param name="usrgrpids">IDs of user groups to update.</param>
        public MassUpdate(string[] usrgrpids)
        {
            this.usrgrpids = usrgrpids;
        }
        
        /// <summary>
        /// IDs of user groups to update.
        /// </summary>
        public string[] usrgrpids;

        /// <summary>
        /// Permissions to replace the current permissions assigned to the user group.
        /// </summary>
        public Permission[] rights;

        /// <summary>
        /// IDs of the users to replace the users in the group.
        /// </summary>
        public string[] userids;
    }
}