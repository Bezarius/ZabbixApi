namespace ZabbixApi.DataModel.UserMacro
{
    public class Create : HostMacro
    {
        /// <summary>
        /// </summary>
        /// <param name="hostid">ID of the host that the macro belongs to.</param>
        /// <param name="macro">Macro string.</param>
        /// <param name="value">Value of the macro.</param>
        public Create(string hostid, string macro, string value) : base(hostid, macro, value)
        {
        }
    }
}