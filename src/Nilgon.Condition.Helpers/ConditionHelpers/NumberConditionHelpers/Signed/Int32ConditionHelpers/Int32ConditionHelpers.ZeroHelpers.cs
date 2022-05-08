namespace Nilgon.Condition.Helpers
{
    public static partial class Int32ConditionHelpers
    {
        public static bool IsZero(this int value)
        {
            bool conditionResult = value == 0;

            return conditionResult;
        }
        
        public static bool IsNotZero(this int value)
        {
            bool conditionResult = value != 0;

            return conditionResult;
        }
    }
}
