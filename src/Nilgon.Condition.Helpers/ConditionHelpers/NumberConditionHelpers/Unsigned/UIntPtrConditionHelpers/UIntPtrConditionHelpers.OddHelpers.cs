namespace Nilgon.Condition.Helpers;

public static partial class UIntPtrConditionHelpers
{
    public static bool IsOdd(this nuint value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }

    public static bool IsNotOdd(this nuint value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }
}
