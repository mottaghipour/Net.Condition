namespace Nilgon.Condition.Helpers
{
	public static partial class StringConditionHelpers
	{
		public static bool IsNullOrEmpty(this string value)
        {
			bool conditionResult = CheckIsNullOrEmptyCondition(value);

			return conditionResult;
		}

        private static bool CheckIsNullOrEmptyCondition(string value)
        {
			return string.IsNullOrEmpty(value);
        }

		public static bool IsNotNullOrEmpty(this string value)
		{
			bool conditionResult = CheckIsNotNullOrEmptyCondition(value);

			return conditionResult;
		}

		private static bool CheckIsNotNullOrEmptyCondition(string value)
		{
			return !string.IsNullOrEmpty(value);
		}
	}
}
