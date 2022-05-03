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
            bool conditionResult = CheckIsNullCondition(value);
            
            return conditionResult;
        }

        private static bool CheckIsNullCondition<T>(T value)
        {
            return value is null;
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
            bool conditionResult = CheckIsNotNullCondition(value);
            
            return conditionResult;
        }

        private static bool CheckIsNotNullCondition<T>(T value)
        {
            return value is not null;
        }
    }
}
