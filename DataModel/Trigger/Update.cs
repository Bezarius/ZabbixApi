namespace ZabbixApi.DataModel.Trigger
{
    /// <summary>
    /// This request allows to update existing triggers.
    /// </summary>
    public class Update: Trigger
    {
        /// <summary>
        /// The triggerid property must be defined for each trigger, all other properties are optional. Only the passed properties will be updated, all others will remain unchanged.
        /// </summary>
        public string[] dependencies;
    }
}