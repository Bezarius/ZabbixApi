namespace ZabbixApi.DataModel.HostInterface
{
    public class Create : HostInterface
    {
        /// <summary>
        /// </summary>
        /// <param name="dns">DNS name used by the interface. Can be empty if the connection is made via IP.</param>
        /// <param name="hostid">ID of the host the interface belongs to.</param>
        /// <param name="ip">IP address used by the interface. Can be empty if the connection is made via DNS.</param>
        /// <param name="main">Whether the interface is used as default on the host. Only one interface of some type can be set as default on a host. Possible values are: 0 - not default; 1 - default.</param>
        /// <param name="port">Port number used by the interface. Can contain user macros.</param>
        /// <param name="type">Interface type. Possible values are: 1 - agent; 2 - SNMP; 3 - IPMI; 4 - JMX.</param>
        /// <param name="useip">Whether the connection should be made via IP. Possible values are: 0 - connect using host DNS name; 1 - connect using host IP address.</param>
        public Create(string dns, int hostid, string ip, int main, string port, int type, int useip)
            : base(dns, hostid, ip, main, port, type, useip)
        {
        }
    }
}