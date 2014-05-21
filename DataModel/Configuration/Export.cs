namespace ZabbixApi.DataModel.Configuration
{
    public class Export
    {
        /// <summary>
        /// </summary>
        /// <param name="format">
        /// Format in which the data must be exported.
        /// Possible values:
        /// json - JSON;
        /// xml - XML.
        /// </param>
        /// <param name="options">
        /// Objects to be exported.
        /// The options object has the following parameters:
        /// groups - (array) IDs of host groups to export;
        /// hosts - (array) IDs of hosts to export;
        /// images - (array) IDs of images to export;
        /// maps - (array) IDs of maps to export.
        /// screens - (array) IDs of screens to export;
        /// templates - (array) IDs of templates to export;
        ///</param>
        public Export(string format, object options)
        {
            this.format = format;
            this.options = options;
        }


        /// <summary>
        /// Format in which the data must be exported.
        /// Possible values:
        /// json - JSON;
        /// xml - XML.
        /// </summary>
        public string format;

        /// <summary>
        /// Objects to be exported.
        /// The options object has the following parameters:
        /// groups - (array) IDs of host groups to export;
        /// hosts - (array) IDs of hosts to export;
        /// images - (array) IDs of images to export;
        /// maps - (array) IDs of maps to export.
        /// screens - (array) IDs of screens to export;
        /// templates - (array) IDs of templates to export.
        /// </summary>
        public object options;
    }
}
