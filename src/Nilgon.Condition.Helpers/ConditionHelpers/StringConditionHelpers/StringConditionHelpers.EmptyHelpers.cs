namespace Nilgon.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        public static bool IsEmpty(this string value)
        {
            bool conditionResult = CheckIsEmptyCondition(value);

            return conditionResult;
        }

        public static bool CheckIsEmptyCondition(string value)
        {
            return value == string.Empty;
        }

        public static bool IsNotEmpty(this string value)
        {
            bool conditionResult = CheckIsNotEmptyCondition(value);

            return conditionResult;
        }

        public static bool CheckIsNotEmptyCondition(string value)
        {
            return value != string.Empty;
        }
    }
}
