namespace Nilgon.Condition.Helpers;

public static partial class ByteConditionHelpers
{
    public static bool IsEven(this byte value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }

    public static bool IsNotEven(this byte value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }
}
