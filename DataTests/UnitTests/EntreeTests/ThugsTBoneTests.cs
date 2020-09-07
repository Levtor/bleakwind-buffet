/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsTBone order = new ThugsTBone();

            Assert.Equal(order.Price, 6.44);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsTBone order = new ThugsTBone();

            Assert.Equal(order.Calories, 982);
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

            Assert.Equal(order.ToString(), "Thugs T-Bone");
        }
    }
}