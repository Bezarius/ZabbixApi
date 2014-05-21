namespace ZabbixApi.DataModel.Host
{
    public class GetObjects : Host
    {
        /// <param name="host">Technical name of the host.</param>
        public GetObjects(string host)
            : base(host)
        {
        }

        /// <summary>
        ///  Name of the node the hosts must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        ///  ID of the node the hosts must belong to.
        /// </summary>
        public string[] nodeids;

        
    }
}