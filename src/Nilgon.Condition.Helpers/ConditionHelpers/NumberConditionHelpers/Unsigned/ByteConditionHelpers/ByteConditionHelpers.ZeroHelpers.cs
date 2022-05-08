namespace Nilgon.Condition.Helpers;

public static partial class ByteConditionHelpers
{
    public static bool IsZero(this byte value)
    {
        bool conditionResult = value == 0;

        return conditionResult;
    }

    public static bool IsNotZero(this byte value)
    {
        bool conditionResult = value != 0;

        return conditionResult;
    }
}
