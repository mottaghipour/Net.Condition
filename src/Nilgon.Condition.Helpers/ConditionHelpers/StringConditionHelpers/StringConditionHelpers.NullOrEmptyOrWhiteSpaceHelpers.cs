namespace Nilgon.Condition.Helpers;

public static partial class StringConditionHelpers
{
    /// <summary>
    ///    Checks if the <paramref name="value" /> is <see langword="null" /> or empty or white-space.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is <see langword="null" /> or empty or white-space; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNullOrEmptyOrWhiteSpace(this string value)
    {
        bool conditionResult = string.IsNullOrWhiteSpace(value);

        return conditionResult;
    }

    /// <summary>
    ///    Checks if the <paramref name="value" /> is not <see langword="null" /> or empty or white-space.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is not <see langword="null" /> or empty or white-space; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNotNullOrEmptyOrWhiteSpace(this string value)
    {
        bool conditionResult = !string.IsNullOrWhiteSpace(value);

        return conditionResult;
    }
}
