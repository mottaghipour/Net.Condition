namespace Nilgon.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        public static bool IsNullOrEmptyOrWhiteSpace(this string value)
        {
            bool conditionResult = string.IsNullOrWhiteSpace(value);

            return conditionResult;
        }

        public static bool IsNotNullOrEmptyOrWhiteSpace(this string value)
        {
            bool conditionResult = !string.IsNullOrWhiteSpace(value);

            return conditionResult;
        }
    }
}
