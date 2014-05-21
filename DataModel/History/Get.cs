using ZabbixApi.Common;

namespace ZabbixApi.DataModel.History
{
    public class Get : CommonGet
    {

        public Get()
        {
            this.history = 3;
        }

        /// <summary>
        /// History object types to return. 
        /// Possible values: 0 - float; 1 - string; 2 - log; 3 - integer; 4 - text.
        /// Default: 3.
        /// </summary>
        public int history;

        /// <summary>
        /// Return only history from the given hosts.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Return only history from the given items.
        /// </summary>
        public string[] itemids;

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