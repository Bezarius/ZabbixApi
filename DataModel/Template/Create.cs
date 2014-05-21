namespace ZabbixApi.DataModel.Template
{
    public class Create : Template
    {

        /// <param name="host">Technical name of the template.</param>
        public Create(string host)
            : base(host)
        {
        }

        /// <summary>
        /// Host groups to add the template to. The host groups must have the groupid property defined.
        /// </summary>
        public HostGroup.HostGroup[] groups;

        /// <summary>
        ///  Templates to be linked to the template. The templates must have the templateid property defined.
        /// </summary>
        public Template[] templates;

        /// <summary>
        ///  User macros to be created for the template.
        /// </summary>
        public UserMacro.HostMacro[] macros;

        /// <summary>
        ///  Hosts to link the template to.
        /// </summary>
        public Host.Host[] hosts;
    }
}