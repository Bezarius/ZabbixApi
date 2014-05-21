using ZabbixApi.Common;

namespace ZabbixApi.DataModel.Trends
{

    public enum TrendType
    {
        Float = 0,
        UInt =3
    }

    public class Get : CommonGet
    {
        /// <summary>
        /// History object types to return. 
        /// Possible values: 0 - float; 1 - uint
        /// </summary>
        public TrendType history;

        /// <summary>
        /// Return only history from the given hosts.
        /// </summary>
        public int[] hostids;

        /// <summary>
        /// Return only history from the given items.
        /// </summary>
        public int[] itemids;

        /// <summary>
        /// Return only values that have been received after or at the given time.
        /// </summary>
        public long? time_from;

        /// <summary>
        /// Return only values that have been received before or at the given time.
        /// </summary>
        public long? time_till;

        /// <summary>
        /// Sort the result by the given properties. Possible values are: itemid and clock.
        /// </summary>
        public string[] sortfield;
    }
}
