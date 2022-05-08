namespace Nilgon.Condition.Helpers;

public static partial class SByteConditionHelpers
{
    public static bool IsEven(this sbyte value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }

    public static bool IsNotEven(this sbyte value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }
}
