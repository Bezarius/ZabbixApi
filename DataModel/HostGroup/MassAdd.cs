namespace ZabbixApi.DataModel.HostGroup
{
    public class MassAdd
    {
        /// <summary>
        /// Host groups to be updated. The host groups must have the groupid property defined.
        /// </summary>
        /// <param name="groups"></param>
        public MassAdd(HostGroup[] groups)
        {
            this.groups = groups;
        }
        /// <summary>
        /// Host groups to be updated. The host groups must have the groupid property defined.
        /// </summary>
        public HostGroup[] groups;

        /// <summary>
        ///  Hosts to add to all host groups. The hosts must have the hostid property defined.
        /// </summary>
        public object[] hosts;

        /// <summary>
        ///  Templates to add to all host groups. The templates must have the templateid property defined.
        /// </summary>
        public object[] templates;
    }
}