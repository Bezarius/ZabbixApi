using ZabbixApi.Common;

namespace ZabbixApi.DataModel.ITService
{
    public class SLA : Interval
    {
        /// <summary>
        /// SLA for the given time interval
        /// </summary>
        public float sla;

        /// <summary>
        /// Time the service was in OK state, in seconds
        /// </summary>
        public int okTime;

        /// <summary>
        /// Time the service was in problem state, in seconds
        /// </summary>
        public int ProblemTime;

        /// <summary>
        /// Time the service was in scheduled downtime, in seconds
        /// </summary>
        public int DowntimeTime;
    }
}