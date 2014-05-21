namespace ZabbixApi.DataModel.Image
{
    public class Create : Image
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the image.</param>
        /// <param name="image">Base64 encoded image. The maximum size of the encoded image is 1 MB.</param>
        public Create(string name, string image)
            : base(name)
        {
            this.image = image;
        }

        /// <summary>
        /// Base64 encoded image. The maximum size of the encoded image is 1 MB.
        /// </summary>
        public string image;
    }
}