using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.UIntPtrConditionHelpers.OddHelpers;

public sealed class IsOdd_Condition_Helper_Tests
{
    [Fact]
    public void IsOdd_ReturnsTrue_WhenNumberIsOdd()
    {
        nuint numberToTest = 1;

        bool result = numberToTest.IsOdd();

        Assert.True(result);
    }

    [Fact]
    public void IsOdd_ReturnsFalse_WhenNumberIsEven()
    {
        nuint numberToTest = 2;

        bool result = numberToTest.IsOdd();

        Assert.False(result);
    }
}
