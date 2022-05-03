namespace Nilgon.Condition.Helpers
{
	public static partial class StringConditionHelpers
	{
		public static bool IsNullOrEmpty(this string value)
        {
			bool conditionResult = string.IsNullOrEmpty(value);

			return conditionResult;
		}

		public static bool IsNotNullOrEmpty(this string value)
		{
			bool conditionResult = !string.IsNullOrEmpty(value);

			return conditionResult;
		}
	}
}
