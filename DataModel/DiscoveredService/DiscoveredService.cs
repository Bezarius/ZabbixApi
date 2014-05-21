namespace ZabbixApi.DataModel.DiscoveredService
{
    public class DiscoveredService
    {
        /// <summary>
        /// ID of the discovered service.
        /// </summary>
        public string dserviceid;

        /// <summary>
        /// ID of the discovery check used to detect the service.
        /// </summary>
        public string dcheckid;

        /// <summary>
        /// ID of the discovered host running the service.
        /// </summary>
        public string dhostid;

        /// <summary>
        /// DNS of the host running the service.
        /// </summary>
        public string dns;

        /// <summary>
        /// IP address of the host running the service.
        /// </summary>
        public string ip;

        /// <summary>
        /// Key used by a Zabbix agent discovery check to locate the service.
        /// </summary>
        public string key_;

        /// <summary>
        /// Time when the discovered service last went down.
        /// </summary>
        public long lastdown;

        /// <summary>
        /// Time when the discovered service last went up.
        /// </summary>
        public long lastup;

        /// <summary>
        /// Service port number.
        /// </summary>
        public int port;

        /// <summary>
        /// Status of the service.
        /// Possible values:
        /// 0 - service up;
        /// 1 - service down.
        /// </summary>
        public int status;

        /// <summary>
        /// Type of discovered service. The type of service matches the type of the discovery check used to detect the service. Refer to the discovery check "type" property for a list of supported types.
        /// </summary>
        public int type;

        /// <summary>
        /// Value returned by the service when performing a Zabbix agent, SNMPv1, SNMPv2 or SNMPv3 discovery check.
        /// </summary>
        public string value;
    }
}
