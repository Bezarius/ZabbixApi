namespace ZabbixApi.DataModel.Maintenance
{
    public class Create : Maintenance
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the maintenance.</param>
        /// <param name="groupids">IDs of the host groups that will undergo maintenance.</param>
        /// <param name="hostids">IDs of the hosts that will undergo maintenance.</param>
        /// <param name="timeperiods">Maintenance time periods.</param>
        public Create(string name, int[] groupids, int[] hostids, TimePeriod[] timeperiods)
            : base(name)
        {

            this.groupids = groupids;
            this.hostids = hostids;
            this.timeperiods = timeperiods;
        }

        /// <summary>
        /// IDs of the host groups that will undergo maintenance.
        /// </summary>
        public int[] groupids;

        /// <summary>
        /// IDs of the hosts that will undergo maintenance.
        /// </summary>
        public int[] hostids;

        /// <summary>
        /// Maintenance time periods.
        /// </summary>
        public TimePeriod[] timeperiods;
    }
}