namespace ZabbixApi.DataModel.Template
{
    public class Update
    {
        /// <summary>
        ///  Host groups to replace the current host groups the templates belong to. The host groups must have the groupid property defined.
        /// </summary>
        public HostGroup.HostGroup[] groups;

        /// <summary>
        ///  Hosts to replace the ones the templates are currently linked to. The hosts must have the hostids property defined.
        /// </summary>
        public Host.Host[] hosts;

        /// <summary>
        ///  User macros to replace the current user macros on the given templates.
        /// </summary>
        public UserMacro.HostMacro[] macros;

        /// <summary>
        ///  Templates to replace the currently linked templates. The templates must have the templateid property defined.
        /// </summary>
        public Template[] templates;

        /// <summary>
        ///  Templates to unlink and clear from the given templates. The templates must have the templateid property defined.
        /// </summary>
        public Template[] templates_clear;
    }
}