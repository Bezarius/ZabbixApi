namespace ZabbixApi.DataModel.History
{
    public class LogHistory : TextHistory
    {
        /// <summary>
        /// Windows event log entry ID.
        /// </summary>
        public int logeventid;

        /// <summary>
        /// Windows event log entry level.
        /// </summary>
        public int severity;

        /// <summary>
        /// Windows event log entry source.
        /// </summary>
        public string source;

        /// <summary>
        /// Windows event log entry time.
        /// </summary>
        public string timestamp;
    }
}