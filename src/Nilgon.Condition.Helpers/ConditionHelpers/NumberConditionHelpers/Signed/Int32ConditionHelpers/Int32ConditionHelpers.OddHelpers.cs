namespace Nilgon.Condition.Helpers;

public static partial class Int32ConditionHelpers
{
    public static bool IsOdd(this int value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }

    public static bool IsNotOdd(this int value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }
}
