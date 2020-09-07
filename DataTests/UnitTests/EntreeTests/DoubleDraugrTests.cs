/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {   
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.True(order.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.True(order.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.True(order.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.True(order.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.True(order.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.True(order.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.True(order.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.True(order.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr order = new DoubleDraugr();

            order.Bun = false;
            Assert.False(order.Bun);
            order.Bun = true;
            Assert.True(order.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr order = new DoubleDraugr();

            order.Ketchup = false;
            Assert.False(order.Ketchup);
            order.Ketchup = true;
            Assert.True(order.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr order = new DoubleDraugr();

            order.Mustard = false;
            Assert.False(order.Mustard);
            order.Mustard = true;
            Assert.True(order.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr order = new DoubleDraugr();

            order.Pickle = false;
            Assert.False(order.Pickle);
            order.Pickle = true;
            Assert.True(order.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr order = new DoubleDraugr();

            order.Cheese = false;
            Assert.False(order.Cheese);
            order.Cheese = true;
            Assert.True(order.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr order = new DoubleDraugr();

            order.Tomato = false;
            Assert.False(order.Tomato);
            order.Tomato = true;
            Assert.True(order.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr order = new DoubleDraugr();

            order.Lettuce = false;
            Assert.False(order.Lettuce);
            order.Cheese = true;
            Assert.True(order.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr order = new DoubleDraugr();

            order.Mayo = false;
            Assert.False(order.Mayo);
            order.Mayo = true;
            Assert.True(order.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.Equal(order.Price, 7.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.Equal(order.Calories, 843);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr order = new DoubleDraugr();

            order.Bun = includeBun;
            order.Ketchup = includeKetchup;
            order.Mustard = includeMustard;
            order.Pickle = includePickle;
            order.Cheese = includeCheese;
            order.Tomato = includeTomato;
            order.Lettuce = includeLettuce;
            order.Mayo = includeMayo;
            bool empty = true;

            if (includeBun)
            {
                Assert.Contains(order.SpecialInstructions, "Hold bun");
                empty = false;
            }
            if (includeKetchup)
            {
                Assert.Contains(order.SpecialInstructions, "Hold ketchup");
                empty = false;
            }
            if (includeMustard)
            {
                Assert.Contains(order.SpecialInstructions, "Hold mustard");
                empty = false;
            }
            if (includePickle)
            {
                Assert.Contains(order.SpecialInstructions, "Hold pickle");
                empty = false;
            }
            if (includeCheese)
            {
                Assert.Contains(order.SpecialInstructions, "Hold cheese");
                empty = false;
            }
            if (includeTomato)
            {
                Assert.Contains(order.SpecialInstructions, "Hold tomato");
                empty = false;
            }
            if (includeLettuce)
            {
                Assert.Contains(order.SpecialInstructions, "Hold lettuce");
                empty = false;
            }
            if (includeMayo)
            {
                Assert.Contains(order.SpecialInstructions, "Hold Mayo");
                empty = false;
            }
            if (empty) Assert.Empty(order.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.Equal(order.ToString(), "Briarheart Burger");
        }
    }
}