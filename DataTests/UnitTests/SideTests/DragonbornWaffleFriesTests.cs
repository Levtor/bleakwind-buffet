/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void SizeChangeNotifiesPropertyChanged()
        {
            var order = new DragonbornWaffleFries();

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
            var order = new DragonbornWaffleFries();

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
            var order = new DragonbornWaffleFries();

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
            DragonbornWaffleFries order = new DragonbornWaffleFries();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries order = new DragonbornWaffleFries();

            Assert.IsAssignableFrom<Side>(order);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries order = new DragonbornWaffleFries();

            Assert.Equal(Size.Small, order.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries order = new DragonbornWaffleFries();


        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries order = new DragonbornWaffleFries();

            order.Size = Size.Large;
            Assert.Equal(Size.Large, order.Size);
            order.Size = Size.Medium;
            Assert.Equal(Size.Medium, order.Size);
            order.Size = Size.Small;
            Assert.Equal(Size.Small, order.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries order = new DragonbornWaffleFries();

            order.Size = size;
            Assert.Equal(order.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries order = new DragonbornWaffleFries();

            order.Size = size;
            Assert.Equal(order.Calories, calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries order = new DragonbornWaffleFries();

            order.Size = size;
            Assert.Equal(order.ToString(), name);
        }
    }
}