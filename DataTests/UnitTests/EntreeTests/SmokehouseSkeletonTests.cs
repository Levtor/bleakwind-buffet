/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            var order = new SmokehouseSkeleton();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }
        
        [Fact]
        public void SausageLinkChangeNotifiesPropertyChanged()
        {
            var order = new SmokehouseSkeleton();

            Assert.PropertyChanged(order, "SausageLink", () =>
            {
                order.SausageLink = false;
            });

            Assert.PropertyChanged(order, "SausageLink", () =>
            {
                order.SausageLink = true;
            });
        }

        [Fact]
        public void EggChangeNotifiesPropertyChanged()
        {
            var order = new SmokehouseSkeleton();

            Assert.PropertyChanged(order, "Egg", () =>
            {
                order.Egg = false;
            });

            Assert.PropertyChanged(order, "Egg", () =>
            {
                order.Egg = true;
            });
        }

        [Fact]
        public void HashBrownsChangeNotifiesPropertyChanged()
        {
            var order = new SmokehouseSkeleton();

            Assert.PropertyChanged(order, "HashBrowns", () =>
            {
                order.HashBrowns = false;
            });

            Assert.PropertyChanged(order, "HashBrowns", () =>
            {
                order.HashBrowns = true;
            });
        }

        [Fact]
        public void PancakeChangeNotifiesPropertyChanged()
        {
            var order = new SmokehouseSkeleton();

            Assert.PropertyChanged(order, "Pancake", () =>
            {
                order.Pancake = false;
            });

            Assert.PropertyChanged(order, "Pancake", () =>
            {
                order.Pancake = true;
            });
        }

        [Fact]
        public void SpecialInstructionsChangeNotifiesPropertyChanged()
        {
            var order = new SmokehouseSkeleton();

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.SausageLink = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.SausageLink = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Egg = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Egg = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.HashBrowns = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.HashBrowns = true;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Pancake = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Pancake = true;
            });
        }

        [Fact]
        public void ShouldBeAnIOrderItem()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void ShouldBeAnEntree()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            Assert.IsAssignableFrom<Entree>(order);
        }

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

            Assert.Equal(5.62, order.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton order = new SmokehouseSkeleton();

            Assert.Equal(602, (decimal)order.Calories);
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

            Assert.Equal("Smokehouse Skeleton", order.ToString());
        }
    }
}