/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void SizeChangeNotifiesPropertyChanged()
        {
            var order = new SailorSoda();

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
            var order = new SailorSoda();

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
            var order = new SailorSoda();

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
        public void FlavorChangeNotifiesPropertyChanged()
        {
            var order = new SailorSoda();

            Assert.PropertyChanged(order, "Flavor", () =>
            {
                order.Flavor = SodaFlavor.Blackberry;
            });

            Assert.PropertyChanged(order, "Flavor", () =>
            {
                order.Flavor = SodaFlavor.Cherry;
            });

            Assert.PropertyChanged(order, "Flavor", () =>
            {
                order.Flavor = SodaFlavor.Grapefruit;
            });

            Assert.PropertyChanged(order, "Flavor", () =>
            {
                order.Flavor = SodaFlavor.Lemon;
            });

            Assert.PropertyChanged(order, "Flavor", () =>
            {
                order.Flavor = SodaFlavor.Peach;
            });

            Assert.PropertyChanged(order, "Flavor", () =>
            {
                order.Flavor = SodaFlavor.Watermelon;
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
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SailorSoda order = new SailorSoda();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            SailorSoda order = new SailorSoda();

            Assert.IsAssignableFrom<Drink>(order);
        }

        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSoda order = new SailorSoda();

            Assert.True(order.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSoda order = new SailorSoda();

            Assert.Equal(Size.Small, order.Size);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSoda order = new SailorSoda();

            Assert.Equal(SodaFlavor.Cherry, order.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSoda order = new SailorSoda();

            order.Ice = false;
            Assert.False(order.Ice);
            order.Ice = true;
            Assert.True(order.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSoda order = new SailorSoda();

            order.Size = Size.Large;
            Assert.Equal(Size.Large, order.Size);
            order.Size = Size.Medium;
            Assert.Equal(Size.Medium, order.Size);
            order.Size = Size.Small;
            Assert.Equal(Size.Small, order.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSoda order = new SailorSoda();

            order.Flavor = SodaFlavor.Blackberry;
            Assert.Equal(SodaFlavor.Blackberry, order.Flavor);
            order.Flavor = SodaFlavor.Cherry;
            Assert.Equal(SodaFlavor.Cherry, order.Flavor);
            order.Flavor = SodaFlavor.Grapefruit;
            Assert.Equal(SodaFlavor.Grapefruit, order.Flavor);
            order.Flavor = SodaFlavor.Lemon;
            Assert.Equal(SodaFlavor.Lemon, order.Flavor);
            order.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, order.Flavor);
            order.Flavor = SodaFlavor.Watermelon;
            Assert.Equal(SodaFlavor.Watermelon, order.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSoda order = new SailorSoda();

            order.Size = size;
            Assert.Equal(order.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSoda order = new SailorSoda();

            order.Size = size;
            Assert.Equal(order.Calories, cal);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSoda order = new SailorSoda();

            order.Ice = includeIce;
            if(!includeIce) Assert.Contains("Hold ice", order.SpecialInstructions);
            else Assert.Empty(order.SpecialInstructions);
        }
        
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSoda order = new SailorSoda();

            order.Flavor = flavor;
            order.Size = size;
            Assert.Equal(order.ToString(), name);
        }
    }
}
