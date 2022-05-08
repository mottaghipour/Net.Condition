using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers.NullOrEmptyOrWhiteSpaceHelpers;

public sealed class IsNotNullOrEmptyOrWhiteSpace_Condition_Helper_Tests
{
    [Fact]
    public void IsNotNullOrEmptyOrWhiteSpace_ReturnsTrue_WhenStringIsFull()
    {
        string stringToTest = "test";

        bool result = stringToTest.IsNotNullOrEmptyOrWhiteSpace();

        Assert.True(result);
    }

    [Fact]
    public void IsNotNullOrEmptyOrWhiteSpace_ReturnsFalse_WhenStringIsNull()
    {
        string stringToTest = null;

        bool result = stringToTest.IsNotNullOrEmptyOrWhiteSpace();

        Assert.False(result);
    }

    [Fact]
    public void IsNotNullOrEmptyOrWhiteSpace_ReturnsFalse_WhenStringIsEmpty()
    {
        string stringToTest = string.Empty;

        bool result = stringToTest.IsNotNullOrEmptyOrWhiteSpace();

        Assert.False(result);
    }

    [Fact]
    public void IsNotNullOrEmptyOrWhiteSpace_ReturnsFalse_WhenStringIsWhiteSpace()
    {
        string stringToTest = " ";

        bool result = stringToTest.IsNotNullOrEmptyOrWhiteSpace();

        Assert.False(result);
    }
}
