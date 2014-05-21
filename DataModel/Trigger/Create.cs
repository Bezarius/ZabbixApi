namespace ZabbixApi.DataModel.Trigger
{
    /// <summary>
    /// This request allows to create new triggers.
    /// </summary>
    public class Create : Trigger
    {
        /// <param name="description">Name of the trigger.</param>
        /// <param name="expression">Reduced trigger expression.</param>
        
        public Create(string description, string expression)
        {
            this.description = description;
            this.expression = expression;
        }

        /// <summary>
        /// Triggers that the trigger is dependent on. 
        /// The triggers must have the triggerid property defined.
        /// </summary>
        public string []dependencies;
    }
}