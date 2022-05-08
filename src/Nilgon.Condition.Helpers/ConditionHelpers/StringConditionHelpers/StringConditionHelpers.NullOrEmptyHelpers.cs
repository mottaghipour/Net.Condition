namespace Nilgon.Condition.Helpers;

public static partial class StringConditionHelpers
{
    /// <summary>
    ///    Checks if the <paramref name="value" /> is <see langword="null" /> or empty.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is <see langword="null" /> or empty; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNullOrEmpty(this string value)
    {
        bool conditionResult = string.IsNullOrEmpty(value);

        return conditionResult;
    }

    /// <summary>
    ///    Checks if the <paramref name="value" /> is not <see langword="null" /> or empty.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is not <see langword="null" /> or empty; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNotNullOrEmpty(this string value)
    {
        bool conditionResult = !string.IsNullOrEmpty(value);

        return conditionResult;
    }
}
