namespace Nilgon.Condition.Helpers;

public static partial class SByteConditionHelpers
{
    public static bool IsOdd(this sbyte value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }

    public static bool IsNotOdd(this sbyte value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }
}
