namespace ZabbixApi.DataModel.MediaType
{
    public class MediaType
    {
        /// <summary>
        /// </summary>
        /// <param name="description">Name of the media type.</param>
        /// <param name="type">
        /// Transport used by the media type.
        /// Possible values:
        /// 0 - email;
        /// 1 - script;
        /// 2 - SMS;
        /// 3 - Jabber;
        /// 100 - Ez Texting.</param>
        public MediaType(string description, int type)
        {
            this.description = description;
            this.type = type;
        }

        /// <summary>
        ///  ID of the media type.
        /// </summary>
        public string mediatypeid;

        /// <summary>
        /// Name of the media type.
        /// </summary>
        public string description;

        /// <summary>
        /// Transport used by the media type.
        /// Possible values:
        /// 0 - email;
        /// 1 - script;
        /// 2 - SMS;
        /// 3 - Jabber;
        /// 100 - Ez Texting.
        /// </summary>
        public int type;

        /// <summary>
        /// 
        ///For script media types exec_path contains the name of the executed script. For Ez Texting exec_path contains the message text limit.
        /// Possible text limit values:
        /// 0 - USA (160 characters);
        /// 1 - Canada (136 characters).
        /// Required for script and Ez Texting media types.
        /// </summary>
        public string exec_path;

        /// <summary>
        /// Serial device name of the GSM modem. Required for SMS media types.
        /// </summary>
        public string gsm_modem;

        /// <summary>
        /// Authentication password. Required for Jabber and Ez Texting media types.
        /// </summary>
        public string passwd;

        /// <summary>
        /// Email address from which notifications will be sent. Required for email media types.
        /// </summary>
        public string smtp_email;

        /// <summary>
        /// SMTP HELO. Required for email media types.
        /// </summary>
        public string smtp_helo;

        /// <summary>
        /// SMTP server. Required for email media types.
        /// </summary>
        public string smtp_server;

        /// <summary>
        /// Whether the media type is enabled.
        /// Possible values:
        /// 0 - (default) enabled;
        /// 1 - disabled.
        /// </summary>
        public int status;

        /// <summary>
        /// Username or Jabber identifier. Required for Jabber and Ez Texting media types.
        /// </summary>
        public string username;
    }
}
