namespace ZabbixApi.DataModel.HostGroup
{
    public class MassRemove
    {
        /// <summary>
        ///  (required)IDs of the host groups to be updated.
        /// </summary>
        public string[] groupids;

        /// <summary>
        ///  Hosts to remove from all host groups.
        /// </summary>
        public string[] hostids;

        /// <summary>
        ///  Templates to remove from all host groups.
        /// </summary>
        public string[] templateids;
    }
}