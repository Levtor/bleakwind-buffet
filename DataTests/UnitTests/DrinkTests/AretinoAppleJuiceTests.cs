/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice order = new AretinoAppleJuice();

            Assert.False(order.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice order = new AretinoAppleJuice();

            Assert.Equal(order.Size, Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice order = new AretinoAppleJuice();

            order.Ice = true;
            Assert.True(order.Ice);
            order.Ice = false;
            Assert.False(order.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice order = new AretinoAppleJuice();

            order.Size = Size.Large;
            Assert.Equal(order.Size, Size.Large);
            order.Size = Size.Medium;
            Assert.Equal(order.Size, Size.Medium);
            order.Size = Size.Small;
            Assert.Equal(order.Size, Size.Small);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice order = new AretinoAppleJuice();

            order.Size = size;
            Assert.Equal(order.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice order = new AretinoAppleJuice();

            order.Size = size;
            Assert.Equal(order.Calories, cal);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice order = new AretinoAppleJuice();

            order.Ice = includeIce;
            if (includeIce) Assert.Contains(order.SpecialInstructions, "Add ice");
            else Assert.Empty(order.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice order = new AretinoAppleJuice();

            order.Size = size;
            Assert.Equal(order.ToString, name);
        }
    }
}