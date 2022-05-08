namespace Nilgon.Condition.Helpers;

public static partial class UInt16ConditionHelpers
{
    public static bool IsZero(this ushort value)
    {
        bool conditionResult = value == 0;

        return conditionResult;
    }

    public static bool IsNotZero(this ushort value)
    {
        bool conditionResult = value != 0;

        return conditionResult;
    }
}
