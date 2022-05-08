namespace Nilgon.Condition.Helpers;

public static partial class UInt32ConditionHelpers
{
    public static bool IsEven(this uint value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }

    public static bool IsNotEven(this uint value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }
}
