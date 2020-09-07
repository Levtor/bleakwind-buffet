/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using System.Linq.Expressions;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.True(order.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.True(order.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.True(order.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.True(order.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.True(order.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger order = new BriarheartBurger();

            order.Bun = false;
            Assert.False(order.Bun);
            order.Bun = true;
            Assert.True(order.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger order = new BriarheartBurger();

            order.Ketchup = false;
            Assert.False(order.Ketchup);
            order.Ketchup = true;
            Assert.True(order.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger order = new BriarheartBurger();

            order.Mustard = false;
            Assert.False(order.Mustard);
            order.Mustard = true;
            Assert.True(order.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger order = new BriarheartBurger();

            order.Pickle = false;
            Assert.False(order.Pickle);
            order.Pickle = true;
            Assert.True(order.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger order = new BriarheartBurger();

            order.Cheese = false;
            Assert.False(order.Cheese);
            order.Cheese = true;
            Assert.True(order.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.Equal(order.Price, 6.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.Equal(order.Calories, 743);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese)
        {
            BriarheartBurger order = new BriarheartBurger();

            order.Bun = includeBun;
            order.Ketchup = includeKetchup;
            order.Mustard = includeMustard;
            order.Pickle = includePickle;
            order.Cheese = includeCheese;
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
            if (empty) Assert.Empty(order.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.Equal(order.ToString(), "Briarheart Burger");
        }
    }
}