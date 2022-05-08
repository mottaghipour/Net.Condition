namespace Nilgon.Condition.Helpers;
public static partial class IntPtrConditionHelpers
{
    public static bool IsNegative(this nint value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }

    public static bool IsNotNegative(this nint value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }
}
