namespace Nilgon.Condition.Helpers;

public static partial class SByteConditionHelpers
{
    public static bool IsNegative(this sbyte value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }

    public static bool IsNotNegative(this sbyte value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }    
}
