using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.UInt32ConditionHelpers.EvenHelpers;

public sealed class IsEven_Condition_Helper_Tests
{
    [Fact]
    public void IsEven_ReturnsTrue_WhenNumberIsEven()
    {
        uint numberToTest = 2;

        bool result = numberToTest.IsEven();

        Assert.True(result);
    }

    [Fact]
    public void IsEven_ReturnsFalse_WhenNumberIsOdd()
    {
        uint numberToTest = 1;

        bool result = numberToTest.IsEven();

        Assert.False(result);
    }
}
