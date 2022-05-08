namespace Nilgon.Condition.Helpers;
public static partial class IntPtrConditionHelpers
{
    public static bool IsNegative(this nint value)
    {
        /// <summary>
        ///    Checks if the <paramref name="value" /> is negative.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        ///    <see langword="true" /> if the <paramref name="value"/> is negative; otherwise, <see langword="false" />.
        /// </returns>
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
    public static bool IsNotNegative(this nint value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }
}
