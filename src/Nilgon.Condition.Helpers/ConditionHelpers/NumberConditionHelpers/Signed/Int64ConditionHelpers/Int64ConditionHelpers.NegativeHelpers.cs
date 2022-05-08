namespace Nilgon.Condition.Helpers;

public static partial class Int64ConditionHelpers
{
    public static bool IsNegative(this long value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }

    public static bool IsNotNegative(this long value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }
}
