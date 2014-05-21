namespace ZabbixApi.DataModel.Image
{
    public class Image
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the image.</param>
        public Image(string name)
        {
            this.name = name;
        }

        /// <summary>
        ///  ID of the image.
        /// </summary>
        public string imageid;

        /// <summary>
        /// Name of the image.
        /// </summary>
        public string name;

        /// <summary>
        /// Type of image.
        /// Possible values:
        /// 1 - (default) icon;
        /// 2 - background image.
        /// </summary>
        public int imagetype;
    }
}
