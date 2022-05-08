namespace Nilgon.Condition.Helpers;

public static partial class Int64ConditionHelpers
{
    /// <summary>
    ///    Checks if the <paramref name="value" /> is negative.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is negative; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNegative(this long value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }

    /// <summary>
    ///    Checks if the <paramref name="value" /> is not negative.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is not negative; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNotNegative(this long value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }
}
