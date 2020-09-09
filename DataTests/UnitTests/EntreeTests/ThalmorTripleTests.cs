/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

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
            order.Lettuce = true;
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

            Assert.Equal((decimal)order.Calories, 943);
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

            if (!includeBun)
            {
                Assert.Contains("Hold bun", order.SpecialInstructions);
                empty = false;
            }
            if (!includeKetchup)
            {
                Assert.Contains("Hold ketchup", order.SpecialInstructions);
                empty = false;
            }
            if (!includeMustard)
            {
                Assert.Contains("Hold mustard", order.SpecialInstructions);
                empty = false;
            }
            if (!includePickle)
            {
                Assert.Contains("Hold pickle", order.SpecialInstructions);
                empty = false;
            }
            if (!includeCheese)
            {
                Assert.Contains("Hold cheese", order.SpecialInstructions);
                empty = false;
            }
            if (!includeTomato)
            {
                Assert.Contains("Hold tomato", order.SpecialInstructions);
                empty = false;
            }
            if (!includeLettuce)
            {
                Assert.Contains("Hold lettuce", order.SpecialInstructions);
                empty = false;
            }
            if (!includeMayo)
            {
                Assert.Contains("Hold mayo", order.SpecialInstructions);
                empty = false;
            }
            if (!includeBacon)
            {
                Assert.Contains("Hold bacon", order.SpecialInstructions);
                empty = false;
            }
            if (!includeEgg)
            {
                Assert.Contains("Hold egg", order.SpecialInstructions);
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