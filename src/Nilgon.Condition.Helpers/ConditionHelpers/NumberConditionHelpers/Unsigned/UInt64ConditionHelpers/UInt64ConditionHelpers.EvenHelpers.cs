namespace Nilgon.Condition.Helpers;

public static partial class UInt64ConditionHelpers
{
    public static bool IsEven(this ulong value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }

    public static bool IsNotEven(this ulong value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }
}
