namespace ZabbixApi.DataModel.ITService
{
    public class  ITServiceInfo
    {
        /// <summary>
        /// Current status of the IT service. Refer to the IT service object page for more information on service statuses.
        /// </summary>
        public int status;

        /// <summary>
        /// Triggers that are currently in problem state and are linked either to the IT service or one of its descendants.
        /// </summary>
        public string[] problems;

        /// <summary>
        /// SLA data about each time period.
        /// </summary>
        public SLA[] sla;
    }
}