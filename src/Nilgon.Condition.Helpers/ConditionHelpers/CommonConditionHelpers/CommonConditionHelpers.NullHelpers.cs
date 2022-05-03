namespace Nilgon.Condition.Helpers
{
    public static partial class CommonConditionHelpers
    {
        /// <summary>
        ///    Checks if the <paramref name="value" /> is <see langword="null" />.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns>
        ///    <see langword="true" /> if the <paramref name="value"/> is <see langword="null" />; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsNull<T>(this T value)
        {
            bool conditionResult = value is null;
            
            return conditionResult;
        }

        /// <summary>
        ///    Checks if the <paramref name="value" /> is not <see langword="null" />.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns>
        ///    <see langword="true" /> if the <paramref name="value"/> is not <see langword="null" />; otherwise, <see langword="false" />.
        /// </returns>
        public static bool IsNotNull<T>(this T value)
        {
            bool conditionResult = value is not null;
            
            return conditionResult;
        }
    }
}
