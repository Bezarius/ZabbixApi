namespace ZabbixApi.DataModel.History
{
    public class HistoryBase
    {
        /// <summary>
        /// Time when that value was received.
        /// </summary>
        public string clock;

        /// <summary>
        /// ID of the related item.
        /// </summary>
        public string itemid;

        /// <summary>
        /// Nanoseconds when the value was received.
        /// </summary>
        public int ns;

        /// <summary>
        /// Received value.
        /// </summary>
        public object value;
    }
}