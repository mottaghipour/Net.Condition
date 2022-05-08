namespace Nilgon.Condition.Helpers;

public static partial class Int32ConditionHelpers
{
    public static bool IsNegative(this int value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }

    public static bool IsNotNegative(this int value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }
}
