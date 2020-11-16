/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            var order = new PhillyPoacher();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }
        
        [Fact]
        public void SirloinChangeNotifiesPropertyChanged()
        {
            var order = new PhillyPoacher();

            Assert.PropertyChanged(order, "Sirloin", () =>
            {
                order.Sirloin = false;
            });

            Assert.PropertyChanged(order, "Sirloin", () =>
            {
                order.Sirloin = true;
            });
        }

        [Fact]
        public void OnionChangeNotifiesPropertyChanged()
        {
            var order = new PhillyPoacher();

            Assert.PropertyChanged(order, "Onion", () =>
            {
                order.Onion = false;
            });

            Assert.PropertyChanged(order, "Onion", () =>
            {
                order.Onion = true;
            });
        }

        [Fact]
        public void RollChangeNotifiesPropertyChanged()
        {
            var order = new PhillyPoacher();

            Assert.PropertyChanged(order, "Roll", () =>
            {
                order.Roll = false;
            });

            Assert.PropertyChanged(order, "Roll", () =>
            {
                order.Roll = true;
            });
        }

        [Fact]
        public void SpecialInstructionsChangeNotifiesPropertyChanged()
        {
            var order = new PhillyPoacher();

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Sirloin = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Sirloin = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Onion = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Onion = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Roll = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Roll = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            PhillyPoacher order = new PhillyPoacher();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            PhillyPoacher order = new PhillyPoacher();

            Assert.IsAssignableFrom<Entree>(order);
        }

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

            Assert.Equal(7.23, order.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher order = new PhillyPoacher();

            Assert.Equal(784, (decimal)order.Calories);
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

            Assert.Equal("Philly Poacher", order.ToString());
        }

        [Fact]
        public void HasCorrectDescription()
        {
            string str = "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";
            var order = new PhillyPoacher();
            Assert.Equal(str, order.Description);
        }
    }
}