namespace Nilgon.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        public static bool IsNullOrWhiteSpace(this string value)
        {
            return value is null || value == " ";
        }

        public static bool IsNotNullOrWhiteSpace(this string value)
        {
            return !value.IsNullOrWhiteSpace();
        }
    }
}
