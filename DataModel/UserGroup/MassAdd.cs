namespace ZabbixApi.DataModel.UserGroup
{
    public class MassAdd
    {
        /// <summary>
        /// </summary>
        /// <param name="usrgrpids">IDs of user groups to update.</param>
        public MassAdd(string[] usrgrpids)
        {
            this.usrgrpids = usrgrpids;
        }

        /// <summary>
        /// IDs of user groups to update.
        /// </summary>
        public string[] usrgrpids;

        /// <summary>
        /// Permissions to assign to the user groups.
        /// </summary>
        public Permission[] rights;

        /// <summary>
        /// IDs of the users to add to the user groups.
        /// </summary>
        public string[] userids;
    }
}