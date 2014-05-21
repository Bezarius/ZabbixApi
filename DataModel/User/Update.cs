namespace ZabbixApi.DataModel.User
{
    public class Update : User
    {
        /// <summary>
        /// </summary>
        /// <param name="alias">User alias.</param>
        public Update(string alias)
            : base(alias)
        {
        }

        /// <summary>
        /// User's password.
        /// </summary>
        public string passwd;

        /// <summary>
        /// User groups to replace existing user groups. The user groups must have the usrgrpid property defined.
        /// </summary>
        public UserGroup.UserGroup[] usrgrps;
    }
}