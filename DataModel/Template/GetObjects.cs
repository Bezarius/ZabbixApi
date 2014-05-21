namespace ZabbixApi.DataModel.Template
{
    public class GetObjects : Template
    {
        /// <summary>
        ///  Name of the node the templates must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        ///  ID of the node the templates must belong to
        /// </summary>
        public string[] nodeids;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="host">Technical name of the template.</param>
        public GetObjects(string host) : base(host)
        {
        }
    }
}