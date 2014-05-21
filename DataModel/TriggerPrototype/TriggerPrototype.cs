namespace ZabbixApi.DataModel.TriggerPrototype
{
    public class TriggerPrototype
    {
        /*
        /// <summary>
        /// </summary>
        /// <param name="description">Name of the trigger prototype.</param>
        /// <param name="expression">Reduced trigger expression.</param>
        public TriggerPrototype(string description, string expression)
        {
            this.description = description;
            this.expression = expression;
        }*/

        /// <summary>
        ///  ID of the trigger prototype.
        /// </summary>
        public string triggerid;

        /// <summary>
        /// Name of the trigger prototype.
        /// </summary>
        public string description;

        /// <summary>
        /// Reduced trigger expression.
        /// </summary>
        public string expression;

        /// <summary>
        /// Additional comments to the trigger prototype.
        /// </summary>
        public string comments;

        /// <summary>
        /// Severity of the trigger prototype.
        /// Possible values:
        /// 0 - (default) not classified;
        /// 1 - information;
        /// 2 - warning;
        /// 3 - average;
        /// 4 - high;
        /// 5 - disaster.
        /// </summary>
        public int priority;

        /// <summary>
        /// Whether the trigger prototype is enabled or disabled.
        /// Possible values:
        /// 0 - (default) enabled;
        /// 1 - disabled.
        /// </summary>
        public int status;

        /// <summary>
        ///  ID of the parent template trigger prototype.
        /// </summary>
        public string templateid;

        /// <summary>
        /// Whether the trigger prototype can generate multiple problem events.
        /// Possible values:
        /// 0 - (default) do not generate multiple events;
        /// 1 - generate multiple events.
        /// </summary>
        public int type;

        /// <summary>
        /// URL associated with the trigger prototype.
        /// </summary>
        public string url;
    }
}
