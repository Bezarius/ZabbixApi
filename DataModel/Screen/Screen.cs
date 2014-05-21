namespace ZabbixApi.DataModel.Screen
{
    public class Screen
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the screen.</param>
        public Screen(string name)
        {
            this.name = name;
        }

        /// <summary>
        ///  ID of the screen.
        /// </summary>
        public string screenid;

        /// <summary>
        /// Name of the screen.
        /// </summary>
        public string name;

        /// <summary>
        /// Width of the screen.
        /// Default: 1.
        /// </summary>
        public int hsize;

        /// <summary>
        /// Height of the screen.
        /// Default: 1.
        /// </summary>
        public int vsize;
    }
}
