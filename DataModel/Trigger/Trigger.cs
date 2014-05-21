namespace ZabbixApi.DataModel.Trigger
{
    public class Trigger
    {
        /// <summary>
        ///  ID of the trigger.
        /// </summary>
        public int triggerid;

        /// <summary>
        /// Name of the trigger.
        /// </summary>
        public string description;

        /// <summary>
        /// Reduced trigger expression.
        /// </summary>
        public string expression;

        /// <summary>
        /// Additional comments to the trigger.
        /// </summary>
        public string comments;

        /// <summary>
        ///  Error text if there have been any problems when updating the state of the trigger.
        /// </summary>
        public string error;

        /// <summary>
        /// Origin of the trigger.
        /// Possible values are:
        /// 0 - (default) a plain trigger;
        /// 4 - a discovered trigger.
        /// </summary>
        public int? flags;

        /// <summary>
        ///  Time when the trigger last changed its state.
        /// </summary>
        public string lastchange;

        /// <summary>
        /// Severity of the trigger.
        /// Possible values are:
        /// 0 - (default) not classified;
        /// 1 - information;
        /// 2 - warning;
        /// 3 - average;
        /// 4 - high;
        /// 5 - disaster.
        /// </summary>
        public int? priority;

        /// <summary>
        /// State of the trigger. 
        /// Possible values: 
        /// 0 - (default) trigger state is up to date;
        /// 1 - current trigger state is unknown.
        /// </summary>
        public int? state;

        /// <summary>
        /// Whether the trigger is enabled or disabled.
        /// Possible values are:
        /// 0 - (default) enabled;
        /// 1 - disabled.
        /// </summary>
        public int? status;

        /// <summary>
        ///  ID of the parent template trigger.
        /// </summary>
        public int? templateid;

        /// <summary>
        /// Whether the trigger can generate multiple problem events.
        /// Possible values are:
        /// 0 - (default) do not generate multiple events;
        /// 1 - generate multiple events.
        /// </summary>
        public int? type;

        /// <summary>
        /// URL associated with the trigger.
        /// </summary>
        public string url;

        /// <summary>
        ///  Whether the trigger is in OK or problem state.
        /// Possible values are:
        /// 0 - (default) OK;
        /// 1 - problem.
        /// </summary>
        public int? value;

        //public int hostid;

        //public int[] hostids;

        public Function.Function[] functions;

        public Host.Host[] hosts;
    }
}