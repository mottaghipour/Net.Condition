namespace Nilgon.Condition.Helpers
{
    public static partial class StringConditionHelpers
    {
        /// <summary>
        ///    Checks if the <paramref name="value" /> is or whitespace.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        ///    <see langword="true" /> if the <paramref name="value"/> is or white-space; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsWhiteSpace(this string value)
        {
            bool conditionResult = value == " ";

            return conditionResult;
        }

        /// <summary>
        ///    Checks if the <paramref name="value" /> is not or whitespace.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>
        ///    <see langword="true" /> if the <paramref name="value"/> is not or white-space; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsNotWhiteSpace(this string value)
        {
            bool conditionResult = value != " ";

            return conditionResult;
        }
    }
}
