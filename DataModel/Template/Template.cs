namespace ZabbixApi.DataModel.Template
{
    public class Template
    {

        /// <summary>
        /// </summary>
        /// <param name="host">Technical name of the template.</param>
        public Template(string host)
        {
            this.host = host;
        }


        /// <summary>
        ///  ID of the template.
        /// </summary>
        public string templateid;

        /// <summary>
        /// Technical name of the template.
        /// </summary>
        public string host;

        /// <summary>
        /// Visible name of the host. Default: host property value.
        /// </summary>
        public string name;
    }
}