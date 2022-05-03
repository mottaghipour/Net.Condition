namespace Nilgon.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        public static bool IsEmpty(this string value)
        {
            bool conditionResult = value == string.Empty;

            return conditionResult;
        }

        public static bool IsNotEmpty(this string value)
        {
            bool conditionResult = value != string.Empty;

            return conditionResult;
        }
    }
}
