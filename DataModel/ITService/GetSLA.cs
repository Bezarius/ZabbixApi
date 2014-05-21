using ZabbixApi.Common;

namespace ZabbixApi.DataModel.ITService
{
    public class GetSLA
    {
        /// <summary>
        /// IDs of IT services to return availability information for.
        /// </summary>
        public string[] serviceids;

        /// <summary>
        /// Time intervals to return service layer availability information about..
        /// </summary>
        public Interval[] intervals;
    }
}