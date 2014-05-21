namespace ZabbixApi.DataModel.Maintenance
{
    public class Maintenance
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the maintenance.</param>
        public Maintenance(string name)
        {
            this.name = name;
        }

        /// <summary>
        ///  ID of the maintenance.
        /// </summary>
        public string maintenanceid;

        /// <summary>
        /// Name of the maintenance.
        /// </summary>
        public string name;

        /// <summary>
        /// Time when the maintenance becomes active.
        /// Default:
        /// current time.
        /// </summary>
        public long active_since;

        /// <summary>
        /// Time when the maintenance stops being active.
        /// Default:
        /// the next day.
        /// </summary>
        public long active_till;

        /// <summary>
        /// Description of the maintenance.
        /// </summary>
        public string description;

        /// <summary>
        ///
        ///Type of maintenance.
        /// Possible values:
        /// 0 - (default) with data collection;
        /// 1 - without data collection.
        /// </summary>
        public int maintenance_type;
    }
}
