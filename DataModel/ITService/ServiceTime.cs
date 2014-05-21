namespace ZabbixApi.DataModel.ITService
{
    public class ServiceTime
    {
        /// <summary>
        /// </summary>
        /// <param name="serviceid">ID of the IT service. Cannot be updated.</param>
        /// <param name="ts_from">Time when the service time comes into effect. For onetime downtimes ts_from must be set as a Unix timestamp, for other types - as a specific time in a week, in seconds, for example, 90000 for Tue, 2:00 AM.</param>
        /// <param name="ts_to">Time when the service time ends. For onetime uptimes ts_to must be set as a Unix timestamp, for other types - as a specific time in a week, in seconds, for example, 90000 for Tue, 2:00 AM.</param>
        /// <param name="type">Service time type. Possible values: 0 - planned uptime, repeated every week; 1 - planned downtime, repeated every week; 2 - one-time downtime.</param>
        public ServiceTime(string serviceid, long ts_from, long ts_to, int type)
        {
            this.serviceid = serviceid;
            this.ts_from = ts_from;
            this.ts_to = ts_to;
            this.type = type;
        }

        /// <summary>
        ///  ID of the service time.
        /// </summary>
        public string timeid;

        /// <summary>
        /// ID of the IT service. Cannot be updated.
        /// </summary>
        public string serviceid;

        /// <summary>
        /// Time when the service time comes into effect. For onetime downtimes ts_from must be set as a Unix timestamp, for other types - as a specific time in a week, in seconds, for example, 90000 for Tue, 2:00 AM.
        /// </summary>
        public long ts_from;

        /// <summary>
        /// Time when the service time ends. For onetime uptimes ts_to must be set as a Unix timestamp, for other types - as a specific time in a week, in seconds, for example, 90000 for Tue, 2:00 AM.
        /// </summary>
        public long ts_to;

        /// <summary>
        /// Service time type. Possible values: 0 - planned uptime, repeated every week; 1 - planned downtime, repeated every week; 2 - one-time downtime.
        /// </summary>
        public int type;

        /// <summary>
        /// Additional information about the service time.
        /// </summary>
        public string note;
    }
}