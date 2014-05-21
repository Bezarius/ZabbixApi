namespace ZabbixApi.DataModel.TriggerPrototype
{
    public class Update : TriggerPrototype
    {
        /// <summary>
        /// </summary>
        /// <param name="description">Name of the trigger prototype.</param>
        /// <param name="expression">Reduced trigger expression.</param>
        public Update(string description, string expression)
        {
            this.description = description;
            this.expression = expression;
        }
    }
}