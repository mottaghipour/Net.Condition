namespace Nilgon.Condition.Helpers;

public static partial class Int32ConditionHelpers
{
    public static bool IsPositive(this int value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }

    public static bool IsNotPositive(this int value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }
}
