namespace Nilgon.Condition.Helpers;

public static partial class Int64ConditionHelpers
{
    /// <summary>
    ///    Checks if the <paramref name="value" /> is odd.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is odd; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsOdd(this long value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }

    /// <summary>
    ///    Checks if the <paramref name="value" /> is not odd.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is not odd; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNotOdd(this long value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }
}
