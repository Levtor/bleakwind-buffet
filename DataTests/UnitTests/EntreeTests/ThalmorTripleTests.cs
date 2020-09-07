/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.True(order.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.True(order.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.True(order.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.True(order.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.True(order.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.True(order.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.True(order.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.True(order.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.True(order.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.True(order.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple order = new ThalmorTriple();

            order.Bun = false;
            Assert.False(order.Bun);
            order.Bun = true;
            Assert.True(order.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple order = new ThalmorTriple();

            order.Ketchup = false;
            Assert.False(order.Ketchup);
            order.Ketchup = true;
            Assert.True(order.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple order = new ThalmorTriple();

            order.Mustard = false;
            Assert.False(order.Mustard);
            order.Mustard = true;
            Assert.True(order.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple order = new ThalmorTriple();

            order.Pickle = false;
            Assert.False(order.Pickle);
            order.Pickle = true;
            Assert.True(order.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple order = new ThalmorTriple();

            order.Cheese = false;
            Assert.False(order.Cheese);
            order.Cheese = true;
            Assert.True(order.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple order = new ThalmorTriple();

            order.Tomato = false;
            Assert.False(order.Tomato);
            order.Tomato = true;
            Assert.True(order.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple order = new ThalmorTriple();

            order.Lettuce = false;
            Assert.False(order.Lettuce);
            order.Cheese = true;
            Assert.True(order.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple order = new ThalmorTriple();

            order.Mayo = false;
            Assert.False(order.Mayo);
            order.Mayo = true;
            Assert.True(order.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple order = new ThalmorTriple();

            order.Bacon = false;
            Assert.False(order.Bacon);
            order.Bacon = true;
            Assert.True(order.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple order = new ThalmorTriple();

            order.Egg = false;
            Assert.False(order.Egg);
            order.Egg = true;
            Assert.True(order.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.Equal(order.Price, 8.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.Equal(order.Calories, 943);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            ThalmorTriple order = new ThalmorTriple();

            order.Bun = includeBun;
            order.Ketchup = includeKetchup;
            order.Mustard = includeMustard;
            order.Pickle = includePickle;
            order.Cheese = includeCheese;
            order.Tomato = includeTomato;
            order.Lettuce = includeLettuce;
            order.Mayo = includeMayo;
            order.Bacon = includeBacon;
            order.Egg = includeEgg;
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
            if (includeBacon)
            {
                Assert.Contains(order.SpecialInstructions, "Hold bacon");
                empty = false;
            }
            if (includeEgg)
            {
                Assert.Contains(order.SpecialInstructions, "Hold egg");
                empty = false;
            }
            if (empty) Assert.Empty(order.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.Equal(order.ToString(), "Thalmor Triple");
        }
    }
}