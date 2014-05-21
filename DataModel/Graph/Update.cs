namespace ZabbixApi.DataModel.Graph
{
    public class Update : Graph
    {

        /// <summary>
        /// Graph items to replace existing graph items. If a graph item has the gitemid property defined it will be updated, otherwise a new graph item will be created.
        /// </summary>
        public string[] gitems;

        /// <summary>
        /// </summary>
        /// <param name="height">Height of the graph in pixels.</param>
        /// <param name="name">Name of the graph</param>
        /// <param name="width">Width of the graph in pixels.</param>
        public Update(int height, string name, int width) : base(height, name, width)
        {
        }
    }
}