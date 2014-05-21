namespace ZabbixApi.DataModel.TriggerPrototype
{
    public class Create : TriggerPrototype
    {
        /// <summary>
        /// </summary>
        /// <param name="description">Name of the trigger prototype.</param>
        /// <param name="expression">Reduced trigger expression.</param>
        public Create(string description, string expression)
        {
            this.description = description;
            this.expression = expression;
        }
    }
}