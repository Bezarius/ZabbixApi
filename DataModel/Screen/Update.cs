namespace ZabbixApi.DataModel.Screen
{
    public class Update : Screen
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the screen.</param>
        public Update(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Screen items to be created for the screen.
        /// </summary>
        public ScreenItem.ScreenItem[] screenitems;
    }
}