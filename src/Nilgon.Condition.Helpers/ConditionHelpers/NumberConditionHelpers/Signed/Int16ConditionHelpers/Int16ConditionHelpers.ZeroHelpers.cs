namespace Nilgon.Condition.Helpers;

public static partial class Int16ConditionHelpers
{
    public static bool IsZero(this short value)
    {
        bool conditionResult = value == 0;

        return conditionResult;
    }

    public static bool IsNotZero(this short value)
    {
        bool conditionResult = value != 0;

        return conditionResult;
    }
}
