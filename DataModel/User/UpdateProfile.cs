namespace ZabbixApi.DataModel.User
{
    public class UpdateProfile : User
    {
        /// <summary>
        /// User's password.
        /// </summary>
        public string passwd;

        /// <summary>
        /// User groups to replace existing user groups. The user groups must have the usrgrpid property defined.
        /// </summary>
        public object[] usrgrps;

        /// <summary>
        /// </summary>
        /// <param name="alias">User alias.</param>
        public UpdateProfile(string alias) : base(alias)
        {
        }
    }
}