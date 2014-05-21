namespace ZabbixApi.DataModel.Host
{
    public class Update : Host
    {
        /// <summary>
        /// Technical name of the host.
        /// </summary>
        /// <param name="host"></param>
        public Update(string host)
            : base(host)
        {
        }

        /// <summary>
        ///  Host groups to replace the current host groups the host belongs to. The host groups must have the groupid property defined.
        /// </summary>
        public Host[] groups;

        /// <summary>
        ///  Host interfaces to replace the current host interfaces.
        /// </summary>
        public HostInterface.HostInterface[] interfaces;

        /// <summary>
        ///  Host inventory properties.
        /// </summary>
        public HostInventory inventory;

        /// <summary>
        ///  User macros to replace the current user macros.
        /// </summary>
        public UserMacro.HostMacro[] macros;

        /// <summary>
        ///  Templates to replace the currently linked templates. The templates must have the templateid property defined.
        /// </summary>
        public Template.Template[] templates;

        /// <summary>
        ///  Templates to unlink and clear from the host. The templates must have the templateid property defined.
        /// </summary>
        public Template.Template[] templates_clear;

        
    }
}