namespace ZabbixApi.DataModel.Action
{
    public class ActionOperationCommand
    {
        /// <summary>
        /// </summary>
        /// <param name="command">Command to run.</param>
        /// <param name="type">
        ///Type of operation command.
        /// Possible values:
        /// 0 - custom script;
        /// 1 - IPMI;
        /// 2 - SSH;
        /// 3 - Telnet;
        /// 4 - global script.</param>
        public ActionOperationCommand(string command, int type)
        {
            this.command = command;
            this.type = type;
        }

        /// <summary>
        ///  ID of the operation.
        /// </summary>
        public string operationid;

        /// <summary>
        /// Command to run.
        /// </summary>
        public string command;

        /// <summary>
        /// 
        ///Type of operation command.
        /// Possible values:
        /// 0 - custom script;
        /// 1 - IPMI;
        /// 2 - SSH;
        /// 3 - Telnet;
        /// 4 - global script.
        /// </summary>
        public int? type;

        /// <summary>
        /// 
        ///Authentication method used for SSH commands.
        /// Possible values:
        /// 0 - password;
        /// 1 - public key.
        /// Required for SSH commands.
        /// </summary>
        public int? authtype;

        /// <summary>
        /// 
        ///Target on which the custom script operation command will be executed.
        /// Possible values:
        /// 0 - Zabbix agent;
        /// 1 - Zabbix server.
        /// Required for custom script commands.
        /// </summary>
        public int? execute_on;

        /// <summary>
        /// Password used for SSH commands with password authentication and Telnet commands.
        /// </summary>
        public string password;

        /// <summary>
        /// Port number used for SSH and Telnet commands.
        /// </summary>
        public string port;

        /// <summary>
        /// Name of the private key file used for SSH commands with public key authentication. Required for SSH commands with public key authentication.
        /// </summary>
        public string privatekey;

        /// <summary>
        /// Name of the public key file used for SSH commands with public key authentication. Required for SSH commands with public key authentication.
        /// </summary>
        public string publickey;

        /// <summary>
        /// ID of the script used for global script commands. Required for global script commands.
        /// </summary>
        public string scriptid;

        /// <summary>
        /// User name used for authentication. Required for SSH and Telnet commands.
        /// </summary>
        public string username;
    }
}