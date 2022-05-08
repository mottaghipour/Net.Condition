namespace Nilgon.Condition.Helpers;

public static partial class IntPtrConditionHelpers
{
    public static bool IsOdd(this nint value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }

    public static bool IsNotOdd(this nint value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }
}
