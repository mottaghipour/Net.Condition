namespace Nilgon.Condition.Helpers;

public static partial class UInt64ConditionHelpers
{
    public static bool IsOdd(this ulong value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }

    public static bool IsNotOdd(this ulong value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }
}
