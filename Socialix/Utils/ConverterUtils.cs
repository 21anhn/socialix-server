namespace Socialix.Utils
{
    public class ConverterUtils
    {
        public static string ConvertEnumToString(Enum key)
        {
            return Enum.GetName(typeof(Enum), key) ?? "";
        }
    }
}
