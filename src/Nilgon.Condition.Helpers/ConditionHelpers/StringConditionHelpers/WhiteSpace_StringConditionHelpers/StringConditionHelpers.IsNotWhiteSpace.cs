namespace Nilgon.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        public static bool IsNotWhiteSpace(this string value)
        {
            return value != " ";
        }
    }
}
