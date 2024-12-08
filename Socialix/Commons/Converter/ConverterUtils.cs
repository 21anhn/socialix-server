namespace Socialix.Commons.ConverterCommon
{
    public class ConverterUtils
    {
        public static string ConvertEnumToString(Enum key)
        {
            return Enum.GetName(typeof(Enum), key) ?? "";
        }

        public static decimal ConvertDateToDecimal(string date)
        {

        }
    }
}
