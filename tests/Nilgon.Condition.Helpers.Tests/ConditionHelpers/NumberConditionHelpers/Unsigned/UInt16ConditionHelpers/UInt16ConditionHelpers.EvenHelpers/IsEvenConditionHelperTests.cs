using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.UInt16ConditionHelpers.EvenHelpers;

public sealed class IsEven_Condition_Helper_Tests
{
    [Fact]
    public void IsEven_ReturnsTrue_WhenNumberIsEven()
    {
        ushort numberToTest = 2;

        bool result = numberToTest.IsEven();

        Assert.True(result);
    }

    [Fact]
    public void IsEven_ReturnsFalse_WhenNumberIsOdd()
    {
        ushort numberToTest = 1;

        bool result = numberToTest.IsEven();

        Assert.False(result);
    }
}
