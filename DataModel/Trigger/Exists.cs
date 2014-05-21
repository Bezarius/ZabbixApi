namespace ZabbixApi.DataModel.Trigger
{
    /// <summary>
    /// This request checks if at least one trigger that matches the given filter criteria exists.
    /// </summary>
    public class Exists
    {
        /// <summary>
        ///  (required)Exploded trigger expression.
        /// </summary>
        public string expression;

        /// <summary>
        ///  (required)Technical names of the hosts the triggers must belong to.
        /// </summary>
        public string[] host;

        /// <summary>
        ///  (required)IDs of the hosts the triggers must belong to.
        /// </summary>
        public string[] hostid;

        /// <summary>
        ///  Names of the triggers.
        /// </summary>
        public string[] description;

        /// <summary>
        ///  Name of the node the triggers must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        ///  IDs of the nodes the triggers must belong to.
        /// </summary>
        public string[] nodeids;
    }
}