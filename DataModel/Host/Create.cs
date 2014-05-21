namespace ZabbixApi.DataModel.Host
{
    public class Create : Host
    {
        /// <summary>
        /// </summary>
        /// <param name="host">Technical name of the host.</param>
        /// <param name="groups">Host groups to add the host to. The host groups must have the groupid property defined.</param>
        /// <param name="interfaces">Interfaces to be created for the host.</param>
        public Create(string host, HostGroup.HostGroup[] groups, HostInterface.HostInterface[] interfaces)
            : base(host)
        {
            this.groups = groups;
            this.interfaces = interfaces;
        }


        /// <summary>
        /// Host groups to add the host to. The host groups must have the groupid property defined.
        /// </summary>
        public HostGroup.HostGroup[] groups;

        /// <summary>
        /// Interfaces to be created for the host.
        /// </summary>
        public HostInterface.HostInterface[] interfaces;

        /// <summary>
        /// Templates to be linked to the host. The templates must have the templateid property defined.
        /// </summary>
        public Template.Template[] templates;

        /// <summary>
        /// User macros to be created for the host.
        /// </summary>
        public UserMacro.HostMacro[] macros;

        /// <summary>
        /// Host inventory properties.
        /// </summary>
        public HostInventory inventory;
    }
}