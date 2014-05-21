namespace ZabbixApi.DataModel.Alert
{
    public class Alert
    {
        /// <summary>
        /// ID of the alert.
        /// </summary>
        public string alertid;

        /// <summary>
        /// ID of the action that generated the alert.
        /// </summary>
        public string actionid;

        /// <summary>
        /// 
        /// Alert type.
        /// Possible values:
        /// 0 - message;
        /// 1 - remote command.
        /// </summary>
        public int alerttype;

        /// <summary>
        /// Time when the alert was generated.
        /// </summary>
        public long clock;

        /// <summary>
        /// Error text if there are problems sending a message or running a command.
        /// </summary>
        public string error;

        /// <summary>
        /// Action escalation step during which the alert was generated.
        /// </summary>
        public int esc_step;

        /// <summary>
        /// ID of the event that triggered the action.
        /// </summary>
        public string eventid;

        /// <summary>
        /// ID of the media type that was used to send the message.
        /// </summary>
        public string mediatypeid;

        /// <summary>
        /// Message text. Used for message alerts.
        /// </summary>
        public string message;

        /// <summary>
        /// Number of times Zabbix tried to send the message.
        /// </summary>
        public int retries;

        /// <summary>
        /// Address, user name or other identifier of the recipient. Used for message alerts.
        /// </summary>
        public string sendto;

        /// <summary>
        /// 
        /// Status indicating whether the action operation has been executed successfully.
        /// Possible values for message alerts:
        /// 0 - message not sent;
        /// 1 - message sent;
        /// 2 - failed after a number of retries.
        /// Possible values for command alerts:
        /// 1 - command run;
        /// 2 - tried to run the command on the Zabbix agent but it was unavailable.
        /// </summary>
        public int status;

        /// <summary>
        /// Message subject. Used for message alerts.
        /// </summary>
        public string subject;

        /// <summary>
        /// ID of the user that the message was sent to.
        /// </summary>
        public string userid;
    }
}
