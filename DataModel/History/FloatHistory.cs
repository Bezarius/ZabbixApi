namespace ZabbixApi.DataModel.History
{
    public class FloatHistory : HistoryBase
    {
        /// <summary>
        /// Received value.
        /// </summary>
        public new float value;
    }

    public class TextHistory : StringHistory
    {
        /// <summary>
        /// ID of the history entry.
        /// </summary>
        public string id;
    }
}
