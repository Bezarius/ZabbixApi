namespace ZabbixApi.DataModel.Image
{
    public class GetObjects : Image
    {
        /// <summary>
        /// Name of the node the images must belong to. This will override the nodeids parameter.
        /// </summary>
        public string node;

        /// <summary>
        /// IDs of the nodes the images must belong to.
        /// </summary>
        public string[] nodeids;

        /// <summary>
        /// </summary>
        /// <param name="name">Name of the image.</param>
        public GetObjects(string name) : base(name)
        {
        }
    }
}