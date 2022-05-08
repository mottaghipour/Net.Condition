namespace Nilgon.Condition.Helpers;

public static partial class Int64ConditionHelpers
{
    public static bool IsPositive(this long value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }

    public static bool IsNotPositive(this long value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }
}
