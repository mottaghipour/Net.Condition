namespace Nilgon.Condition.Helpers;

public static partial class Int16ConditionHelpers
{
    public static bool IsEven(this short value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }

    public static bool IsNotEven(this short value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }
}
