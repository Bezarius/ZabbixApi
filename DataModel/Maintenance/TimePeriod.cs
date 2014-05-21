namespace ZabbixApi.DataModel.Maintenance
{
    /// <summary>
    /// The time period object is used to define periods when the maintenance must come into effect. It has the following properties.
    /// </summary>
    public class TimePeriod
    {
        /// <summary>
        ///  ID of the maintenance.
        /// </summary>
        public string timeperiodid;

        /// <summary>
        /// Day of the month when the maintenance must come into effect. Required only for monthly time periods.
        /// </summary>
        public int day;

        /// <summary>
        /// Days of the week when the maintenance must come into effect. Days are stored in binary form with each bit representing the corresponding day. For example, 4 equals 100 in binary and means, that maintenance will be enabled on Wednesday. Used for weekly and monthly time periods. Required only for weekly time periods.
        /// </summary>
        public int dayofweek;

        /// <summary>
        /// For daily and weekly periods every defines day or week intervals at which the maintenance must come into effect. For monthly periods every defines the week of the month when the maintenance must come into effect.
        /// Possible values:
        /// 1 - first week;
        /// 2 - second week;
        /// 3 - third week;
        /// 4 - fourth week;
        /// 5 - last week.
        /// </summary>
        public int every;

        /// <summary>
        /// Months when the maintenance must come into effect. Months are stored in binary form with each bit representing the corresponding month. For example, 5 equals 101 in binary and means, that maintenance will be enabled in January and March. Required only for monthly time periods.
        /// </summary>
        public int month;

        /// <summary>
        /// Duration of the maintenance period in seconds.
        /// Default: 3600.
        /// </summary>
        public int period;

        /// <summary>
        /// Date when the maintenance period must come into effect. Required only for one time periods.
        /// Default: current date.
        /// </summary>
        public long start_date;

        /// <summary>
        /// Time of day when the maintenance starts in seconds. Required for daily, weekly and monthly periods.
        /// </summary>
        public int start_time;

        /// <summary>
        /// Type of time period.
        /// Possible values:
        /// 0 - (default) one time only;
        /// 2 - daily;
        /// 3 - weekly;
        /// 4 - monthly.
        /// </summary>
        public int timeperiod_type;
    }
}