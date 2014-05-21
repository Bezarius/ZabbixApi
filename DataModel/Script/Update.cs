namespace ZabbixApi.DataModel.Script
{
    public class Update : Script
    {
        /// <summary>
        /// </summary>
        /// <param name="command">Command to run.</param>
        /// <param name="name">Name of the script.</param>
        public Update(string command, string name)
            : base(command, name)
        {
        }
    }
}