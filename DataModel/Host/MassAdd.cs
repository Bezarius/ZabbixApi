namespace ZabbixApi.DataModel.Host
{
    public class MassAdd
    {
        /// <summary>
        /// </summary>
        /// <param name="hosts">Hosts to be updated. The hosts must have the hostid property defined.</param>
        public MassAdd(Host[] hosts)
        {
            this.hosts = hosts;
        }

        /// <summary>
        ///  Hosts to be updated. The hosts must have the hostid property defined.
        /// </summary>
        public Host[] hosts;

        /// <summary>
        ///  Host groups to add to the given hosts. The host groups must have the groupid property defined.
        /// </summary>
        public HostGroup.HostGroup[] groups;

        /// <summary>
        ///  Host interfaces to be created for the given hosts.
        /// </summary>
        public HostInterface.HostInterface[] interfaces;

        /// <summary>
        ///  User macros to be created for the given hosts.
        /// </summary>
        public UserMacro.HostMacro[] macros;

        /// <summary>
        ///  Templates to link to the given hosts. The templates must have the templateid property defined
        /// </summary>
        public Template.Template[] templates;
    }
}