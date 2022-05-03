namespace Nilgon.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        public static bool IsNullOrWhiteSpace(this string value)
        {
            bool conditionResult = value == null || value == " ";

            return conditionResult;
        }

        public static bool IsNotNullOrWhiteSpace(this string value)
        {
            bool conditionResult = !value.IsNullOrWhiteSpace();

            return conditionResult;
        }
    }
}
