namespace Nilgon.Condition.Helpers
{
    public static partial class UInt64ConditionHelpers
    {
        public static bool IsZero(this ulong value)
        {
            bool conditionResult = value == 0;

            return conditionResult;
        }

        public static bool IsNotZero(this ulong value)
        {
            bool conditionResult = value != 0;

            return conditionResult;
        }
    }
}
