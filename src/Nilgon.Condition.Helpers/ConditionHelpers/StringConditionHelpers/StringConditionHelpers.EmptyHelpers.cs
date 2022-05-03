namespace Nilgon.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        /// <summary>
        ///    Checks if the <paramref name="value" /> is empty.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        ///    <see langword="true" /> if the <paramref name="value"/> is empty; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsEmpty(this string value)
        {
            bool conditionResult = value == string.Empty;

            return conditionResult;
        }

        /// <summary>
        ///    Checks if the <paramref name="value" /> is not empty.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        ///    <see langword="true" /> if the <paramref name="value"/> is not empty; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsNotEmpty(this string value)
        {
            bool conditionResult = value != string.Empty;

            return conditionResult;
        }
    }
}
