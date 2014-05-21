namespace ZabbixApi.DataModel.TemplateScreen
{
    public class Update : TemplateScreen
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the template screen.</param>
        /// <param name="templateid">ID of the template that the screen belongs to.</param>
        public Update(string name, string templateid)
            : base(name, templateid)
        {
        }

        /// <summary>
        /// Template screen items to create on the screen.
        /// </summary>
        public ScreenItem.ScreenItem[] screenitems;
    }
}