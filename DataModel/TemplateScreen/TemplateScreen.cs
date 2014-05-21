namespace ZabbixApi.DataModel.TemplateScreen
{
    public class TemplateScreen
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the template screen.</param>
        /// <param name="templateid">ID of the template that the screen belongs to.</param>
        public TemplateScreen(string name, string templateid)
        {
            this.name = name;
            this.templateid = templateid;
        }

        /// <summary>
        ///  ID of the template screen.
        /// </summary>
        public string screenid;

        /// <summary>
        /// Name of the template screen.
        /// </summary>
        public string name;

        /// <summary>
        /// ID of the template that the screen belongs to.
        /// </summary>
        public string templateid;

        /// <summary>
        /// Width of the template screen.
        /// Default: 1.
        /// </summary>
        public int hsize;

        /// <summary>
        /// Height of the template screen.
        /// Default: 1.
        /// </summary>
        public int vsize;
    }
}
