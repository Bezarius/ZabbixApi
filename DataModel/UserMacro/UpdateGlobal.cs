namespace ZabbixApi.DataModel.UserMacro
{
    public class UpdateGlobal : GlobalMacro
    {
        /// <summary>
        /// </summary>
        /// <param name="macro">Macro string.</param>
        /// <param name="value">Value of the macro.</param>
        public UpdateGlobal(string macro, string value) : base(macro, value)
        {
        }
    }
}