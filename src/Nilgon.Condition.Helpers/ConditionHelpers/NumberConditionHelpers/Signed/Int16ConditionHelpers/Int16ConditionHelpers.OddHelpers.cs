namespace Nilgon.Condition.Helpers;

public static partial class Int16ConditionHelpers
{
    public static bool IsOdd(this short value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }

    public static bool IsNotOdd(this short value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }
}
