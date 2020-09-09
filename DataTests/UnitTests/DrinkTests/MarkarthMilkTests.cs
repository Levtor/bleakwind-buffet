/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk order = new MarkarthMilk();

            Assert.False(order.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk order = new MarkarthMilk();

            Assert.Equal(order.Size, Size.Small);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk order = new MarkarthMilk();

            order.Ice = true;
            Assert.True(order.Ice);
            order.Ice = false;
            Assert.False(order.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk order = new MarkarthMilk();

            order.Size = Size.Large;
            Assert.Equal(order.Size, Size.Large);
            order.Size = Size.Medium;
            Assert.Equal(order.Size, Size.Medium);
            order.Size = Size.Small;
            Assert.Equal(order.Size, Size.Small);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk order = new MarkarthMilk();

            order.Size = size;
            Assert.Equal(order.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk order = new MarkarthMilk();

            order.Size = size;
            Assert.Equal(order.Calories, cal);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk order = new MarkarthMilk();

            order.Ice = includeIce;
            if (includeIce) Assert.Contains("Add ice", order.SpecialInstructions);
            else Assert.Empty(order.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk order = new MarkarthMilk();

            order.Size = size;
            Assert.Equal(order.ToString(), name);
        }
    }
}