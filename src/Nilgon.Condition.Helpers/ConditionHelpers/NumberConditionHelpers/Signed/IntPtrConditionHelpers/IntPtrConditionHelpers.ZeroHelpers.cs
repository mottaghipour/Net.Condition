using System;

namespace Nilgon.Condition.Helpers;

public static partial class IntPtrConditionHelpers
{
    public static bool IsZero(this nint value)
    {
        bool conditionResult = value == IntPtr.Zero;

        return conditionResult;
    }

    public static bool IsNotZero(this nint value)
    {
        bool conditionResult = value != IntPtr.Zero;

        return conditionResult;
    }
}
