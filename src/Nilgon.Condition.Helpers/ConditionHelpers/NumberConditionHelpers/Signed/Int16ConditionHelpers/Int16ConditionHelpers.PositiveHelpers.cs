namespace Nilgon.Condition.Helpers;

public static partial class Int16ConditionHelpers
{
    /// <summary>
    ///    Checks if the <paramref name="value" /> is positive.
    /// </summary>
    /// <param name="value"></param>
    /// <returns>
    ///    <see langword="true" /> if the <paramref name="value"/> is positive; otherwise, <see langword="false" />.
    /// </returns>
    public static bool IsPositive(this short value)
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
    public static bool IsNotPositive(this short value)
    {
        bool conditionResult = value < 0;

        return conditionResult;
    }
}
