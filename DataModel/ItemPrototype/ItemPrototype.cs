namespace ZabbixApi.DataModel.ItemPrototype
{
    public class ItemPrototype
    {
        /// <summary>
        /// </summary>
        /// <param name="delay">Update interval of the item prototype in seconds.</param>
        /// <param name="hostid">ID of the host that the item prototype belongs to.</param>
        /// <param name="interfaceid">ID of the item prototype's host interface. Used only for host item prototypes. Optional for Zabbix agent (active), Zabbix internal, Zabbix trapper, Zabbix aggregate, database monitor and calculated item prototypes.</param>
        /// <param name="key_">Item prototype key.</param>
        /// <param name="name">Name of the item prototype.</param>
        /// <param name="type">
        ///Type of the item prototype.
        /// Possible values:
        /// 0 - Zabbix agent;
        /// 1 - SNMPv1 agent;
        /// 2 - Zabbix trapper;
        /// 3 - simple check;
        /// 4 - SNMPv2 agent;
        /// 5 - Zabbix internal;
        /// 6 - SNMPv3 agent;
        /// 7 - Zabbix agent (active);
        /// 8 - Zabbix aggregate;
        /// 10 - external check;
        /// 11 - database monitor;
        /// 12 - IPMI agent;
        /// 13 - SSH agent;
        /// 14 - TELNET agent;
        /// 15 - calculated;
        /// 16 - JMX agent.</param>
        /// <param name="value_type">
        ///Type of information of the item prototype.
        /// Possible values:
        /// 0 - numeric float;
        /// 1 - character;
        /// 2 - log;
        /// 3 - numeric unsigned;
        /// 4 - text.</param>
        public ItemPrototype(int delay, string hostid, string interfaceid, string key_, string name, int type, int value_type)
        {
            this.delay = delay;
            this.hostid = hostid;
            this.interfaceid = interfaceid;
            this.key_ = key_;
            this.name = name;
            this.type = type;
            this.value_type = value_type;
        }


        /// <summary>
        ///  ID of the item prototype.
        /// </summary>
        public string itemid;

        /// <summary>
        /// Update interval of the item prototype in seconds.
        /// </summary>
        public int delay;

        /// <summary>
        /// ID of the host that the item prototype belongs to.
        /// </summary>
        public string hostid;

        /// <summary>
        /// ID of the item prototype's host interface. Used only for host item prototypes. Optional for Zabbix agent (active), Zabbix internal, Zabbix trapper, Zabbix aggregate, database monitor and calculated item prototypes.
        /// </summary>
        public string interfaceid;

        /// <summary>
        /// Item prototype key.
        /// </summary>
        public string key_;

        /// <summary>
        /// Name of the item prototype.
        /// </summary>
        public string name;

        /// <summary>
        /// 
        ///Type of the item prototype.
        /// Possible values:
        /// 0 - Zabbix agent;
        /// 1 - SNMPv1 agent;
        /// 2 - Zabbix trapper;
        /// 3 - simple check;
        /// 4 - SNMPv2 agent;
        /// 5 - Zabbix internal;
        /// 6 - SNMPv3 agent;
        /// 7 - Zabbix agent (active);
        /// 8 - Zabbix aggregate;
        /// 10 - external check;
        /// 11 - database monitor;
        /// 12 - IPMI agent;
        /// 13 - SSH agent;
        /// 14 - TELNET agent;
        /// 15 - calculated;
        /// 16 - JMX agent.
        /// </summary>
        public int type;

        /// <summary>
        /// 
        ///Type of information of the item prototype.
        /// Possible values:
        /// 0 - numeric float;
        /// 1 - character;
        /// 2 - log;
        /// 3 - numeric unsigned;
        /// 4 - text.
        /// </summary>
        public int value_type;

        /// <summary>
        /// 
        ///SSH authentication method. Used only by SSH agent item prototypes.
        /// Possible values:
        /// 0 - (default) password;
        /// 1 - public key.
        /// </summary>
        public int authtype;

        /// <summary>
        /// 
        ///Data type of the item prototype.
        /// Possible values:
        /// 0 - (default) decimal;
        /// 1 - octal;
        /// 2 - hexadecimal;
        /// 3 - boolean.
        /// </summary>
        public int data_type;

        /// <summary>
        /// Flexible intervals as a serialized string. Each serialized flexible interval consists of an update interval and a time period separated by a forward slash. Multiple intervals are separated by a colon.
        /// </summary>
        public string delay_flex;

        /// <summary>
        /// 
        ///Value that will be stored.
        /// Possible values:
        /// 0 - (default) as is;
        /// 1 - Delta, speed per second;
        /// 2 - Delta, simple change.
        /// </summary>
        public int delta;

        /// <summary>
        /// Description of the item prototype.
        /// </summary>
        public string description;

        /// <summary>
        /// 
        ///Custom multiplier.
        /// Default:
        /// 1.
        /// </summary>
        public double formula;

        /// <summary>
        /// 
        ///Number of days to keep item prototype's history data.
        /// Default:
        /// 90.
        /// </summary>
        public int history;

        /// <summary>
        /// IPMI sensor. Used only by IPMI item prototypes.
        /// </summary>
        public string ipmi_sensor;

        /// <summary>
        /// Format of the time in log entries. Used only by log item prototypes.
        /// </summary>
        public string logtimefmt;

        /// <summary>
        /// Whether to use a custom multiplier.
        /// </summary>
        public int multiplier;

        /// <summary>
        /// 
        ///Additional parameters depending on the type of the item prototype:
        /// - executed script for SSH and telnet item prototypes;
        /// - additional parameters for database monitor item prototypes;
        /// - formula for calculated item prototypes.
        /// </summary>
        public string @params;

        /// <summary>
        /// Password for authentication. Used only by SSH, telnet and JMX item prototypes.
        /// </summary>
        public string password;

        /// <summary>
        /// Port monitored by the item prototype. Used only by SNMP items prototype.
        /// </summary>
        public string port;

        /// <summary>
        /// Name of the private key file.
        /// </summary>
        public string privatekey;

        /// <summary>
        /// Name of the public key file.
        /// </summary>
        public string publickey;

        /// <summary>
        /// SNMP community.
        /// </summary>
        public string snmp_community;

        /// <summary>
        /// SNMP OID.
        /// </summary>
        public string snmp_oid;

        /// <summary>
        /// SNMPv3 auth passphrase. Used only by SNMPv3 item prototypes.
        /// </summary>
        public string snmpv3_authpassphrase;

        /// <summary>
        /// SNMPv3 priv passphrase. Used only by SNMPv3 item prototypes.
        /// </summary>
        public string snmpv3_privpassphrase;

        /// <summary>
        /// 
        ///SNMPv3 security level. Used only by SNMPv3 item prototypes.
        /// Possible values:
        /// 0 - noAuthNoPriv;
        /// 1 - authNoPriv;
        /// 2 - authPriv.
        /// </summary>
        public int snmpv3_securitylevel;

        /// <summary>
        /// SNMPv3 security name. Used only by SNMPv3 item prototypes.
        /// </summary>
        public string snmpv3_securityname;

        /// <summary>
        /// 
        ///Status of the item prototype.
        /// Possible values:
        /// 0 - (default) enabled item prototype;
        /// 1 - disabled item prototype;
        /// 3 - unsupported item prototype.
        /// </summary>
        public int status;

        /// <summary>
        ///  ID of the parent template item prototype.
        /// </summary>
        public string templateid;

        /// <summary>
        /// Allowed hosts. Used only by trapper item prototypes.
        /// </summary>
        public string trapper_hosts;

        /// <summary>
        /// 
        ///Number of days to keep item prototype's trends data.
        /// Default:
        /// 365.
        /// </summary>
        public int trends;

        /// <summary>
        /// Value units.
        /// </summary>
        public string units;

        /// <summary>
        /// Username for authentication. Used by simple check, SSH, Telnet, database monitor and JMX item prototypes. Required by SSH and Telnet item prototypes.
        /// </summary>
        public string username;

        /// <summary>
        /// ID of the associated value map.
        /// </summary>
        public string valuemapid;
    }
}
