namespace ZabbixApi.DataModel.GraphPrototype
{
    public class GetObjects : GraphPrototype
    {
        /// <summary>
        /// Name of the node the graph prototypes must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the graph prototypes must belong to.
        /// </summary>
        public string[] nodeids;

        /// <summary>
        /// </summary>
        /// <param name="height">Height of the graph prototype in pixels.</param>
        /// <param name="name">Name of the graph prototype.</param>
        /// <param name="width">Width of the graph prototype in pixels.</param>
        public GetObjects(int height, string name, int width) : base(height, name, width)
        {
        }
    }
}