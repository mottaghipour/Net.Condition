namespace Nilgon.Condition.Helpers;

public static partial class IntPtrConditionHelpers
{
    public static bool IsEven(this nint value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }

    public static bool IsNotEven(this nint value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }
}
