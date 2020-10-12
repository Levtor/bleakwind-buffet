/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            var order = new ThalmorTriple();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }
        
        [Fact]
        public void BunChangeNotifiesPropertyChanged()
        {
            var order = new ThalmorTriple();

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
            var order = new ThalmorTriple();

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
            var order = new ThalmorTriple();

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
            var order = new ThalmorTriple();

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
            var order = new ThalmorTriple();

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
            var order = new ThalmorTriple();

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
            var order = new ThalmorTriple();

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
            var order = new ThalmorTriple();

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
        public void BaconChangeNotifiesPropertyChanged()
        {
            var order = new ThalmorTriple();

            Assert.PropertyChanged(order, "Bacon", () =>
            {
                order.Bacon = false;
            });

            Assert.PropertyChanged(order, "Bacon", () =>
            {
                order.Bacon = true;
            });
        }

        [Fact]
        public void EggChangeNotifiesPropertyChanged()
        {
            var order = new ThalmorTriple();

            Assert.PropertyChanged(order, "Egg", () =>
            {
                order.Egg = false;
            });

            Assert.PropertyChanged(order, "Egg", () =>
            {
                order.Egg = true;
            });
        }

        [Fact]
        public void SpecialInstructionsChangeNotifiesPropertyChanged()
        {
            var order = new ThalmorTriple();

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

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Bacon = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Bacon = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Egg = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Egg = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.IsAssignableFrom<Entree>(order);
        }

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

            Assert.Equal(8.32, order.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple order = new ThalmorTriple();

            Assert.Equal(943, (decimal)order.Calories);
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

            Assert.Equal("Thalmor Triple", order.ToString());
        }
    }
}