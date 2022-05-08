namespace Nilgon.Condition.Helpers;

public static partial class ByteConditionHelpers
{
    public static bool IsOdd(this byte value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }

    public static bool IsNotOdd(this byte value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }
}
