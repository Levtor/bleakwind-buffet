/*
 * Author: Joseph Hathaway
 * Class: MenuTests.cs
 * Purpose: Test the Menu.cs class in the Data library
 */

using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Xunit;
using BleakwindBuffet.Data;
using System.Resources;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void EntreesShouldYieldAllEntrees()
        {
            IEnumerable<IOrderItem> yield = Menu.Entrees();
            List<IOrderItem> list = yield as List<IOrderItem>;
            Assert.Collection(list,
                    item => Assert.IsType<BriarheartBurger>(item),
                    item => Assert.IsType<DoubleDraugr>(item),
                    item => Assert.IsType<GardenOrcOmelette>(item),
                    item => Assert.IsType<PhillyPoacher>(item),
                    item => Assert.IsType<SmokehouseSkeleton>(item),
                    item => Assert.IsType<ThalmorTriple>(item),
                    item => Assert.IsType<ThugsTBone>(item)
                );
        }

        [Fact]
        public void SidesShouldYieldAllSides()
        {
            IEnumerable<IOrderItem> yield = Menu.Sides();
            List<IOrderItem> list = yield as List<IOrderItem>;
            Assert.Collection(list,
                    item => Assert.IsType<DragonbornWaffleFries>(item),
                    item => Assert.IsType<DragonbornWaffleFries>(item),
                    item => Assert.IsType<DragonbornWaffleFries>(item),

                    item => Assert.IsType<FriedMiraak>(item),
                    item => Assert.IsType<FriedMiraak>(item),
                    item => Assert.IsType<FriedMiraak>(item),

                    item => Assert.IsType<MadOtarGrits>(item),
                    item => Assert.IsType<MadOtarGrits>(item),
                    item => Assert.IsType<MadOtarGrits>(item),

                    item => Assert.IsType<VokunSalad>(item),
                    item => Assert.IsType<VokunSalad>(item),
                    item => Assert.IsType<VokunSalad>(item)
                );
        }

        [Fact]
        public void DrinksShouldYieldAllDrinks()
        {
            IEnumerable<IOrderItem> yield = Menu.Drinks();
            List<IOrderItem> list = yield as List<IOrderItem>;
            Assert.Collection(list,
                    item => Assert.IsType<AretinoAppleJuice>(item),
                    item => Assert.IsType<AretinoAppleJuice>(item),
                    item => Assert.IsType<AretinoAppleJuice>(item),

                    item => Assert.IsType<CandlehearthCoffee>(item),
                    item => Assert.IsType<CandlehearthCoffee>(item),
                    item => Assert.IsType<CandlehearthCoffee>(item),

                    item => Assert.IsType<MarkarthMilk>(item),
                    item => Assert.IsType<MarkarthMilk>(item),
                    item => Assert.IsType<MarkarthMilk>(item),

                    item => Assert.IsType<WarriorWater>(item),
                    item => Assert.IsType<WarriorWater>(item),
                    item => Assert.IsType<WarriorWater>(item),

                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item)
                );
        }

        [Fact]
        public void SidesYieldsProperSizes()
        {
            IEnumerable<IOrderItem> yield = Menu.Sides();
            List<IOrderItem> list = yield as List<IOrderItem>;
            Side check;
            for (int i=0; i<12; i+=3)
            {
                check = list[i] as Side;
                Assert.Equal(Size.Small, check.Size);
                check = list[i+1] as Side;
                Assert.Equal(Size.Medium, check.Size);
                check = list[i+2] as Side;
                Assert.Equal(Size.Large, check.Size);
            }
        }

        [Fact]
        public void DrinksYieldsProperSizes()
        {
            IEnumerable<IOrderItem> yield = Menu.Drinks();
            List<IOrderItem> list = yield as List<IOrderItem>;
            Drink check;
            for (int i = 0; i < 30; i += 3)
            {
                check = list[i] as Drink;
                Assert.Equal(Size.Small, check.Size);
                check = list[i + 1] as Drink;
                Assert.Equal(Size.Medium, check.Size);
                check = list[i + 2] as Drink;
                Assert.Equal(Size.Large, check.Size);
            }
        }

        [Fact]
        public void DrinksYieldsProperFlavors()
        {
            IEnumerable<IOrderItem> yield = Menu.Drinks();
            List<IOrderItem> list = yield as List<IOrderItem>;
            SailorSoda check;
            SodaFlavor checkTo;
            for (int i = 12; i < 30; i +=3)
            {
                checkTo = (SodaFlavor)((i - 12) / 3);
                check = list[i] as SailorSoda;
                Assert.Equal(checkTo, check.Flavor);
                check = list[i+1] as SailorSoda;
                Assert.Equal(checkTo, check.Flavor);
                check = list[i+2] as SailorSoda;
                Assert.Equal(checkTo, check.Flavor);
            }
        }

        [Fact]
        public void FullMenuShouldYieldAllItems()
        {
            IEnumerable<IOrderItem> yield = Menu.FullMenu();
            List<IOrderItem> list = yield as List<IOrderItem>;
            Assert.Collection(list,
                    item => Assert.IsType<BriarheartBurger>(item),
                    item => Assert.IsType<DoubleDraugr>(item),
                    item => Assert.IsType<GardenOrcOmelette>(item),
                    item => Assert.IsType<PhillyPoacher>(item),
                    item => Assert.IsType<SmokehouseSkeleton>(item),
                    item => Assert.IsType<ThalmorTriple>(item),
                    item => Assert.IsType<ThugsTBone>(item),


                    item => Assert.IsType<DragonbornWaffleFries>(item),
                    item => Assert.IsType<DragonbornWaffleFries>(item),
                    item => Assert.IsType<DragonbornWaffleFries>(item),

                    item => Assert.IsType<FriedMiraak>(item),
                    item => Assert.IsType<FriedMiraak>(item),
                    item => Assert.IsType<FriedMiraak>(item),

                    item => Assert.IsType<MadOtarGrits>(item),
                    item => Assert.IsType<MadOtarGrits>(item),
                    item => Assert.IsType<MadOtarGrits>(item),

                    item => Assert.IsType<VokunSalad>(item),
                    item => Assert.IsType<VokunSalad>(item),
                    item => Assert.IsType<VokunSalad>(item),


                    item => Assert.IsType<AretinoAppleJuice>(item),
                    item => Assert.IsType<AretinoAppleJuice>(item),
                    item => Assert.IsType<AretinoAppleJuice>(item),

                    item => Assert.IsType<CandlehearthCoffee>(item),
                    item => Assert.IsType<CandlehearthCoffee>(item),
                    item => Assert.IsType<CandlehearthCoffee>(item),

                    item => Assert.IsType<MarkarthMilk>(item),
                    item => Assert.IsType<MarkarthMilk>(item),
                    item => Assert.IsType<MarkarthMilk>(item),

                    item => Assert.IsType<WarriorWater>(item),
                    item => Assert.IsType<WarriorWater>(item),
                    item => Assert.IsType<WarriorWater>(item),

                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item),
                    item => Assert.IsType<SailorSoda>(item)
                );
        }

        [Fact]
        public void FullMenuYieldsProperSizes()
        {
            IEnumerable<IOrderItem> yield = Menu.FullMenu();
            List<IOrderItem> list = yield as List<IOrderItem>;
            Side check1;
            for (int i = 7; i < 19; i += 3)
            {
                check1 = list[i] as Side;
                Assert.Equal(Size.Small, check1.Size);
                check1 = list[i + 1] as Side;
                Assert.Equal(Size.Medium, check1.Size);
                check1 = list[i + 2] as Side;
                Assert.Equal(Size.Large, check1.Size);
            }
            Drink check2;
            for (int i = 19; i < 49; i += 3)
            {
                check2 = list[i] as Drink;
                Assert.Equal(Size.Small, check2.Size);
                check2 = list[i + 1] as Drink;
                Assert.Equal(Size.Medium, check2.Size);
                check2 = list[i + 2] as Drink;
                Assert.Equal(Size.Large, check2.Size);
            }
        }

        [Fact]
        public void FullMenuYieldsProperFlavors()
        {
            IEnumerable<IOrderItem> yield = Menu.FullMenu();
            List<IOrderItem> list = yield as List<IOrderItem>;
            SailorSoda check;
            SodaFlavor checkTo;
            for (int i = 31; i < 49; i += 3)
            {
                checkTo = (SodaFlavor)((i - 31) / 3);
                check = list[i] as SailorSoda;
                Assert.Equal(checkTo, check.Flavor);
                check = list[i + 1] as SailorSoda;
                Assert.Equal(checkTo, check.Flavor);
                check = list[i + 2] as SailorSoda;
                Assert.Equal(checkTo, check.Flavor);
            }
        }
    }
}
