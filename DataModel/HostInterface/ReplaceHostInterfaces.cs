namespace ZabbixApi.DataModel.HostInterface
{
    public class ReplaceHostInterfaces
    {
        /// <summary>
        /// </summary>
        /// <param name="hostid">ID of the host to be updated.</param>
        /// <param name="interfaces">Host interfaces to replace the current host interfaces with.</param>
        public ReplaceHostInterfaces(string hostid, HostInterface[] interfaces)
        {
            this.hostid = hostid;
            this.interfaces = interfaces;
        }

        /// <summary>
        /// ID of the host to be updated.
        /// </summary>
        public string hostid;

        /// <summary>
        /// Host interfaces to replace the current host interfaces with.
        /// </summary>
        public HostInterface[] interfaces;
    }
}