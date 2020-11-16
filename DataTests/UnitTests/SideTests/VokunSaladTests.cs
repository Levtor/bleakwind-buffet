/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            var order = new VokunSalad();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void SizeChangeNotifiesPropertyChanged()
        {
            var order = new VokunSalad();

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
            var order = new VokunSalad();

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
            var order = new VokunSalad();

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
            VokunSalad order = new VokunSalad();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad order = new VokunSalad();

            Assert.IsAssignableFrom<Side>(order);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad order = new VokunSalad();

            Assert.Equal(Size.Small, order.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad order = new VokunSalad();

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
            VokunSalad order = new VokunSalad();

            Assert.Empty(order.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad order = new VokunSalad();

            order.Size = size;
            Assert.Equal(order.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad order = new VokunSalad();

            order.Size = size;
            Assert.Equal(order.Calories, calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad order = new VokunSalad();

            order.Size = size;
            Assert.Equal(order.ToString(), name);
        }

        [Fact]
        public void HasCorrectDescription()
        {
            string str = "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.";
            var order = new VokunSalad();
            Assert.Equal(str, order.Description);
        }
    }
}