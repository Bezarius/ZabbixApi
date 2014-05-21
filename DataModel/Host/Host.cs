namespace ZabbixApi.DataModel.Host
{
    public class Host
    {
        /// <summary>
        /// </summary>
        /// <param name="host">Technical name of the host.</param>
        public Host(string host)
        {
            this.host = host;
            this.ipmi_authtype = -1;
        }


        /// <summary>
        ///  ID of the host.
        /// </summary>
        public int hostid;

        /// <summary>
        /// Technical name of the host.
        /// </summary>
        public string host;

        /// <summary>
        ///  Availability of Zabbix agent. Possible values are: 0 - (default) unknown; 1 - available; 2 - unavailable.
        /// </summary>
        public int available;

        /// <summary>
        ///  The next polling time of an unavailable Zabbix agent.
        /// </summary>
        public string disable_until;

        /// <summary>
        ///  Error text if Zabbix agent is unavailable.
        /// </summary>
        public string error;

        /// <summary>
        ///  Time when Zabbix agent became unavailable.
        /// </summary>
        public string errors_from;

        /// <summary>
        ///  Origin of the host. Possible values: 0 - a plain host; 4 - a discovered host.
        /// </summary>
        public int flags;

        /// <summary>
        /// IPMI authentication algorithm. Possible values are: -1 - (default) default; 0 - none; 1 - MD2; 4 - straight; 5 - OEM; 6 - RMCP+.
        /// </summary>
        public int ipmi_authtype;

        /// <summary>
        ///  Availability of IPMI agent. Possible values are: 0 - (default) unknown; 1 - available; 2 - unavailable.
        /// </summary>
        public int ipmi_available;

        /// <summary>
        ///  The next polling time of an unavailable IPMI agent.
        /// </summary>
        public string ipmi_disable_until;

        /// <summary>
        ///  Error text if IPMI agent is unavailable.
        /// </summary>
        public string ipmi_error;

        /// <summary>
        ///  Time when IPMI agent became unavailable.
        /// </summary>
        public string ipmi_errors_from;

        /// <summary>
        /// IPMI password.
        /// </summary>
        public string ipmi_password;

        /// <summary>
        /// IPMI privilege level. Possible values are: 1 - callback; 2 - (default) user; 3 - operator; 4 - admin; 5 - OEM.
        /// </summary>
        public int ipmi_privilege;

        /// <summary>
        /// IPMI username.
        /// </summary>
        public string ipmi_username;

        /// <summary>
        ///  Availability of JMX agent. Possible values are: 0 - (default) unknown; 1 - available; 2 - unavailable.
        /// </summary>
        public int jmx_available;

        /// <summary>
        ///  The next polling time of an unavailable JMX agent.
        /// </summary>
        public string jmx_disable_until;

        /// <summary>
        ///  Error text if JMX agent is unavailable.
        /// </summary>
        public string jmx_error;

        /// <summary>
        ///  Time when JMX agent became unavailable.
        /// </summary>
        public string jmx_errors_from;

        /// <summary>
        ///  Starting time of the effective maintenance.
        /// </summary>
        public string maintenance_from;

        /// <summary>
        ///  Effective maintenance status. Possible values are: 0 - (default) no maintenance; 1 - maintenance in effect.
        /// </summary>
        public int maintenance_status;

        /// <summary>
        ///  Effective maintenance type. Possible values are: 0 - (default) maintenance with data collection; 1 - maintenance without data collection.
        /// </summary>
        public int maintenance_type;

        /// <summary>
        ///  ID of the maintenance that is currently in effect on the host.
        /// </summary>
        public string maintenanceid;

        /// <summary>
        /// Visible name of the host. Default: host property value.
        /// </summary>
        public string name;

        /// <summary>
        /// ID of the proxy that is used to monitor the host.
        /// </summary>
        public string proxy_hostid;

        /// <summary>
        ///  Availability of SNMP agent. Possible values are: 0 - (default) unknown; 1 - available; 2 - unavailable.
        /// </summary>
        public int snmp_available;

        /// <summary>
        ///  The next polling time of an unavailable SNMP agent.
        /// </summary>
        public string snmp_disable_until;

        /// <summary>
        ///  Error text if SNMP agent is unavailable.
        /// </summary>
        public string snmp_error;

        /// <summary>
        ///  Time when SNMP agent became unavailable.
        /// </summary>
        public string snmp_errors_from;

        /// <summary>
        /// Status and function of the host. Possible values are: 0 - (default) monitored host; 1 - unmonitored host.
        /// </summary>
        public int status;
    }
}