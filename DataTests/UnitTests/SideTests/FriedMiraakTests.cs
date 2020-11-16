/*
 * Author: Zachery Brunner
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            var order = new FriedMiraak();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void SizeChangeNotifiesPropertyChanged()
        {
            var order = new FriedMiraak();

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
            var order = new FriedMiraak();

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
            var order = new FriedMiraak();

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
        public void ShouldBeAnIOrderItem()
        {
            FriedMiraak order = new FriedMiraak();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak order = new FriedMiraak();

            Assert.IsAssignableFrom<Side>(order);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak order = new FriedMiraak();

            Assert.Equal(Size.Small, order.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak order = new FriedMiraak();

            order.Size = Size.Large;
            Assert.Equal(Size.Large, order.Size);
            order.Size = Size.Medium;
            Assert.Equal(Size.Medium, order.Size);
            order.Size = Size.Small;
            Assert.Equal(Size.Small, order.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak order = new FriedMiraak();

            Assert.Empty(order.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak order = new FriedMiraak();

            order.Size = size;
            Assert.Equal(order.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak order = new FriedMiraak();

            order.Size = size;
            Assert.Equal(order.Calories, calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak order = new FriedMiraak();

            order.Size = size;
            Assert.Equal(order.ToString(), name);
        }

        [Fact]
        public void HasCorrectDescription()
        {
            string str = "Perfectly prepared hash brown pancakes.";
            var order = new FriedMiraak();
            Assert.Equal(str, order.Description);
        }
    }
}