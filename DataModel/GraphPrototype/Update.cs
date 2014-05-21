namespace ZabbixApi.DataModel.GraphPrototype
{
    public class Update : GraphPrototype
    {

        /// <summary>
        /// Graph items to be created for the graph prototypes. Graph items can reference both items and item prototypes, but at least one item prototype must be present.
        /// </summary>
        public GraphItem.GraphItem[] gitems;

        /// <summary>
        /// </summary>
        /// <param name="height">Height of the graph prototype in pixels.</param>
        /// <param name="name">Name of the graph prototype.</param>
        /// <param name="width">Width of the graph prototype in pixels.</param>
        /// <param name="gitems">Graph items to be created for the graph prototypes. Graph items can reference both items and item prototypes, but at least one item prototype must be present.</param>
        public Update(int height, string name, int width, GraphItem.GraphItem[] gitems)
            : base(height, name, width)
        {
            this.gitems = gitems;
        }
    }
}