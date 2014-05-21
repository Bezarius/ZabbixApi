namespace ZabbixApi.DataModel.Template
{
    public class MassAdd
    {
        /// <summary>
        ///  ID of the node the templates must belong to
        /// </summary>
        public Template[] templates;

        /// <summary>
        ///  Host groups to add the given templates to. The host groups must have the groupid property defined.
        /// </summary>
        public HostGroup.HostGroup[] groups;

        /// <summary>
        ///  Hosts to link the given templates to. The hosts must have the templateid property defined.
        /// </summary>
        public Host.Host[] hosts;

        /// <summary>
        ///  User macros to be created for the given templates.
        /// </summary>
        public UserMacro.HostMacro[] macros;

        /// <summary>
        ///  Templates to link to the given templates. The templates must have the templateid property defined.
        /// </summary>
        public Template[] templates_link;
    }
}