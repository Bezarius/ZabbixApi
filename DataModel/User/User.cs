namespace ZabbixApi.DataModel.User
{
    public class User
    {
        /// <summary>
        /// </summary>
        /// <param name="alias">User alias.</param>
        public User(string alias)
        {
            this.alias = alias;
        }

        /// <summary>
        ///  ID of the user.
        /// </summary>
        public string userid;

        /// <summary>
        /// User alias.
        /// </summary>
        public string alias;

        /// <summary>
        ///  Time of the last unsuccessful login attempt.
        /// </summary>
        public long attempt_clock;

        /// <summary>
        ///  Recent failed login attempt count.
        /// </summary>
        public int attempt_failed;

        /// <summary>
        ///  IP address from where the last unsuccessful login attempt came from.
        /// </summary>
        public string attempt_ip;

        /// <summary>
        /// Whether to enable auto-login.
        /// Possible values:
        /// 0 - (default) auto-login disabled;
        /// 1 - auto-login enabled.
        /// </summary>
        public int autologin;

        /// <summary>
        /// User session life time in seconds. If set to 0, the session will never expire.
        /// Default: 900.
        /// </summary>
        public int autologout;

        /// <summary>
        /// Language code of the user's language.
        /// Default: en_GB.
        /// </summary>
        public string lang;

        /// <summary>
        /// Name of the user.
        /// </summary>
        public string name;

        /// <summary>
        /// Automatic refresh period in seconds.
        /// Default: 30.
        /// </summary>
        public int refresh;

        /// <summary>
        /// Amount of object rows to show per page.
        /// Default: 50.
        /// </summary>
        public int rows_per_page;

        /// <summary>
        /// Surname of the user.
        /// </summary>
        public string surname;

        /// <summary>
        /// User's theme.
        /// Possible values:
        /// default - (default) system default;
        /// classic - Classic;
        /// originalblue - Original blue;
        /// darkblue - Black & Blue;
        /// darkorgange - Dark orange.
        /// </summary>
        public string theme;

        /// <summary>
        /// Type of the user.
        /// Possible values:
        /// 1 - (default) Zabbix user;
        /// 2 - Zabbix admin;
        /// 3 - Zabbix super admin.
        /// </summary>
        public int type;

        /// <summary>
        /// URL of the page to redirect the user to after logging in.
        /// </summary>
        public string url;
    }
}
