﻿using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers.WhiteSpaceHelpers;

public sealed class IsWhiteSpace_Condition_Helper_Tests
{
    [Fact]
    public void IsWhiteSpace_ReturnsTrue_WhenStringIsWhiteSpace()
    {
        string stringToTest = " ";

        bool result = stringToTest.IsWhiteSpace();

        Assert.True(result);
    }


    [Fact]
    public void IsWhiteSpace_ReturnsFalse_WhenStringIsNull()
    {
        string stringToTest = null;

        bool result = stringToTest.IsWhiteSpace();

        Assert.False(result);
    }

    [Fact]
    public void IsWhiteSpace_ReturnsFalse_WhenStringIsEmpty()
    {
        string stringToTest = string.Empty;

        bool result = stringToTest.IsWhiteSpace();

        Assert.False(result);
    }


    [Fact]
    public void IsWhiteSpace_ReturnsFalse_WhenStringIsFull()
    {
        string stringToTest = "test";

        bool result = stringToTest.IsWhiteSpace();

        Assert.False(result);
    }
}
