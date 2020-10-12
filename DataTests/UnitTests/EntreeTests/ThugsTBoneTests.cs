/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            var order = new ThugsTBone();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            ThugsTBone order = new ThugsTBone();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            ThugsTBone order = new ThugsTBone();

            Assert.IsAssignableFrom<Entree>(order);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone order = new ThugsTBone();

            Assert.Equal(6.44, order.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone order = new ThugsTBone();

            Assert.Equal(982, (decimal)order.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsTBone order = new ThugsTBone();

            Assert.Empty(order.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsTBone order = new ThugsTBone();

            Assert.Equal("Thugs T-Bone", order.ToString());
        }
    }
}