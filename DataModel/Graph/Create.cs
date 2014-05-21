namespace ZabbixApi.DataModel.Graph
{
    public class Create : Graph
    {
        /// <summary>
        /// Graph items to be created for the graph.
        /// </summary>
        public GraphItem.GraphItem[] gitems;

        /// <summary>
        /// </summary>
        /// <param name="height">Height of the graph in pixels.</param>
        /// <param name="name">Name of the graph</param>
        /// <param name="width">Width of the graph in pixels.</param>
        /// <param name="gitems">Graph items to be created for the graph.</param>
        public Create(int height, string name, int width, GraphItem.GraphItem[] gitems)
            : base(height, name, width)
        {
            this.gitems = gitems;
        }
    }
}