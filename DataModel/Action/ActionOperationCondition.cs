namespace ZabbixApi.DataModel.Action
{
    public class ActionOperationCondition
    {
        /// <summary>
        /// </summary>
        /// <param name="conditiontype">
        ///Type of condition.
        /// Possible values:
        /// 14 - event acknowledged.
        /// Whether the event is acknowledged. 
        /// Possible values: 
        /// 0 - not acknowledged; 
        /// 1 - acknowledged.
        /// </param>
        /// <param name="value">Value to compare with.</param>
        public ActionOperationCondition(int conditiontype, string value)
        {
            this.conditiontype = conditiontype;
            this.value = value;
        }

        /// <summary>
        ///  ID of the action operation condition
        /// </summary>
        public string opconditionid;

        /// <summary>
        /// 
        ///Type of condition.
        /// Possible values:
        /// 14 - event acknowledged.
        /// Possible values: 
        /// 0 - not acknowledged; 
        /// 1 - acknowledged.
        /// </summary>
        public int? conditiontype;

        /// <summary>
        /// Value to compare with.
        /// </summary>
        public string value;

        /// <summary>
        ///  ID of the operation.
        /// </summary>
        public string operationid;

        /// <summary>
        /// 
        ///Condition operator.
        /// Possible values:
        /// 0 - (default) =.
        /// </summary>
        public int? @operator;
    }
}