namespace ZabbixApi.DataModel.UserMacro
{
    public class CreateGlobal : GlobalMacro
    {
        /// <summary>
        /// </summary>
        /// <param name="macro">Macro string.</param>
        /// <param name="value">Value of the macro.</param>
        public CreateGlobal(string macro, string value) : base(macro, value)
        {
        }
    }
}