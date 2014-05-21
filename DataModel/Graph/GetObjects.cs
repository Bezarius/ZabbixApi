namespace ZabbixApi.DataModel.Graph
{
    public class GetObjects : Graph
    {
        /// <summary>
        /// Name of the node the graphs must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// ID of the node the graphs must belong to.
        /// </summary>
        public string[] nodeids;

        /// <summary>
        /// </summary>
        /// <param name="height">Height of the graph in pixels.</param>
        /// <param name="name">Name of the graph</param>
        /// <param name="width">Width of the graph in pixels.</param>
        public GetObjects(int height, string name, int width) : base(height, name, width)
        {
        }
    }
}