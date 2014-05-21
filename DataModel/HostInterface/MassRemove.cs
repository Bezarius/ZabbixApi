namespace ZabbixApi.DataModel.HostInterface
{
    public class MassRemove
    {
        /// <summary>
        /// </summary>
        /// <param name="hostids">IDs of the hosts to be updated.</param>
        /// <param name="interfaces">Host interfaces to remove from the given hosts.</param>
        public MassRemove(string[] hostids, HostInterface[] interfaces)
        {
            this.hostids = hostids;
            this.interfaces = interfaces;
        }

        /// <summary>
        /// IDs of the hosts to be updated.
        /// </summary>
        public string[] hostids;

        /// <summary>
        /// Host interfaces to remove from the given hosts.
        /// </summary>
        public HostInterface[] interfaces;
    }
}