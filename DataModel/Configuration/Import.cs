namespace ZabbixApi.DataModel.Configuration
{
    public class Import
    {
        /// <summary>
        /// </summary>
        /// <param name="format">
        /// Format of the serialized string.
        /// Possible values:
        /// json - JSON;
        /// xml - XML.</param>
        /// <param name="source">Serialized string containing the configuration data.</param>
        public Import(string format, string source)
        {
            this.format = format;
            this.source = source;
        }

        /// <summary>
        /// Format of the serialized string.
        /// Possible values:
        /// json - JSON;
        /// xml - XML.
        /// </summary>
        public string format;

        /// <summary>
        /// Serialized string containing the configuration data.
        /// </summary>
        public string source;

        /// <summary>
        /// Rules on how new and existing objects should be imported. The rules parameter is described in detail in the table below.
        /// </summary>
        public Rules rules;
    }
}