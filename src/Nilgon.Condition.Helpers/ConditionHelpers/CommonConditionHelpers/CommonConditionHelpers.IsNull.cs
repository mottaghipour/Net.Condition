namespace Nilgon.Condition.Helpers.ConditionHelpers.CommonConditionHelpers
{
    public static partial class CommonConditionHelpers
    {
        public static bool IsNull<T>(this T value)
        {
            return value is null;
        }
    }
}
