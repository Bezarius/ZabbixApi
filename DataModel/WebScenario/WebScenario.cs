namespace ZabbixApi.DataModel.WebScenario
{
    public class WebScenario
    {
        /// <summary>
        /// </summary>
        /// <param name="hostid">ID of the host that the web scenario belongs to.</param>
        /// <param name="name">Name of the web scenario.</param>
        public WebScenario(string hostid, string name)
        {
            this.hostid = hostid;
            this.name = name;
        }
        
        /// <summary>
        ///  ID of the web scenario.
        /// </summary>
        public string httptestid;

        /// <summary>
        /// ID of the host that the web scenario belongs to.
        /// </summary>
        public string hostid;

        /// <summary>
        /// Name of the web scenario.
        /// </summary>
        public string name;

        /// <summary>
        /// User agent string that will be used by the web scenario.
        /// </summary>
        public string agent;

        /// <summary>
        /// ID of the application that the web scenario belongs to.
        /// </summary>
        public string applicationid;

        /// <summary>
        /// Authentication method that will be used by the web scenario.
        /// Possible values:
        /// 0 - (default) none;
        /// 1 - basic HTTP authentication;
        /// 2 - NTLM authentication.
        /// </summary>
        public int authentication;

        /// <summary>
        /// Execution interval of the web scenario in seconds.
        /// Default: 60.
        /// </summary>
        public int delay;

        /// <summary>
        /// Password used for authentication. Required for web scenarios with basic HTTP or NTLM authentication.
        /// </summary>
        public string http_password;

        /// <summary>
        /// Proxy that will be used by the web scenario given as http://[username[:password]@]proxy.example.com[:port].
        /// </summary>
        public string http_proxy;

        /// <summary>
        /// User name used for authentication. Required for web scenarios with basic HTTP or NTLM authentication.
        /// </summary>
        public string http_user;

        /// <summary>
        ///  Time of the next web scenario execution.
        /// </summary>
        public long nextcheck;

        /// <summary>
        /// Number of times a web scenario will try to execute each step before failing.
        /// Default: 1.
        /// </summary>
        public int retries;

        /// <summary>
        /// Whether the web scenario is enabled.
        /// Possible values are:
        /// 0 - (default) enabled;
        /// 1 - disabled.
        /// </summary>
        public int status;

        /// <summary>
        ///  ID of the parent template web scenario.
        /// </summary>
        public string templateid;

        /// <summary>
        /// Web scenario variables.
        /// </summary>
        public string variables;
    }
}