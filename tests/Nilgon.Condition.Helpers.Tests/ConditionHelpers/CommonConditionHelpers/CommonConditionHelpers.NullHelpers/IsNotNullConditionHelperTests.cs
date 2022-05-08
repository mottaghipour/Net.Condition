using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.CommonConditionHelpers.NullHelpers;

public sealed class IsNotNull_Condition_Helper_Tests
{
    [Fact]
    public void IsNotNull_ReturnsTrue_WhenValueIsNotNull()
    {
        object objectToTest = "test";

        bool result = objectToTest.IsNotNull();

        Assert.True(result);
    }
    
    [Fact]
    public void IsNotNull_ReturnsFalse_WhenValueIsNull()
    {
        object objectToTest = null;

        bool result = objectToTest.IsNotNull();

        Assert.False(result);
    }
}
