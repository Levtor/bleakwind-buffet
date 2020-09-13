/*
 * Author: Joseph Hathaway
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using System;

using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            WarriorWater order = new WarriorWater();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater order = new WarriorWater();

            Assert.IsAssignableFrom<Drink>(order);
        }

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

            Assert.Equal(Size.Small, order.Size);
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
            Assert.Equal(Size.Large, order.Size);
            order.Size = Size.Medium;
            Assert.Equal(Size.Medium, order.Size);
            order.Size = Size.Small;
            Assert.Equal(Size.Small, order.Size);
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
            if (!includeIce) Assert.Contains("Hold ice", order.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", order.SpecialInstructions);
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
            Assert.Equal(order.ToString(), name);
        }
    }
}
