namespace ZabbixApi.DataModel.Script
{
    public class Create : Script
    {
        /// <summary>
        /// </summary>
        /// <param name="command">Command to run.</param>
        /// <param name="name">Name of the script.</param>
        public Create(string command, string name)
            : base(command, name)
        {
        }
    }
}