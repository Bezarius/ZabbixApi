namespace ZabbixApi.DataModel.Host
{
    public class MassUpdate : Host
    {
        /// <summary>
        /// </summary>
        /// <param name="host">Technical name of the host.</param>
        public MassUpdate(string host)
            : base(host)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="hosts">Hosts to be updated. The hosts must have the hostid property defined.</param>
        public MassUpdate(Host[] hosts)
            : base(null)
        {
            this.hosts = hosts;
        }

        /// <summary>
        ///  Hosts to be updated. The hosts must have the hostid property defined.
        /// </summary>
        public Host[] hosts;

        /// <summary>
        ///  Host groups to replace the current host groups the hosts belong to. The host groups must have the groupid property defined.
        /// </summary>
        public HostGroup.HostGroup[] groups;

        /// <summary>
        ///  Host interfaces to replace the current host interfaces on the given hosts.
        /// </summary>
        public HostInterface.HostInterface[] interfaces;

        /// <summary>
        ///  Host inventory properties. Host inventory mode cannot be updated using the inventory parameter, use inventory_mode instead.
        /// </summary>
        public HostInventory inventory;

        /// <summary>
        ///  Host inventory population mode. Refer to the host inventory object page for a list of supported inventory modes.
        /// </summary>
        public int inventory_mode;

        /// <summary>
        ///  User macros to replace the current user macros on the given hosts.
        /// </summary>
        public UserMacro.HostMacro[] macros;

        /// <summary>
        ///  Templates to replace the currently linked templates on the given hosts. The templates must have the templateid property defined.
        /// </summary>
        public Template.Template[] templates;

        /// <summary>
        ///  Templates to unlink and clear from the given hosts. The templates must have the templateid property defined.
        /// </summary>
        public Template.Template[] templates_clear;
    }
}