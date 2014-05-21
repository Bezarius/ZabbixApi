namespace ZabbixApi.DataModel.Media
{
    public class Media
    {
        /// <summary>
        /// </summary>
        /// <param name="active">
        /// Whether the media is enabled.
        /// Possible values:
        /// 0 - enabled;
        /// 1 - disabled.</param>
        /// <param name="mediatypeid">ID of the media type used by the media.</param>
        /// <param name="period">Time when the notifications can be sent as a time period.</param>
        /// <param name="sendto">Address, user name or other identifier of the recipient.</param>
        /// <param name="severity">Trigger severities to send notifications about. Severities are stored in binary form with each bit representing the corresponding severity. For example, 12 equals 1100 in binary and means, that notifications will be sent from triggers with severities warning and average. Refer to the trigger object page for a list of supported trigger severities.</param>
        /// <param name="userid">ID of the user that uses the media.</param>
        public Media(int active, string mediatypeid, string period, string sendto, int severity, string userid)
        {
            this.active = active;
            this.mediatypeid = mediatypeid;
            this.period = period;
            this.sendto = sendto;
            this.severity = severity;
            this.userid = userid;
        }

        /// <summary>
        ///  ID of the media.
        /// </summary>
        public string mediaid;

        /// <summary>
        /// Whether the media is enabled.
        /// Possible values:
        /// 0 - enabled;
        /// 1 - disabled.
        /// </summary>
        public int active;

        /// <summary>
        /// ID of the media type used by the media.
        /// </summary>
        public string mediatypeid;

        /// <summary>
        /// Time when the notifications can be sent as a time period.
        /// </summary>
        public string period;

        /// <summary>
        /// Address, user name or other identifier of the recipient.
        /// </summary>
        public string sendto;

        /// <summary>
        /// Trigger severities to send notifications about. Severities are stored in binary form with each bit representing the corresponding severity. For example, 12 equals 1100 in binary and means, that notifications will be sent from triggers with severities warning and average. Refer to the trigger object page for a list of supported trigger severities.
        /// </summary>
        public int severity;

        /// <summary>
        /// ID of the user that uses the media.
        /// </summary>
        public string userid;
    }
}
