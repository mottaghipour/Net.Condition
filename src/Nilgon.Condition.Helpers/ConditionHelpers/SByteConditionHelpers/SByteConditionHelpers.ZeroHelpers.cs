namespace Nilgon.Condition.Helpers
{
    public static partial class SByteConditionHelpers
    {
        public static bool IsZero(this sbyte value)
        {
            bool conditionResult = value == 0;
            
            return conditionResult;
        }

        public static bool IsNotZero(this sbyte value)
        {
            bool conditionResult = value != 0;

            return conditionResult;
        }
    }
}
