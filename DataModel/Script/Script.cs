namespace ZabbixApi.DataModel.Script
{
    public class Script
    {
        /// <summary>
        /// </summary>
        /// <param name="command">Command to run.</param>
        /// <param name="name">Name of the script.</param>
        public Script(string command, string name)
        {
            this.command = command;
            this.name = name;
        }

        /// <summary>
        ///  ID of the script.
        /// </summary>
        public string scriptid;

        /// <summary>
        /// Command to run.
        /// </summary>
        public string command;

        /// <summary>
        /// Name of the script.
        /// </summary>
        public string name;

        /// <summary>
        /// Confirmation pop up text. The pop up will appear when trying to run the script from the Zabbix frontend.
        /// </summary>
        public string confirmation;

        /// <summary>
        /// Description of the script.
        /// </summary>
        public string description;

        /// <summary>
        /// Where to run the script.
        /// Possible values:
        /// 0 - run on Zabbix agent;
        /// 1 - (default) run on Zabbix server.
        /// </summary>
        public int execute_on;

        /// <summary>
        /// ID of the host group that the script can be run on. If set to 0, the script will be available on all host groups.
        /// Default: 0.
        /// </summary>
        public string groupid;

        /// <summary>
        /// Host permissions needed to run the script.
        /// Possible values:
        /// 2 - (default) read;
        /// 3 - write.
        /// </summary>
        public int host_access;

        /// <summary>
        /// Script type.
        /// Possible values:
        /// 0 - (default) script;
        /// 1 - IPMI.
        /// </summary>
        public int type;

        /// <summary>
        /// ID of the user group that will be allowed to run the script. If set to 0, the script will be available for all user groups.
        /// Default: 0.
        /// </summary>
        public string usrgrpid;
    }
}
