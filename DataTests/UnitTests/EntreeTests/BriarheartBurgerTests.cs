/*
 * Author: Zachery Brunner
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Linq.Expressions;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        [Fact]
        public void BunChangeNotifiesPropertyChanged()
        {
            var order = new BriarheartBurger();

            Assert.PropertyChanged(order, "Bun", () =>
            {
                order.Bun = false;
            });

            Assert.PropertyChanged(order, "Bun", () =>
            {
                order.Bun = true;
            });
        }

        [Fact]
        public void KetchupChangeNotifiesPropertyChanged()
        {
            var order = new BriarheartBurger();

            Assert.PropertyChanged(order, "Ketchup", () =>
            {
                order.Ketchup = false;
            });

            Assert.PropertyChanged(order, "Ketchup", () =>
            {
                order.Ketchup = true;
            });
        }

        [Fact]
        public void MustardChangeNotifiesPropertyChanged()
        {
            var order = new BriarheartBurger();

            Assert.PropertyChanged(order, "Mustard", () =>
            {
                order.Mustard = false;
            });

            Assert.PropertyChanged(order, "Mustard", () =>
            {
                order.Mustard = true;
            });
        }

        [Fact]
        public void PickleChangeNotifiesPropertyChanged()
        {
            var order = new BriarheartBurger();

            Assert.PropertyChanged(order, "Pickle", () =>
            {
                order.Pickle = false;
            });

            Assert.PropertyChanged(order, "Pickle", () =>
            {
                order.Pickle = true;
            });
        }

        [Fact]
        public void CheeseChangeNotifiesPropertyChanged()
        {
            var order = new BriarheartBurger();

            Assert.PropertyChanged(order, "Cheese", () =>
            {
                order.Cheese = false;
            });

            Assert.PropertyChanged(order, "Cheese", () =>
            {
                order.Cheese = true;
            });
        }

        [Fact]
        public void SpecialInstructionsChangeNotifiesPropertyChanged()
        {
            var order = new BriarheartBurger();

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Bun = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Bun = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Ketchup = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Ketchup = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Mustard = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Mustard = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Pickle = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Pickle = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Cheese = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Cheese = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.IsAssignableFrom<Entree>(order);
        }

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

            Assert.Equal(6.32, order.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.Equal(743, (decimal)order.Calories);
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
            if (empty)
            {
                Assert.Empty(order.SpecialInstructions);
            }
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger order = new BriarheartBurger();

            Assert.Equal("Briarheart Burger", order.ToString());
        }
    }
}