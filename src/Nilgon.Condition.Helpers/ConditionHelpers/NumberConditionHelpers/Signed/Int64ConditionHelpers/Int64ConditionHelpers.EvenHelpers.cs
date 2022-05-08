namespace Nilgon.Condition.Helpers;

public static partial class Int64ConditionHelpers
{
    /// <summary>
    ///    Checks if the <paramref name="value" /> is even.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is even; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsEven(this long value)
    {
        bool conditionResult = value % 2 == 0;

        return conditionResult;
    }

    /// <summary>
    ///    Checks if the <paramref name="value" /> is not even.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is not even; otherwise, <see langword="false" />.
    /// </returns>    
    public static bool IsNotEven(this long value)
    {
        bool conditionResult = value % 2 != 0;

        return conditionResult;
    }
}
