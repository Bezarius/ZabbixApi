namespace ZabbixApi.DataModel.Trends
{
    public class Trend
    {
        /// <summary>
        /// Time when that value was received.
        /// </summary>
        public long clock;

        /// <summary>
        /// ID of the related item.
        /// </summary>
        public int itemid;

        public int num;

        public double value_min;

        public double value_avg;

        public double value_max;

    }
}
