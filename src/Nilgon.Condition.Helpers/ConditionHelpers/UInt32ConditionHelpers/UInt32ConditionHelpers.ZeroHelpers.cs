namespace Nilgon.Condition.Helpers
{
    public static partial class UInt32ConditionHelpers
    {
        public static bool IsZero(this uint value)
        {
            bool conditionResult = value == 0;
            
            return conditionResult;
        }
        
        public static bool IsNotZero(this uint value)
        {
            bool conditionResult = value != 0;

            return conditionResult;
        }
    }
}
