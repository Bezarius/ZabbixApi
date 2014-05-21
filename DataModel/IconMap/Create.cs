namespace ZabbixApi.DataModel.IconMap
{
    public class Create : IconMap
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the icon map.</param>
        /// /// <param name="mappings">Icon mappings to be created for the icon map.</param>
        public Create(string name, IconMapping[] mappings)
            : base(name)
        {
            this.mappings = mappings;
        }

        /// <summary>
        /// Icon mappings to be created for the icon map.
        /// </summary>
        public IconMapping[] mappings;
    }
}