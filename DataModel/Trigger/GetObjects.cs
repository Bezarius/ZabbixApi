namespace ZabbixApi.DataModel.Trigger
{
    /// <summary>
    /// This request allows to retrieve triggers that match the given filter criteria.
    /// </summary>
    public class GetObjects : Trigger
    {
        /// <param name="description">Name of the trigger.</param>
        /// <param name="expression">Reduced trigger expression.</param>
        /*
        public GetObjects(string description, string expression)
            : base(description, expression)
        {

        }*/

        /// <summary>
        ///  Technical name of the host that the trigger belongs to.
        /// </summary>
        public string[] host;

        /// <summary>
        ///  ID of the host that the trigger belongs to.
        /// </summary>
        public string[] hostid;

        /// <summary>
        ///  Name of the node the host group must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        ///  ID of the node the host group must belong to.
        /// </summary>
        public string[] nodeids;
    }
}