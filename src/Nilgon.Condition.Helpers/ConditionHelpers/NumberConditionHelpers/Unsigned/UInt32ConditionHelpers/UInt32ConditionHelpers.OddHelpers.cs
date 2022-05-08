namespace Nilgon.Condition.Helpers;

public static partial class UInt32ConditionHelpers
{
    public static bool IsOdd(this uint value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }

    public static bool IsNotOdd(this uint value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }
}
