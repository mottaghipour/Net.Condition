namespace Nilgon.Condition.Helpers;

public static partial class Int32ConditionHelpers
{
    public static bool IsEven(this int value)
    {
        bool conditionResult = value % 2 == 0;
        
        return conditionResult;
    }

    public static bool IsNotEven(this int value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }
}
