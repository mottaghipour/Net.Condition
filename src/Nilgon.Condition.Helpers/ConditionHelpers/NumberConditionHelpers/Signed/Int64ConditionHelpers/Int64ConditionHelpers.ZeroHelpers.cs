namespace Nilgon.Condition.Helpers;

public static partial class Int64ConditionHelpers
{
    public static bool IsZero(this long value)
    {
        bool conditionResult = value == 0;

        return conditionResult;
    }

    public static bool IsNotZero(this long value)
    {
        bool conditionResult = value != 0;

        return conditionResult;
    }
}
