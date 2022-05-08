using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.ByteConditionHelpers.EvenHelpers;

public sealed class IsNotEven_Condition_Helper_Tests
{
    [Fact]
    public void IsNotEven_ReturnsTrue_WhenNumberIsOdd()
    {
        byte numberToTest = 1;

        bool result = numberToTest.IsNotEven();

        Assert.True(result);
    }

    [Fact]
    public void IsNotEven_ReturnsFalse_WhenNumberIsEven()
    {
        byte numberToTest = 2;

        bool result = numberToTest.IsNotEven();

        Assert.False(result);
    }
}
