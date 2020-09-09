/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits order = new MadOtarGrits();

            Assert.Equal(order.Size, Size.Small);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits order = new MadOtarGrits();

            order.Size = Size.Large;
            Assert.Equal(order.Size, Size.Large);
            order.Size = Size.Medium;
            Assert.Equal(order.Size, Size.Medium);
            order.Size = Size.Small;
            Assert.Equal(order.Size, Size.Small);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits order = new MadOtarGrits();

            Assert.Empty(order.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits order = new MadOtarGrits();

            order.Size = size;
            Assert.Equal(order.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits order = new MadOtarGrits();

            order.Size = size;
            Assert.Equal(order.Calories, calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits order = new MadOtarGrits();

            order.Size = size;
            Assert.Equal(order.ToString(), name);
        }
    }
}