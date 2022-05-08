namespace Nilgon.Condition.Helpers;

public static partial class IntPtrConditionHelpers
{
    public static bool IsPositive(this nint value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }

    public static bool IsNotPositive(this nint value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }
}
