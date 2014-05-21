namespace ZabbixApi.DataModel.ItemPrototype
{
    public class Update : ItemPrototype
    {
        /// <summary>
        /// </summary>
        /// <param name="delay">Update interval of the item prototype in seconds.</param>
        /// <param name="hostid">ID of the host that the item prototype belongs to.</param>
        /// <param name="interfaceid">ID of the item prototype's host interface. Used only for host item prototypes. Optional for Zabbix agent (active), Zabbix internal, Zabbix trapper, Zabbix aggregate, database monitor and calculated item prototypes.</param>
        /// <param name="key_">Item prototype key.</param>
        /// <param name="name">Name of the item prototype.</param>
        /// <param name="type">
        /// Type of the item prototype.
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
        public Update(int delay, string hostid, string interfaceid, string key_, string name, int type, int value_type)
            : base(delay, hostid, interfaceid, key_, name, type, value_type)
        {
            
        }

        /// <summary>
        /// IDs of applications to be assigned to the discovered items.
        /// </summary>
        public Application.Application[] applications;
    }
}