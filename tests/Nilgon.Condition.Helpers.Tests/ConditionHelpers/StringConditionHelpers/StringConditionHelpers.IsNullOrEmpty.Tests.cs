using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers
{
	public sealed class StringConditionHelpers_IsNullOrEmpty_Tests
	{
		[Fact]
		public void IsNullOrEmpty_ReturnsTrue_WhenStringIsNull()
        {
			string stringToTest = null;

			bool result = stringToTest.IsNullOrEmpty();

			Assert.True(result);
        }

		[Fact]
		public void IsNullOrEmpty_ReturnsTrue_WhenStringIsEmpty()
		{
			string stringToTest = string.Empty;

			bool result = stringToTest.IsNullOrEmpty();

			Assert.True(result);
		}

		[Fact]
		public void IsNullOrEmpty_ReturnsFalse_WhenStringIsWhiteSpace()
		{
			string stringToTest = " ";

			bool result = stringToTest.IsNullOrEmpty();

			Assert.False(result);
		}

		[Fact]
		public void IsNullOrEmpty_ReturnsFalse_WhenStringIsFull()
		{
			string stringToTest = "test";

			bool result = stringToTest.IsNullOrEmpty();

			Assert.False(result);
		}
	}
}
