using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.SByteConditionHelpers.ZeroHelpers;

public sealed class IsNotZero_Condition_Helper_Tests
{
    [Fact]
    public void IsNotZero_ReturnsTrue_WhenNumberIsNotZero()
    {
        sbyte numberToTest = 1;

        bool result = numberToTest.IsNotZero();

        Assert.True(result);
    }

    [Fact]
    public void IsZero_ReturnsFalse_WhenNumberIsZero()
    {
        sbyte numberToTest = 0;

        bool result = numberToTest.IsNotZero();

        Assert.False(result);
    }
}
