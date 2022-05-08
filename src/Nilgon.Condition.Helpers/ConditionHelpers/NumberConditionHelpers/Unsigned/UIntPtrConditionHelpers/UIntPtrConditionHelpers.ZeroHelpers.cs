namespace Nilgon.Condition.Helpers;

public static partial class UIntPtrConditionHelpers
{
    public static bool IsZero(this nuint value)
    {
        bool conditionResult = value == UIntPtr.Zero;

        return conditionResult;
    }

    public static bool IsNotZero(this nuint value)
    {
        bool conditionResult = value != UIntPtr.Zero;

        return conditionResult;
    }
}
