namespace ZabbixApi.DataModel.Action
{
    public class ActionOperationMessage
    {
        /// <summary>
        ///  ID of the action operation.
        /// </summary>
        public string operationid;

        /// <summary>
        /// 
        ///Whether to use the default action message text and subject.
        /// Possible values:
        /// 0 - (default) use the data from the operation;
        /// 1 - use the data from the action.
        /// </summary>
        public int? default_msg;

        /// <summary>
        /// ID of the media type that will be used to send the message.
        /// </summary>
        public string mediatypeid;

        /// <summary>
        /// Operation message text.
        /// </summary>
        public string message;

        /// <summary>
        /// Operation message subject.
        /// </summary>
        public string subject;
    }
}