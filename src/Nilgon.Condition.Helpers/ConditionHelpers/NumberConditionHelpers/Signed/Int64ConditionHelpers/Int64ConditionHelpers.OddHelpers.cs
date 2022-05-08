namespace Nilgon.Condition.Helpers;

public static partial class Int64ConditionHelpers
{
    public static bool IsOdd(this long value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }

    public static bool IsNotOdd(this long value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }
}
