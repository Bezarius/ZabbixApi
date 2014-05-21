namespace ZabbixApi.DataModel.Action
{
    /// <summary>
    /// https://www.zabbix.com/documentation/2.4/manual/api/reference/action/object
    /// </summary>
    public class Action
    {
        /// <summary>
        /// </summary>
        /// <param name="esc_period">Default operation step duration. Must be greater than 60 seconds.</param>
        /// <param name="evaltype">Action condition evaluation method. Possible values: 0 - AND / OR; 1 - AND; 2 - OR.</param>
        /// <param name="eventsource">(constant) Type of events that the action will handle. Refer to the event "source" property for a list of supported event types.</param>
        /// <param name="name">Name of the action.</param>
        public Action(int esc_period, int evaltype, int eventsource, string name)
        {
            this.esc_period = esc_period;
            this.evaltype = evaltype;
            this.eventsource = eventsource;
            this.name = name;
        }

        /// <summary>
        ///  ID of the action.
        /// </summary>
        public string actionid;

        /// <summary>
        /// Default operation step duration. Must be greater than 60 seconds.
        /// </summary>
        public int? esc_period;

        /// <summary>
        /// Action condition evaluation method. Possible values: 0 - AND / OR; 1 - AND; 2 - OR.
        /// </summary>
        public int? evaltype;

        /// <summary>
        /// (constant) Type of events that the action will handle. Refer to the event "source" property for a list of supported event types.
        /// </summary>
        public int? eventsource;

        /// <summary>
        /// Name of the action.
        /// </summary>
        public string name;

        /// <summary>
        /// Problem message text.
        /// </summary>
        public string def_longdata;

        /// <summary>
        /// Problem message subject.
        /// </summary>
        public string def_shortdata;

        /// <summary>
        /// Recovery message text.
        /// </summary>
        public string r_longdata;

        /// <summary>
        /// Recovery message subject.
        /// </summary>
        public string r_shortdata;

        /// <summary>
        /// Whether recovery messages are enabled. Possible values: 0 - (default) disabled; 1 - enabled.
        /// </summary>
        public int? recovery_msg;

        /// <summary>
        /// Whether the action is enabled or disabled. Possible values: 0 - (default) enabled; 1 - disabled.
        /// </summary>
        public int? status;
    }
}
