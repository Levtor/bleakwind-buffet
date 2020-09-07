/*
 * Author: Joseph Hathaway
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            WarriorWater order = new WarriorWater();

            Assert.True(order.Ice);
        }

        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater order = new WarriorWater();

            Assert.False(order.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            WarriorWater order = new WarriorWater();

            Assert.Equal(order.Size, Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            WarriorWater order = new WarriorWater();

            order.Ice = false;
            Assert.False(order.Ice);
            order.Ice = true;
            Assert.True(order.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater order = new WarriorWater();

            order.Size = Size.Large;
            Assert.Equal(order.Size, Size.Large);
            order.Size = Size.Medium;
            Assert.Equal(order.Size, Size.Medium);
            order.Size = Size.Small;
            Assert.Equal(order.Size, Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            WarriorWater order = new WarriorWater();

            order.Lemon = true;
            Assert.True(order.Lemon);
            order.Lemon = false;
            Assert.False(order.Lemon);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater order = new WarriorWater();

            order.Size = size;
            Assert.Equal(order.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater order = new WarriorWater();

            order.Size = size;
            Assert.Equal(order.Calories, cal);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater order = new WarriorWater();

            order.Ice = includeIce;
            order.Lemon = includeLemon;
            if (!includeIce) Assert.Contains(order.SpecialInstructions, "Hold ice");
            if (includeLemon) Assert.Contains(order.SpecialInstructions, "Add lemon");
            if (includeIce && !includeLemon) Assert.Empty(order.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(Size size, string name)
        {
            WarriorWater order = new WarriorWater();

            order.Size = size;
            Assert.Equal(order.ToString, name);
        }
    }
}
