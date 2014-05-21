namespace ZabbixApi.DataModel.Host
{
    public class MassRemove
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hostids">IDs of the hosts to be updated.</param>
        public MassRemove(string[] hostids)
        {
            this.hostids = hostids;
        }
        /// <summary>
        ///  IDs of the hosts to be updated.
        /// </summary>
        public string[] hostids;

        /// <summary>
        ///  Host groups to remove the given hosts from.
        /// </summary>
        public string[] groupids;

        /// <summary>
        ///  Host interfaces to remove from the given hosts. The host interface object must have the ip, dns and port properties defined.
        /// </summary>
        public HostInterface.HostInterface[] interfaces;

        /// <summary>
        ///  User macros to delete from the given hosts.
        /// </summary>
        public string[] macros;

        /// <summary>
        ///  Templates to unlink from the given hosts.
        /// </summary>
        public string[] templateids;

        /// <summary>
        ///  Templates to unlink and clear from the given hosts.
        /// </summary>
        public string[] templateids_clear;
    }
}