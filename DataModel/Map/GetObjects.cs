namespace ZabbixApi.DataModel.Map
{
    public class GetObjects : Map
    {
        /// <summary>
        /// Name of the node the maps must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the maps must belong to.
        /// </summary>
        public string[] nodeids;

        /// <summary>
        /// </summary>
        /// <param name="height">Height of the map in pixels.</param>
        /// <param name="name">Name of the map.</param>
        /// <param name="width">Width of the map in pixels.</param>
        public GetObjects(int height, string name, int width) : base(height, name, width)
        {
        }
    }
}