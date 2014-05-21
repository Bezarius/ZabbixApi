namespace ZabbixApi.DataModel.Item
{
    public class Item
    {
        /// <summary>
        ///  ID of the item.
        /// </summary>
        public int itemid;

        /// <summary>
        /// Update interval of the item in seconds.
        /// </summary>
        public int delay;

        /// <summary>
        /// ID of the host that the item belongs to.
        /// </summary>
        public string hostid;

        /// <summary>
        /// ID of the item's host interface. Used only for host items. Optional for Zabbix agent (active), Zabbix internal, Zabbix trapper, Zabbix aggregate, database monitor and calculated items.
        /// </summary>
        public string interfaceid;

        /// <summary>
        /// Item key.
        /// </summary>
        public string key_;

        /// <summary>
        /// Name of the item.
        /// </summary>
        public string name;

        /// <summary>
        /// Type of the item.
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
        /// 9 - web item;
        /// 10 - external check;
        /// 11 - database monitor;
        /// 12 - IPMI agent;
        /// 13 - SSH agent;
        /// 14 - TELNET agent;
        /// 15 - calculated;
        /// 16 - JMX agent;
        /// 17 - SNMP trap.
        /// </summary>
        public int type;

        /// <summary>
        /// Type of information of the item.
        /// Possible values:
        /// 0 - numeric float;
        /// 1 - character;
        /// 2 - log;
        /// 3 - numeric unsigned;
        /// 4 - text.
        /// </summary>
        public int value_type;

        /// <summary>
        /// SSH authentication method. Used only by SSH agent items.
        /// Possible values:
        /// 0 - (default) password;
        /// 1 - public key.
        /// </summary>
        public int authtype;

        /// <summary>
        /// Data type of the item.
        /// Possible values:
        /// 0 - (default) decimal;
        /// 1 - octal;
        /// 2 - hexadecimal;
        /// 3 - boolean.
        /// </summary>
        public int data_type;

        /// <summary>
        /// Flexible intervals as a serialized string. Each serialized flexible interval consists of an update interval and a time period separated by a forward slash.
        /// Multiple intervals are separated by a colon.
        /// </summary>
        public string delay_flex;

        /// <summary>
        /// Value that will be stored.
        /// Possible values:
        /// 0 - (default) as is;
        /// 1 - Delta, speed per second;
        /// 2 - Delta, simple change.
        /// </summary>
        public int delta;

        /// <summary>
        /// Description of the item.
        /// </summary>
        public string description;

        /// <summary>
        ///  Error text if there are problems updating the item.
        /// </summary>
        public string error;

        /// <summary>
        ///  Origin of the item.
        /// Possible values:
        /// 0 - a plain item;
        /// 4 - a discovered item.
        /// </summary>
        public int flags;

        /// <summary>
        /// Custom multiplier.
        /// Default: 1.
        /// </summary>
        public double formula;

        /// <summary>
        /// Number of days to keep item's history data.
        /// Default: 90.
        /// </summary>
        public int history;

        /// <summary>
        /// ID of the host inventory field that is populated by the item. Refer to the host inventory page for a list of supported host inventory fields and their IDs.
        /// Default: 0.
        /// </summary>
        public int inventory_link;

        /// <summary>
        /// IPMI sensor. Used only by IPMI items.
        /// </summary>
        public string ipmi_sensor;

        /// <summary>
        ///  Time when the item was last updated.
        /// </summary>
        public long lastclock;

        /// <summary>
        ///  Nanoseconds when the item was last updated.
        /// </summary>
        public int lastns;

        /// <summary>
        ///  Last value of the item.
        /// </summary>
        public string lastvalue;

        /// <summary>
        /// Format of the time in log entries. Used only by log items.
        /// </summary>
        public string logtimefmt;

        /// <summary>
        /// Time when the monitored log file was last updated. Used only by log items.
        /// </summary>
        public long mtime;

        /// <summary>
        /// Whether to use a custom multiplier.
        /// </summary>
        public int multiplier;

        /// <summary>
        /// Additional parameters depending on the type of the item:
        /// - executed script for SSH and Telnet items;
        /// - SQL query for database monitor items;
        /// - formula for calculated items.
        /// </summary>
        public string @params;

        /// <summary>
        /// Password for authentication. Used by simple check, SSH, Telnet, database monitor and JMX items.
        /// </summary>
        public string password;

        /// <summary>
        /// Port monitored by the item. Used only by SNMP items.
        /// </summary>
        public string port;

        /// <summary>
        ///  Previous value of the item.
        /// </summary>
        public string prevvalue;

        /// <summary>
        /// Name of the private key file.
        /// </summary>
        public string privatekey;

        /// <summary>
        /// Name of the public key file.
        /// </summary>
        public string publickey;

        /// <summary>
        /// SNMP community. Used only by SNMPv1 and SNMPv2 items.
        /// </summary>
        public string snmp_community;

        /// <summary>
        /// SNMP OID.
        /// </summary>
        public string snmp_oid;

        /// <summary>
        /// SNMPv3 auth passphrase. Used only by SNMPv3 items.
        /// </summary>
        public string snmpv3_authpassphrase;

        /// <summary>
        /// SNMPv3 authentication protocol. Used only by SNMPv3 items.
        /// Possible values:
        /// 0 - (default) MD5;
        /// 1 - SHA.
        /// </summary>
        public int snmpv3_authprotocol;

        /// <summary>
        /// SNMPv3 context name. Used only by SNMPv3 items.
        /// </summary>
        public string snmpv3_contextname;

        /// <summary>
        /// SNMPv3 priv passphrase. Used only by SNMPv3 items.
        /// </summary>
        public string snmpv3_privpassphrase;

        /// <summary>
        /// SNMPv3 privacy protocol. Used only by SNMPv3 items.
        /// Possible values:
        /// 0 - (default) DES;
        /// 1 - AES.
        /// </summary>
        public int snmpv3_privprotocol;

        /// <summary>
        /// SNMPv3 security level. Used only by SNMPv3 items.
        /// Possible values:
        /// 0 - noAuthNoPriv;
        /// 1 - authNoPriv;
        /// 2 - authPriv.
        /// </summary>
        public int snmpv3_securitylevel;

        /// <summary>
        /// SNMPv3 security name. Used only by SNMPv3 items.
        /// </summary>
        public string snmpv3_securityname;

        /// <summary>
        ///  State of the item.
        /// Possible values:
        /// 0 - (default) normal;
        /// 1 - not supported.
        /// </summary>
        public  int state;

        /// <summary>
        /// 
        ///Status of the item.
        /// Possible values:
        /// 0 - (default) enabled item;
        /// 1 - disabled item.
        /// </summary>
        public int status;

        /// <summary>
        ///  ID of the parent template item.
        /// </summary>
        public string templateid;

        /// <summary>
        /// Allowed hosts. Used only by trapper items.
        /// </summary>
        public string trapper_hosts;

        /// <summary>
        /// Number of days to keep item's trends data.
        /// Default: 365.
        /// </summary>
        public int trends;

        /// <summary>
        /// Value units.
        /// </summary>
        public string units;

        /// <summary>
        /// Username for authentication. Used by simple check, SSH, Telnet, database monitor and JMX items. Required by SSH and Telnet items.
        /// </summary>
        public string username;

        /// <summary>
        /// ID of the associated value map.
        /// </summary>
        public string valuemapid;
    }
}