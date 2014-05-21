namespace ZabbixApi.DataModel.DiscoveryCheck
{
    public class DiscoveryCheck
    {
        /// <summary>
        ///  ID of the discovery check.
        /// </summary>
        public string dcheckid;

        /// <summary>
        /// ID of the discovery rule that the check belongs to.
        /// </summary>
        public string druleid;

        /// <summary>
        /// The value of this property differs depending on the type type of the check:
        /// - key to query for Zabbix agent checks, required;
        /// - SNMP OID for SNMPv1, SNMPv2 and SNMPv3 checks, required.
        /// </summary>
        public string key_;

        /// <summary>
        /// One or several port ranges to check separated by commas. Used for all checks except for ICMP.
        /// Default: 0.
        /// </summary>
        public string ports;

        /// <summary>
        /// SNMP community. Required for SNMPv1 and SNMPv2 agent checks.
        /// </summary>
        public string snmp_community;

        /// <summary>
        /// Auth passphrase used for SNMPv3 agent checks with security level set to authNoPriv or authPriv.
        /// </summary>
        public string snmpv3_authpassphrase;

        /// <summary>
        /// Authentication protocol used for SNMPv3 agent checks with security level set to authNoPriv or authPriv.
        /// Possible values:
        /// 0 - (default) MD5;
        /// 1 - SHA.
        /// </summary>
        public int snmpv3_authprotocol;

        /// <summary>
        /// SNMPv3 context name. Used only by SNMPv3 checks.
        /// </summary>
        public string snmpv3_contextname;

        /// <summary>
        /// Priv passphrase used for SNMPv3 agent checks with security level set to authPriv.
        /// </summary>
        public string snmpv3_privpassphrase;

        /// <summary>
        /// Privacy protocol used for SNMPv3 agent checks with security level set to authPriv.
        /// Possible values:
        /// 0 - (default) DES;
        /// 1 - AES.
        /// </summary>
        public int snmpv3_privprotocol;

        /// <summary>
        ///Security level used for SNMPv3 agent checks.
        /// Possible values:
        /// 0 - noAuthNoPriv;
        /// 1 - authNoPriv;
        /// 2 - authPriv.
        /// </summary>
        public string snmpv3_securitylevel;

        /// <summary>
        /// Security name used for SNMPv3 agent checks.
        /// </summary>
        public string snmpv3_securityname;

        /// <summary>
        /// Type of check.
        /// Possible values:
        /// 0 - (default) SSH;
        /// 1 - LDAP;
        /// 2 - SMTP;
        /// 3 - FTP;
        /// 4 - HTTP;
        /// 5 - POP;
        /// 6 - NNTP;
        /// 7 - IMAP;
        /// 8 - TCP;
        /// 9 - Zabbix agent;
        /// 10 - SNMPv1 agent;
        /// 11 - SNMPv2 agent;
        /// 12 - ICMP ping;
        /// 13 - SNMPv3 agent;
        /// 14 - HTTPS;
        /// 15 - Telnet.
        /// </summary>
        public int type;

        /// <summary>
        /// Whether to use this check as a device uniqueness criteria. Only a single unique check can be configured for a discovery rule. Used for Zabbix agent, SNMPv1, SNMPv2 and SNMPv3 agent checks.
        /// Possible values:
        /// 0 - (default) do not use this check as a uniqueness criteria;
        /// 1 - use this check as a uniqueness criteria.
        /// </summary>
        public int uniq;
    }
}
