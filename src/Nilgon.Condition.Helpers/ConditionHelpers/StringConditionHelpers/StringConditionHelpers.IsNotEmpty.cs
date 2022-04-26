namespace Nilgon.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        public static bool IsNotEmpty(this string value)
        {
            return value != string.Empty;
        }
    }
}
