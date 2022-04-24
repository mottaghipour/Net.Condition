namespace Nilgon.Condition.Helpers
{
    public static partial class CommonConditionHelpers
    {
        public static bool IsNull<T>(this T value)
        {
            return value is null;
        }
    }
}
