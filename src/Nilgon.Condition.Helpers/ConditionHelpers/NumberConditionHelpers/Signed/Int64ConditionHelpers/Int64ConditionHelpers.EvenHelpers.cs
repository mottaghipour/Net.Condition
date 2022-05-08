namespace Nilgon.Condition.Helpers;

public static partial class Int64ConditionHelpers
{
    public static bool IsEven(this long value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }

    public static bool IsNotEven(this long value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }
}
