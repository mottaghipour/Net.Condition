namespace Nilgon.Condition.Helpers
{
    public static partial class CommonConditionHelpers
    {
        public static bool IsNull<T>(this T value)
        {
            return value is null;
        }
        
        public static bool IsNotNull<T>(this T value)
        {
            return value is not null;
        }
    }
}
