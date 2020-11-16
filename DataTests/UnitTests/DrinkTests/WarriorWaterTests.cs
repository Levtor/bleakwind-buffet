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
using Xunit.Sdk;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            var order = new WarriorWater();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }
        
        [Fact]
        public void SizeChangeNotifiesPropertyChanged()
        {
            var order = new WarriorWater();

            Assert.PropertyChanged(order, "Size", () =>
            {
                order.Size = Size.Large;
            });

            Assert.PropertyChanged(order, "Size", () =>
            {
                order.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Size", () =>
            {
                order.Size = Size.Small;
            });
        }

        [Fact]
        public void PriceChangeNotifiesPropertyChanged()
        {
            var order = new WarriorWater();

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Size = Size.Large;
            });

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Size = Size.Small;
            });
        }

        [Fact]
        public void CaloriesChangeNotifiesPropertyChanged()
        {
            var order = new WarriorWater();

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Size = Size.Large;
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Size = Size.Small;
            });
        }

        [Fact]
        public void IceChangeNotifiesPropertyChanged()
        {
            var order = new WarriorWater();

            Assert.PropertyChanged(order, "Ice", () =>
            {
                order.Ice = false;
            });

            Assert.PropertyChanged(order, "Ice", () =>
            {
                order.Ice = true;
            });
        }

        [Fact]
        public void LemonChangeNotifiesPropertyChanged()
        {
            var order = new WarriorWater();

            Assert.PropertyChanged(order, "Lemon", () =>
            {
                order.Lemon = true;
            });

            Assert.PropertyChanged(order, "Lemon", () =>
            {
                order.Lemon = false;
            });
        }

        [Fact]
        public void SpecialInstructionsChangeNotifiesPropertyChanged()
        {
            var order = new WarriorWater();

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Ice = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Ice = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Lemon = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Lemon = false;
            });
        }

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

        [Fact]
        public void HasCorrectDescription()
        {
            string str = "It’s water. Just water.";
            var order = new WarriorWater();
            Assert.Equal(str, order.Description);
        }
    }
}
