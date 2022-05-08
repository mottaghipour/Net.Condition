namespace Nilgon.Condition.Helpers;

public static partial class SByteConditionHelpers
{
    /// <summary>
    ///    Checks if the <paramref name="value" /> is positive.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is positive; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsPositive(this sbyte value)
    {
        bool conditionResult = value > 0;

        return conditionResult;
    }

    /// <summary>
    ///    Checks if the <paramref name="value" /> is not positive.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is not positive; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNotPositive(this sbyte value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }
}
