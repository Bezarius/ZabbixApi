namespace ZabbixApi.DataModel.LLDRule
{
    public class Create : LLDRule
    {

        /// <summary>
        /// </summary>
        /// <param name="delay">Update interval of the LLD rule in seconds.</param>
        /// <param name="hostid">ID of the host that the LLD rule belongs to.</param>
        /// <param name="interfaceid">ID of the LLD rule's host interface. Used only for host LLD rules. Optional for Zabbix agent (active), Zabbix internal, Zabbix trapper and database monitor LLD rules.</param>
        /// <param name="key_">LLD rule key.</param>
        /// <param name="name">Name of the LLD rule.</param>
        /// <param name="type">Type of the LLD rule. Possible values: 0 - Zabbix agent; 1 - SNMPv1 agent; 2 - Zabbix trapper; 3 - simple check; 4 - SNMPv2 agent; 5 - Zabbix internal; 6 - SNMPv3 agent; 7 - Zabbix agent (active); 10 - external check; 11 - database monitor; 12 - IPMI agent; 13 - SSH agent; 14 - TELNET agent; 16 - JMX agent.</param>
        public Create(int delay, string hostid, string interfaceid, string key_, string name, int type)
            : base(delay, hostid, interfaceid, key_, name, type)
        {
        }
    }
}