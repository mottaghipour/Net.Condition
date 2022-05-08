using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers.EmptyHelpers;

public sealed class IsEmpty_Condition_Helper_Tests
{
    [Fact]
    public void IsEmpty_ReturnsTrue_WhenStringIsEmpty()
    {
        string stringToTest = string.Empty;

        bool result = stringToTest.IsEmpty();

        Assert.True(result);
    }

    [Fact]
    public void IsEmpty_ReturnsFalse_WhenStringIsNull()
    {
        string stringToTest = null;

        bool result = stringToTest.IsEmpty();

        Assert.False(result);
    }

    [Fact]
    public void IsEmpty_ReturnsFalse_WhenStringIsWhiteSpace()
    {
        string stringToTest = " ";

        bool result = stringToTest.IsEmpty();

        Assert.False(result);
    }

    [Fact]
    public void IsEmpty_ReturnsFalse_WhenStringIsFull()
    {
        string stringToTest = "test";

        bool result = stringToTest.IsEmpty();

        Assert.False(result);
    }
}
