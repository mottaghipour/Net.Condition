namespace Nilgon.Condition.Helpers;

public static partial class SByteConditionHelpers
{
    public static bool IsPositive(this sbyte value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }

    public static bool IsNotPositive(this sbyte value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }
}
