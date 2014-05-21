namespace ZabbixApi.DataModel.Image
{
    public class Exists
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
        /// IDs of images.
        /// </summary>
        public string[] imageid;

        /// <summary>
        /// Types of images. Refer to the image "imagetype" property for a list of supported types.
        /// </summary>
        public int[] imagetype;

        /// <summary>
        /// Names of images.
        /// </summary>
        public string[] name;
    }
}