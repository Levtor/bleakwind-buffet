/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(order);
        }

        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            Assert.True(order.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            Assert.True(order.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            Assert.True(order.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            Assert.True(order.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            order.Broccoli = false;
            Assert.False(order.Broccoli);
            order.Broccoli = true;
            Assert.True(order.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            order.Mushrooms = false;
            Assert.False(order.Mushrooms);
            order.Mushrooms = true;
            Assert.True(order.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            order.Tomato = false;
            Assert.False(order.Tomato);
            order.Tomato = true;
            Assert.True(order.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            order.Cheddar = false;
            Assert.False(order.Cheddar);
            order.Cheddar = true;
            Assert.True(order.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            Assert.Equal(4.57, order.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            Assert.Equal(404, (decimal)order.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            order.Broccoli = includeBroccoli;
            order.Mushrooms = includeMushrooms;
            order.Tomato = includeTomato;
            order.Cheddar = includeCheddar;
            bool empty = true;

            if (!includeBroccoli)
            {
                Assert.Contains("Hold broccoli", order.SpecialInstructions);
                empty = false;
            }
            if (!includeMushrooms)
            {
                Assert.Contains("Hold mushrooms", order.SpecialInstructions);
                empty = false;
            }
            if (!includeTomato)
            {
                Assert.Contains("Hold tomato", order.SpecialInstructions);
                empty = false;
            }
            if (!includeCheddar)
            {
                Assert.Contains("Hold cheddar", order.SpecialInstructions);
                empty = false;
            }
            if (empty) Assert.Empty(order.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmelette order = new GardenOrcOmelette();

            Assert.Equal("Garden Orc Omelette", order.ToString());
        }
    }
}