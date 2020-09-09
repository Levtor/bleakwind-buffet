/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher order = new PhillyPoacher();

            Assert.True(order.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher order = new PhillyPoacher();

            Assert.True(order.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher order = new PhillyPoacher();

            Assert.True(order.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher order = new PhillyPoacher();

            order.Sirloin = false;
            Assert.False(order.Sirloin);
            order.Sirloin = true;
            Assert.True(order.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher order = new PhillyPoacher();

            order.Onion = false;
            Assert.False(order.Onion);
            order.Onion = true;
            Assert.True(order.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher order = new PhillyPoacher();

            order.Roll = false;
            Assert.False(order.Roll);
            order.Roll = true;
            Assert.True(order.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher order = new PhillyPoacher();

            Assert.Equal(order.Price, 7.23);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher order = new PhillyPoacher();

            Assert.Equal((decimal)order.Calories, 784);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher order = new PhillyPoacher();

            order.Sirloin = includeSirloin;
            order.Onion = includeOnion;
            order.Roll = includeRoll;
            bool empty = true;

            if (!includeSirloin)
            {
                Assert.Contains("Hold sirloin", order.SpecialInstructions);
                empty = false;
            }
            if (!includeOnion)
            {
                Assert.Contains("Hold onions", order.SpecialInstructions);
                empty = false;
            }
            if (!includeRoll)
            {
                Assert.Contains("Hold roll", order.SpecialInstructions);
                empty = false;
            }
            if (empty) Assert.Empty(order.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher order = new PhillyPoacher();

            Assert.Equal(order.ToString(), "Philly Poacher");
        }
    }
}