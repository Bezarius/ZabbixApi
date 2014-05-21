namespace ZabbixApi.DataModel.TemplateScreen
{
    public class Create : TemplateScreen
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the template screen.</param>
        /// <param name="templateid">ID of the template that the screen belongs to.</param>
        public Create(string name, string templateid)
            : base(name, templateid)
        {
        }

        /// <summary>
        /// Template screen items to create on the screen.
        /// </summary>
        public ScreenItem.ScreenItem[] screenitems;
    }
}