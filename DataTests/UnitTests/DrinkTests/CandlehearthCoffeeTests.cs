/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            var order = new CandlehearthCoffee();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void SizeChangeNotifiesPropertyChanged()
        {
            var order = new CandlehearthCoffee();

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
            var order = new CandlehearthCoffee();

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
            var order = new CandlehearthCoffee();

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
            var order = new CandlehearthCoffee();

            Assert.PropertyChanged(order, "Ice", () =>
            {
                order.Ice = true;
            });

            Assert.PropertyChanged(order, "Ice", () =>
            {
                order.Ice = false;
            });
        }

        [Fact]
        public void RoomForCreamChangeNotifiesPropertyChanged()
        {
            var order = new CandlehearthCoffee();

            Assert.PropertyChanged(order, "RoomForCream", () =>
            {
                order.RoomForCream = true;
            });

            Assert.PropertyChanged(order, "RoomForCream", () =>
            {
                order.RoomForCream = false;
            });
        }

        [Fact]
        public void DecafChangeNotifiesPropertyChanged()
        {
            var order = new CandlehearthCoffee();

            Assert.PropertyChanged(order, "Decaf", () =>
            {
                order.Decaf = true;
            });

            Assert.PropertyChanged(order, "Decaf", () =>
            {
                order.Decaf = false;
            });
        }

        [Fact]
        public void SpecialInstructionsChangeNotifiesPropertyChanged()
        {
            var order = new CandlehearthCoffee();

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Ice = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Ice = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.RoomForCream = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.RoomForCream = false;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            CandlehearthCoffee order = new CandlehearthCoffee();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee order = new CandlehearthCoffee();

            Assert.IsAssignableFrom<Drink>(order);
        }

        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            Assert.False(order.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            Assert.False(order.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            Assert.False(order.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            Assert.Equal(Size.Small, order.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            order.Ice = true;
            Assert.True(order.Ice);
            order.Ice = false;
            Assert.False(order.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            order.Decaf = true;
            Assert.True(order.Decaf);
            order.Decaf = false;
            Assert.False(order.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            order.RoomForCream = true;
            Assert.True(order.RoomForCream);
            order.RoomForCream = false;
            Assert.False(order.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            order.Size = Size.Large;
            Assert.Equal(Size.Large, order.Size);
            order.Size = Size.Medium;
            Assert.Equal(Size.Medium, order.Size);
            order.Size = Size.Small;
            Assert.Equal(Size.Small, order.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            order.Size = size;
            Assert.Equal(order.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            order.Size = size;
            Assert.Equal(order.Calories, cal);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            order.Ice = includeIce;
            order.RoomForCream = includeCream;
            if (includeIce) Assert.Contains("Add ice", order.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", order.SpecialInstructions);
            if (!includeIce && !includeCream) Assert.Empty(order.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee order = new CandlehearthCoffee();
            
            order.Size = size;
            order.Decaf = decaf;
            Assert.Equal(order.ToString(), name);
        }

        [Fact]
        public void HasCorrectDescription()
        {
            string str = "Fair trade, fresh ground dark roast coffee.";
            var order = new CandlehearthCoffee();
            Assert.Equal(str, order.Description);
        }
    }
}
