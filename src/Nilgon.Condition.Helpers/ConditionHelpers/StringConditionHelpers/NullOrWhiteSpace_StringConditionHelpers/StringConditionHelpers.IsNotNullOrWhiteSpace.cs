namespace Nilgon.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        public static bool IsNotNullOrWhiteSpace(this string value)
        {
            return !value.IsNullOrWhiteSpace();
        }
    }
}
