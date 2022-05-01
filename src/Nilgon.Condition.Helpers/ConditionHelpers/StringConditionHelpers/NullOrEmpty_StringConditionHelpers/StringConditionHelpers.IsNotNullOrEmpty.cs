namespace Nilgon.Condition.Helpers
{
	public static partial class StringConditionHelpers
	{
		public static bool IsNotNullOrEmpty(this string value)
        {
			return !string.IsNullOrEmpty(value);
        }
	}
}
