namespace ZabbixApi.DataModel.User
{
    public class Create : User
    {
        /// <summary>
        /// </summary>
        /// <param name="alias">User alias.</param>
        /// /// <param name="passwd">User's password.</param>
        /// <param name="usrgrps">User groups to add the user to. The user groups must have the usrgrp property defined.</param>
        public Create(string alias, string passwd, object[] usrgrps)
            : base(alias)
        {
            this.passwd = passwd;
            this.usrgrps = usrgrps;
        }

        /// <summary>
        /// User's password.
        /// </summary>
        public string passwd;

        /// <summary>
        /// User groups to add the user to. The user groups must have the usrgrp property defined.
        /// </summary>
        public object[] usrgrps;

        /// <summary>
        /// Media to create for the user. The media userid property must not be defined.
        /// </summary>
        public object[] user_medias;
    }
}