namespace Nilgon.Condition.Helpers;

public static partial class UInt16ConditionHelpers
{
    public static bool IsEven(this ushort value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }

    public static bool IsNotEven(this ushort value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }
}
