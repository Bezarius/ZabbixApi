using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZabbixApi.DataModel.LLD
{
    public class LLDRule
    {
        /// <summary>
        /// The low-level discovery rule object has the following properties.
        /// </summary>
        /// <param name="delay">Update interval of the LLD rule in seconds.</param>
        /// <param name="hostid">ID of the host that the LLD rule belongs to.</param>
        /// <param name="interfaceid">ID of the LLD rule's host interface. Used only for host LLD rules. Optional for Zabbix agent (active), Zabbix internal, Zabbix trapper and database monitor LLD rules.</param>
        /// <param name="key_">LLD rule key.</param>
        /// <param name="name">Name of the LLD rule.</param>
        /// <param name="type">Type of the LLD rule. Possible values: 0 - Zabbix agent; 1 - SNMPv1 agent; 2 - Zabbix trapper; 3 - simple check; 4 - SNMPv2 agent; 5 - Zabbix internal; 6 - SNMPv3 agent; 7 - Zabbix agent (active); 10 - external check; 11 - database monitor; 12 - IPMI agent; 13 - SSH agent; 14 - TELNET agent; 16 - JMX agent.</param>
        public LLDRule(int delay, string hostid, string interfaceid, string key_, string name, int type)
        {
            this.delay = delay;
            this.hostid = hostid;
            this.interfaceid = interfaceid;
            this.key_ = key_;
            this.name = name;
            this.type = type;
        }


        /// <summary>
        ///  ID of the LLD rule.
        /// </summary>
        public readonly string itemid;

        /// <summary>
        /// Update interval of the LLD rule in seconds.
        /// </summary>
        public int delay;

        /// <summary>
        /// ID of the host that the LLD rule belongs to.
        /// </summary>
        public string hostid;

        /// <summary>
        /// ID of the LLD rule's host interface. Used only for host LLD rules. Optional for Zabbix agent (active), Zabbix internal, Zabbix trapper and database monitor LLD rules.
        /// </summary>
        public string interfaceid;

        /// <summary>
        /// LLD rule key.
        /// </summary>
        public string key_;

        /// <summary>
        /// Name of the LLD rule.
        /// </summary>
        public string name;

        /// <summary>
        /// Type of the LLD rule. Possible values: 0 - Zabbix agent; 1 - SNMPv1 agent; 2 - Zabbix trapper; 3 - simple check; 4 - SNMPv2 agent; 5 - Zabbix internal; 6 - SNMPv3 agent; 7 - Zabbix agent (active); 10 - external check; 11 - database monitor; 12 - IPMI agent; 13 - SSH agent; 14 - TELNET agent; 16 - JMX agent.
        /// </summary>
        public int type;

        /// <summary>
        /// SSH authentication method. Used only by SSH agent LLD rules. Possible values: 0 - (default) password; 1 - public key.
        /// </summary>
        public int authtype;

        /// <summary>
        /// Flexible intervals as a serialized string. Each serialized flexible interval consists of an update interval and a time period separated by a forward slash. Multiple intervals are separated by a colon.
        /// </summary>
        public string delay_flex;

        /// <summary>
        /// Description of the LLD rule.
        /// </summary>
        public string description;

        /// <summary>
        ///  Error text if there are problems updating the LLD rule.
        /// </summary>
        public readonly string error;

        /// <summary>
        /// LLD rule filter containing the macro to filter by and the regexp to be used for filtering separated by a colon. For example {#IFNAME}:@Network interfaces for discovery.
        /// </summary>
        public string filter;

        /// <summary>
        /// IPMI sensor. Used only by IPMI LLD rules.
        /// </summary>
        public string ipmi_sensor;

        /// <summary>
        ///  Time when the LLD rule was last executed.
        /// </summary>
        public readonly long lastclock;

        /// <summary>
        ///  Nanoseconds when the LLD rule was last executed.
        /// </summary>
        public readonly int lastns;

        /// <summary>
        /// Time period after which items that are no longer discovered will be deleted, in days. Default: 30.
        /// </summary>
        public int lifetime;

        /// <summary>
        /// Additional parameters depending on the type of the LLD rule: - executed script for SSH and Telnet LLD rules; - SQL query for database monitor LLD rules; - formula for calculated LLD rules.
        /// </summary>
        public string @params;

        /// <summary>
        /// Password for authentication. Used by simple check, SSH, Telnet, database monitor and JMX LLD rules.
        /// </summary>
        public string password;

        /// <summary>
        /// Port used by the LLD rule. Used only by SNMP LLD rules.
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
        /// SNMP community. Required for SNMPv1 and SNMPv2 LLD rules.
        /// </summary>
        public string snmp_community;

        /// <summary>
        /// SNMP OID.
        /// </summary>
        public string snmp_oid;

        /// <summary>
        /// SNMPv3 auth passphrase. Used only by SNMPv3 LLD rules.
        /// </summary>
        public string snmpv3_authpassphrase;

        /// <summary>
        /// SNMPv3 authentication protocol. Used only by SNMPv3 LLD rules. Possible values: 0 - (default) MD5; 1 - SHA.
        /// </summary>
        public int snmpv3_authprotocol;

        /// <summary>
        /// SNMPv3 context name. Used only by SNMPv3 checks.
        /// </summary>
        public string snmpv3_contextname;

        /// <summary>
        /// SNMPv3 priv passphrase. Used only by SNMPv3 LLD rules.
        /// </summary>
        public string snmpv3_privpassphrase;

        /// <summary>
        /// SNMPv3 privacy protocol. Used only by SNMPv3 LLD rules. Possible values: 0 - (default) DES; 1 - AES.
        /// </summary>
        public int snmpv3_privprotocol;

        /// <summary>
        /// SNMPv3 security level. Used only by SNMPv3 LLD rules. Possible values: 0 - noAuthNoPriv; 1 - authNoPriv; 2 - authPriv.
        /// </summary>
        public int snmpv3_securitylevel;

        /// <summary>
        /// SNMPv3 security name. Used only by SNMPv3 LLD rules.
        /// </summary>
        public string snmpv3_securityname;

        /// <summary>
        ///  State of the LLD rule. Possible values: 0 - (default) normal; 1 - not supported.
        /// </summary>
        public readonly int state;

        /// <summary>
        /// Status of the LLD rule. Possible values: 0 - (default) enabled LLD rule; 1 - disabled LLD rule.
        /// </summary>
        public int status;

        /// <summary>
        ///  ID of the parent template LLD rule.
        /// </summary>
        public readonly string templateid;

        /// <summary>
        /// Allowed hosts. Used only by trapper LLD rules.
        /// </summary>
        public string trapper_hosts;

        /// <summary>
        /// Username for authentication. Used by simple check, SSH, Telnet, database monitor and JMX LLD rules. Required by SSH and Telnet LLD rules.
        /// </summary>
        public string username;
    }
}
