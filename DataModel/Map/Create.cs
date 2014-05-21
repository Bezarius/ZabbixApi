namespace ZabbixApi.DataModel.Map
{
    public class Create : Map
    {
        /// <summary>
        /// </summary>
        /// <param name="height">Height of the map in pixels.</param>
        /// <param name="name">Name of the map.</param>
        /// <param name="width">Width of the map in pixels.</param>
        public Create(int height, string name, int width) : base(height, name, width)
        {
        }

        /// <summary>
        /// Map links to be created on the map.
        /// </summary>
        public MapLink[] links;

        /// <summary>
        /// Map elements to be created on the map.
        /// </summary>
        public MapElement[] selements;

        /// <summary>
        /// Map URLs to be created on the map.
        /// </summary>
        public MapURL[] urls;
    }
}