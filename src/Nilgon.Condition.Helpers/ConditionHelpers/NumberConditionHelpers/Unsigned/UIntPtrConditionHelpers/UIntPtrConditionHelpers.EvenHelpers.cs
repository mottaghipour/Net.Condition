namespace Nilgon.Condition.Helpers;

public static partial class UIntPtrConditionHelpers
{
    public static bool IsEven(this nuint value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }

    public static bool IsNotEven(this nuint value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }
}
