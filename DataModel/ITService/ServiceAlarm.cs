namespace ZabbixApi.DataModel.ITService
{
    public class ServiceAlarm
    {
        /// <summary>
        /// ID of the service alarm.
        /// </summary>
        public string servicealarmid;

        /// <summary>
        /// ID of the IT service.
        /// </summary>
        public string serviceid;

        /// <summary>
        /// Time when the IT service state change has happened.
        /// </summary>
        public long clock;

        /// <summary>
        /// Status of the IT service. Refer the the IT service status property for a list of possible values.
        /// </summary>
        public int value;
    }
}