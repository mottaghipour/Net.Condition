namespace Nilgon.Condition.Helpers;

public static partial class StringConditionHelpers
{
    /// <summary>
    ///    Checks if the <paramref name="value" /> is <see langword="null" /> or white-space.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is <see langword="null" /> or white-space; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNullOrWhiteSpace(this string value)
    {
        bool conditionResult = value == null || value == " ";

        return conditionResult;
    }

    /// <summary>
    ///    Checks if the <paramref name="value" /> is not <see langword="null" /> or white-space.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is not <see langword="null" /> or white-space; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsNotNullOrWhiteSpace(this string value)
    {
        bool conditionResult = !value.IsNullOrWhiteSpace();

        return conditionResult;
    }
}
