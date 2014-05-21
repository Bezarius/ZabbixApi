namespace ZabbixApi.DataModel.Screen
{
    public class Create : Screen
    {
        /// <summary>
        /// </summary>
        /// <param name="name">Name of the screen.</param>
        public Create(string name)
            : base(name)
        {
        }

        /// <summary>
        /// Screen items to be created for the screen.
        /// </summary>
        public ScreenItem.ScreenItem[] screenitems;
    }
}