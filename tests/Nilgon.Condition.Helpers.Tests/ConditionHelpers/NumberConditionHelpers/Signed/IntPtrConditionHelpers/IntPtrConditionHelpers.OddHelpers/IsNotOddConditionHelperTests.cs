using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.IntPtrConditionHelpers.OddHelpers;

public sealed class IsNotOdd_Condition_Helper_Tests
{
    [Fact]
    public void IsNotOdd_ReturnsTrue_WhenNumberIsEven()
    {
        nint numberToTest = 2;

        bool result = numberToTest.IsNotOdd();

        Assert.True(result);
    }

    [Fact]
    public void IsNotOdd_ReturnsFalse_WhenNumberIsOdd()
    {
        nint numberToTest = 1;

        bool result = numberToTest.IsNotOdd();

        Assert.False(result);
    }
}
