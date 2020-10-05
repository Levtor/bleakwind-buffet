/*
 * Author: Zachery Brunner
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void BunChangeNotifiesPropertyChanged()
        {
            var order = new DoubleDraugr();

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
            var order = new DoubleDraugr();

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
            var order = new DoubleDraugr();

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
            var order = new DoubleDraugr();

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
            var order = new DoubleDraugr();

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
        public void TomatoChangeNotifiesPropertyChanged()
        {
            var order = new DoubleDraugr();

            Assert.PropertyChanged(order, "Tomato", () =>
            {
                order.Tomato = false;
            });

            Assert.PropertyChanged(order, "Tomato", () =>
            {
                order.Tomato = true;
            });
        }

        [Fact]
        public void LettuceChangeNotifiesPropertyChanged()
        {
            var order = new DoubleDraugr();

            Assert.PropertyChanged(order, "Lettuce", () =>
            {
                order.Lettuce = false;
            });

            Assert.PropertyChanged(order, "Lettuce", () =>
            {
                order.Lettuce = true;
            });
        }

        [Fact]
        public void MayoChangeNotifiesPropertyChanged()
        {
            var order = new DoubleDraugr();

            Assert.PropertyChanged(order, "Mayo", () =>
            {
                order.Mayo = false;
            });

            Assert.PropertyChanged(order, "Mayo", () =>
            {
                order.Mayo = true;
            });
        }

        [Fact]
        public void SpecialInstructionsChangeNotifiesPropertyChanged()
        {
            var order = new DoubleDraugr();

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

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Tomato = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Tomato = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Lettuce = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Lettuce = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Mayo = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Mayo = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.IsAssignableFrom<Entree>(order);
        }

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
            order.Lettuce = true;
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

            Assert.Equal(7.32, order.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.Equal(843, (decimal)order.Calories);
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
            if (empty) Assert.Empty(order.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr order = new DoubleDraugr();

            Assert.Equal("Double Draugr", order.ToString());
        }
    }
}