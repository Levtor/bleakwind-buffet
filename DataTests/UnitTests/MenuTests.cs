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
using System.Linq;
using System.Collections.Specialized;

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
            for (int i = 0; i < 12; i += 3)
            {
                check = list[i] as Side;
                Assert.Equal(Size.Small, check.Size);
                check = list[i + 1] as Side;
                Assert.Equal(Size.Medium, check.Size);
                check = list[i + 2] as Side;
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
            for (int i = 12; i < 30; i += 3)
            {
                checkTo = (SodaFlavor)((i - 12) / 3);
                check = list[i] as SailorSoda;
                Assert.Equal(checkTo, check.Flavor);
                check = list[i + 1] as SailorSoda;
                Assert.Equal(checkTo, check.Flavor);
                check = list[i + 2] as SailorSoda;
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

        [Fact]
        public void NullInputsDontChangeList()
        {
            IEnumerable<IOrderItem> yield = Menu.FullMenu();

            var check = Menu.Search(yield, null);
            Assert.Equal(yield, check);

            check = Menu.FilterByCategory(yield, null);
            Assert.Equal(yield, check);

            check = Menu.FilterByCalories(yield, null, null);
            Assert.Equal(yield, check);

            check = Menu.FilterByPrice(yield, null, null);
            Assert.Equal(yield, check);
        }

        [Fact]
        public void SearchWorks()
        {
            var all = Menu.FullMenu();
            var list = new List<IOrderItem>();
            foreach (IOrderItem i in all)
            {
                if (i is AretinoAppleJuice) list.Add(i);
            }
            Assert.Equal(list, Menu.Search(all, "aretino"));

            Assert.Empty(Menu.Search(Menu.FullMenu(), "zzzzzzzzzz"));

            Assert.Equal(all, Menu.Search(all, " "));
        }

        [Fact]
        public void FiltersByCategory()
        {
            var all = Menu.FullMenu();
            Assert.Equal(all, Menu.FilterByCategory(all, new List<string>()));
            Assert.Equal(all, Menu.FilterByCategory(all, new List<string>() { "Drinks", "Entrees", "Sides" }));

            var list = new List<IOrderItem>();
            foreach (IOrderItem i in all)
            {
                if (i is Drink) list.Add(i);
            }
            Assert.Equal(list, Menu.FilterByCategory(all, new List<string>() { "Drinks" }));

            list.Clear();
            foreach (IOrderItem i in all)
            {
                if (i is Entree || i is Side) list.Add(i);
            }
            Assert.Equal(list, Menu.FilterByCategory(all, new List<string>() { "Entrees", "Sides" }));

        }

        [Fact]
        public void FiltersByCalories()
        {
            var all = Menu.FullMenu();
            var l9 = new List<IOrderItem>();
            var m300 = new List<IOrderItem>();
            var e10 = new List<IOrderItem>();
            foreach(IOrderItem i in all)
            {
                if (i.Calories == 10) e10.Add(i);
                else if (i.Calories > 300) m300.Add(i);
                else if (i.Calories < 9) l9.Add(i);
            }
            Assert.Equal(l9, Menu.FilterByCalories(all, 9, null));
            Assert.Equal(m300, Menu.FilterByCalories(all, null, 300));
            Assert.Equal(e10, Menu.FilterByCalories(all, 10, 10));
            Assert.Equal(new List<IOrderItem>(), Menu.FilterByCalories(all, 9, 300));
            Assert.Equal(all, Menu.FilterByCalories(all, 2000, 0));
        }

        [Fact]
        public void FiltersByPrice()
        {
            var all = Menu.FullMenu();
            var l100 = new List<IOrderItem>();
            var m750 = new List<IOrderItem>();
            var e201 = new List<IOrderItem>();
            foreach (IOrderItem i in all)
            {
                if (i.Price == 2.01) e201.Add(i);
                else if (i.Price > 7.50) m750.Add(i);
                else if (i.Price < 1) l100.Add(i);
            }
            Assert.Equal(l100, Menu.FilterByPrice(all, 1, null));
            Assert.Equal(m750, Menu.FilterByPrice(all, null, 7.5));
            Assert.Equal(e201, Menu.FilterByPrice(all, 2.01, 2.01));
            Assert.Equal(new List<IOrderItem>(), Menu.FilterByPrice(all, 1, 7.5));
            Assert.Equal(all, Menu.FilterByPrice(all, 100, 0));
        }
    }
}
