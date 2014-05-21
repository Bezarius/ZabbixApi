namespace ZabbixApi.DataModel.HostInterface
{
    public class MassAdd
    {
        /// <summary>
        /// </summary>
        /// <param name="hosts">Hosts to be updated. The hosts must have the hostid property defined.</param>
        /// <param name="interfaces">Host interfaces to create on the given hosts.</param>
        public MassAdd(Host.Host[] hosts, HostInterface[] interfaces)
        {
            this.hosts = hosts;
            this.interfaces = interfaces;
        }


        /// <summary>
        /// Hosts to be updated. The hosts must have the hostid property defined.
        /// </summary>
        public Host.Host[] hosts;

        /// <summary>
        /// Host interfaces to create on the given hosts.
        /// </summary>
        public HostInterface[] interfaces;
    }
}