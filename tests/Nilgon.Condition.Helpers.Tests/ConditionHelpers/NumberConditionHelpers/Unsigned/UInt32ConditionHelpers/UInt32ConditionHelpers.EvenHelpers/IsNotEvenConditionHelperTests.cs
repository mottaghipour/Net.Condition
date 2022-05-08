using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.UInt32ConditionHelpers.EvenHelpers;

public sealed class IsNotEven_Condition_Helper_Tests
{
    [Fact]
    public void IsNotEven_ReturnsTrue_WhenNumberIsOdd()
    {
        uint numberToTest = 1;

        bool result = numberToTest.IsNotEven();

        Assert.True(result);
    }

    [Fact]
    public void IsNotEven_ReturnsFalse_WhenNumberIsEven()
    {
        uint numberToTest = 2;

        bool result = numberToTest.IsNotEven();

        Assert.False(result);
    }
}
