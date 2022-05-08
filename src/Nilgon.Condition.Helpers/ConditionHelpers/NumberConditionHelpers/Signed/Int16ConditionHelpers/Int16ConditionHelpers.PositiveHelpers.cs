namespace Nilgon.Condition.Helpers;

public static partial class Int16ConditionHelpers
{
    public static bool IsPositive(this short value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }

    public static bool IsNotPositive(this short value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }
}
