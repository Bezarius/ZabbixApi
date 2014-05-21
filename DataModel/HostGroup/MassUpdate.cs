namespace ZabbixApi.DataModel.HostGroup
{
    public class MassUpdate
    {
        /// <summary>
        /// Host groups to be updated. The host groups must have the groupid property defined.
        /// </summary>
        /// <param name="groups"></param>
        public MassUpdate(HostGroup[] groups)
        {
            this.groups = groups;
        }

        /// <summary>
        ///  Host groups to be updated. The host groups must have the groupid property defined.
        /// </summary>
        public HostGroup[] groups;

        /// <summary>
        ///  Hosts to replace the current hosts on the given host groups. The hosts must have the hostid property defined.
        /// </summary>
        public Host.Host[] hosts;

        /// <summary>
        ///  Templates to replace the current templates on the given host groups. The templates must have the templateid property defined.
        /// </summary>
        public Template.Template[] templates;
    }
}