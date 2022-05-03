namespace Nilgon.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        public static bool IsWhiteSpace(this string value)
        {
            bool conditionResult = value == " ";

            return conditionResult;
        }

        public static bool IsNotWhiteSpace(this string value)
        {
            bool conditionResult = value != " ";

            return conditionResult;
        }
    }
}
