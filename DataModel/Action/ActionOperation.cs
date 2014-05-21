namespace ZabbixApi.DataModel.Action
{
    public class ActionOperation
    {
        /// <summary>
        /// </summary>
        /// <param name="operationtype">Type of operation. 
        /// Possible values:
        ///  0 - send message;
        ///  1 - remote command;
        ///  2 - add host;
        ///  3 - remove host;
        ///  4 - add to host group;
        ///  5 - remove from host group;
        ///  6 - link to template;
        ///  7 - unlink from template;
        ///  8 - enable host;
        ///  9 - disable host.</param>
        public ActionOperation(int operationtype)
        {
            this.operationtype = operationtype;
        }

        /// <summary>
        ///  ID of the action operation.
        /// </summary>
        public string operationid;

        /// <summary>
        /// Type of operation. Possible values:
        ///  0 - send message;
        ///  1 - remote command;
        ///  2 - add host;
        ///  3 - remove host;
        ///  4 - add to host group;
        ///  5 - remove from host group;
        ///  6 - link to template;
        ///  7 - unlink from template;
        ///  8 - enable host;
        ///  9 - disable host.
        /// </summary>
        public int? operationtype;

        /// <summary>
        /// ID of the action that the operation belongs to.
        /// </summary>
        public string actionid;

        /// <summary>
        /// Duration of an escalation step in seconds. Must be greater than 60 seconds. If set to 0, the default action escalation period will be used. Default: 0.
        /// </summary>
        public int? esc_period;

        /// <summary>
        /// Step to start escalation from. Default: 1.
        /// </summary>
        public int? esc_step_from;

        /// <summary>
        /// Step to end escalation at. Default: 1.
        /// </summary>
        public int? esc_step_to;

        /// <summary>
        /// Operation condition evaluation method. Possible values: 0 - (default) AND / OR; 1 - AND; 2 - OR.
        /// </summary>
        public int? evaltype;

        /// <summary>
        /// Object containing the data about the command run by the operation. The operation command object is described in detail below. Required for remote command operations.
        /// </summary>
        public object opcommand;

        /// <summary>
        /// Host groups to run remote commands on. Each object has the following properties: opcommand_grpid - (string, readonly) ID of the object; operationid - (string) ID of the operation; groupid - (string) ID of the host group. Required for remote command operations if opcommand_hst is not set.
        /// </summary>
        public string[] opcommand_grp;

        /// <summary>
        /// Host to run remote commands on. Each object has the following properties: opcommand_hstid - (string, readonly) ID of the object; operationid - (string) ID of the operation; hostid - (string) ID of the host; if set to 0 the command will be run on the current host. Required for remote command operations if opcommand_grp is not set.
        /// </summary>
        public string[] opcommand_hst;

        /// <summary>
        /// Operation conditions used for trigger actions. The operation condition object is described in detail below.
        /// </summary>
        public string[] opconditions;

        /// <summary>
        /// Host groups to add hosts to. Each object has the following properties: operationid - (string) ID of the operation; groupid - (string) ID of the host group. Required for “add to host group” and “remove from host group” operations.
        /// </summary>
        public string[] opgroup;

        /// <summary>
        /// Object containing the data about the message sent by the operation. The operation message object is described in detail below. Required for message operations.
        /// </summary>
        public object opmessage;

        /// <summary>
        /// User groups to send messages to. Each object has the following properties: operationid - (string) ID of the operation; usrgrpid - (string) ID of the user group. Required for message operations if opmessage_usr is not set.
        /// </summary>
        public string[] opmessage_grp;

        /// <summary>
        /// Users to send messages to. Each object has the following properties: operationid - (string) ID of the operation; userid - (string) ID of the user. Required for message operations if opmessage_grp is not set.
        /// </summary>
        public string[] opmessage_usr;

        /// <summary>
        /// Templates to link the hosts to to. Each object has the following properties: operationid - (string) ID of the operation; templateid - (string) ID of the template. Required for “link to template” and “unlink from template” operations.
        /// </summary>
        public string[] optemplate;
    }
}