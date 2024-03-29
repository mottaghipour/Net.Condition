﻿using Xunit;

namespace Nilgon.Condition.Helpers.Tests.ConditionHelpers.StringConditionHelpers.NullOrEmptyHelpers;

public sealed class IsNotNullOrEmpty_Condition_Helper_Tests
{
	[Fact]
	public void IsNotNullOrEmpty_ReturnsTrue_WhenStringIsWhiteSpace()
        {
		string stringToTest = " ";

		bool result = stringToTest.IsNotNullOrEmpty();

		Assert.True(result);
        }

	[Fact]
	public void IsNotNullOrEmpty_ReturnsTrue_WhenStringIsFull()
	{
		string stringToTest = "test";

		bool result = stringToTest.IsNotNullOrEmpty();

		Assert.True(result);
	}

	[Fact]
	public void IsNotNullOrEmpty_ReturnsFalse_WhenStringIsNull()
	{
		string stringToTest = null;

		bool result = stringToTest.IsNotNullOrEmpty();

		Assert.False(result);
	}

	[Fact]
	public void IsNotNullOrEmpty_ReturnsFalse_WhenStringIsEmpty()
	{
		string stringToTest = string.Empty;

		bool result = stringToTest.IsNotNullOrEmpty();

		Assert.False(result);
	}
}
