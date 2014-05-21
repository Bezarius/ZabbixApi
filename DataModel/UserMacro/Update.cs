namespace ZabbixApi.DataModel.UserMacro
{
    public class Update : HostMacro
    {
        /// <summary>
        /// </summary>
        /// <param name="hostid">ID of the host that the macro belongs to.</param>
        /// <param name="macro">Macro string.</param>
        /// <param name="value">Value of the macro.</param>
        public Update(string hostid, string macro, string value) : base(hostid, macro, value)
        {
        }
    }
}