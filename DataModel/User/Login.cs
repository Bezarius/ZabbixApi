namespace ZabbixApi.DataModel.User
{
    public class Login
    {
        /// <summary>
        /// </summary>
        /// <param name="password">User password. Unused for HTTP authentication.</param>
        /// <param name="user">User name.</param>
        public Login(string password, string user)
        {
            this.password = password;
            this.user = user;
        }


        /// <summary>
        /// User password. Unused for HTTP authentication.
        /// </summary>
        public string password;

        /// <summary>
        /// User name.
        /// </summary>
        public string user;

        /// <summary>
        /// Return information about the authenticated user.
        /// </summary>
        public bool userData;
    }
}