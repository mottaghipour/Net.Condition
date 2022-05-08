using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.UInt16ConditionHelpers.OddHelpers;

public sealed class IsNotOdd_Condition_Helper_Tests
{
    [Fact]
    public void IsNotOdd_ReturnsTrue_WhenNumberIsEven()
    {
        ushort numberToTest = 2;

        bool result = numberToTest.IsNotOdd();

        Assert.True(result);
    }

    [Fact]
    public void IsNotOdd_ReturnsFalse_WhenNumberIsOdd()
    {
        ushort numberToTest = 1;

        bool result = numberToTest.IsNotOdd();

        Assert.False(result);
    }
}
