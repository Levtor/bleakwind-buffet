/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            Assert.True(order.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            Assert.True(order.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            Assert.True(order.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            Assert.True(order.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            order.SausageLink = false;
            Assert.False(order.SausageLink);
            order.SausageLink = true;
            Assert.True(order.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            order.Egg = false;
            Assert.False(order.Egg);
            order.Egg = true;
            Assert.True(order.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            order.HashBrowns = false;
            Assert.False(order.HashBrowns);
            order.HashBrowns = true;
            Assert.True(order.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            order.Pancake = false;
            Assert.False(order.Pancake);
            order.Pancake = true;
            Assert.True(order.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            Assert.Equal(order.Price, 5.62);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            Assert.Equal((decimal)order.Calories, 602);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            order.SausageLink = includeSausage;
            order.Egg = includeEgg;
            order.HashBrowns = includeHashbrowns;
            order.Pancake = includePancake;
            bool empty = true;

            if (!includeSausage)
            {
                Assert.Contains("Hold sausage", order.SpecialInstructions);
                empty = false;
            }
            if (!includeEgg)
            {
                Assert.Contains("Hold eggs", order.SpecialInstructions);
                empty = false;
            }
            if (!includeHashbrowns)
            {
                Assert.Contains("Hold hash browns", order.SpecialInstructions);
                empty = false;
            }
            if (!includePancake)
            {
                Assert.Contains("Hold pancakes", order.SpecialInstructions);
                empty = false;
            }
            if (empty) Assert.Empty(order.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            Assert.Equal(order.ToString(), "Smokehouse Skeleton");
        }
    }
}