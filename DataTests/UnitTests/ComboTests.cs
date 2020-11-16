/*
 * Author: Joseph Hathaway
 * Class: ComboTests.cs
 * Purpose: Test the Combo.cs class in the Data library
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
using System.Transactions;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ImplementsIOrderItem()
        {
            var order = new Combo();

            Assert.IsAssignableFrom<IOrderItem>(order);
        }

        [Fact]
        public void PriceIsCorrect()
        {
            var order = new Combo();
            order.Drink = new AretinoAppleJuice();
            order.Side = new DragonbornWaffleFries();
            order.Entree = new BriarheartBurger();

            double sum = -1;
            sum += order.Drink.Price;
            sum += order.Side.Price;
            sum += order.Entree.Price;

            Assert.Equal(order.Price, sum);
        }

        [Fact]
        public void CaloriesIsCorrect()
        {
            var order = new Combo();
            order.Drink = new AretinoAppleJuice();
            order.Side = new DragonbornWaffleFries();
            order.Entree = new BriarheartBurger();

            uint sum = 0;
            sum += order.Drink.Calories;
            sum += order.Side.Calories;
            sum += order.Entree.Calories;

            Assert.Equal(order.Calories, sum);
        }

        [Fact]
        public void SpecialInstructionsAreCorrect()
        {
            var order = new Combo();
            order.Drink = new AretinoAppleJuice();
            order.Side = new DragonbornWaffleFries();
            order.Entree = new BriarheartBurger();

            (order.Drink as AretinoAppleJuice).Ice = true;
            (order.Entree as BriarheartBurger).Ketchup = false;
            (order.Entree as BriarheartBurger).Mustard = false;

            List<string> check = order.SpecialInstructions;

            Assert.Contains<string>(order.Drink.ToString(), check);
            foreach (string str in order.Drink.SpecialInstructions)
            {
                Assert.Contains<string>(str, check);
            }
            Assert.Contains<string>(order.Entree.ToString(), check);
            foreach (string str in order.Entree.SpecialInstructions)
            {
                Assert.Contains<string>(str, check);
            }
            Assert.Contains<string>(order.Side.ToString(), check);
            foreach (string str in order.Side.SpecialInstructions)
            {
                Assert.Contains<string>(str, check);
            }
        }

        [Fact]
        public void EntreeChangeNotifiesPropertyChanged()
        {
            var order = new Combo();
            order.Drink = new AretinoAppleJuice();
            order.Side = new DragonbornWaffleFries();
            order.Entree = new BriarheartBurger();

            Assert.PropertyChanged(order, "Entree", () =>
            {
                order.Entree = new SmokehouseSkeleton();
            });
        }

        [Fact]
        public void DrinkChangeNotifiesPropertyChanged()
        {
            var order = new Combo();
            order.Drink = new AretinoAppleJuice();
            order.Side = new DragonbornWaffleFries();
            order.Entree = new BriarheartBurger();

            Assert.PropertyChanged(order, "Drink", () =>
            {
                order.Drink = new SailorSoda();
            });
        }

        [Fact]
        public void SideChangeNotifiesPropertyChanged()
        {
            var order = new Combo();
            order.Drink = new AretinoAppleJuice();
            order.Side = new DragonbornWaffleFries();
            order.Entree = new BriarheartBurger();

            Assert.PropertyChanged(order, "Side", () =>
            {
                order.Side = new FriedMiraak();
            });
        }

        [Fact]
        public void PriceChangesNotifyPropertyChanged()
        {
            var order = new Combo();
            order.Drink = new AretinoAppleJuice();
            order.Side = new DragonbornWaffleFries();
            order.Entree = new BriarheartBurger();

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Drink.Size = Size.Large;
            });

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Drink.Size = Size.Small;
            });

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Side.Size = Size.Large;
            });

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Side.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Side.Size = Size.Small;
            });

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Drink = new SailorSoda();
            });

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Side = new FriedMiraak();
            });

            Assert.PropertyChanged(order, "Price", () =>
            {
                order.Entree = new SmokehouseSkeleton();
            });
        }

        [Fact]
        public void CaloriesChangesNotifyPropertyChanged()
        {
            var order = new Combo();
            order.Drink = new AretinoAppleJuice();
            order.Side = new DragonbornWaffleFries();
            order.Entree = new BriarheartBurger();

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Drink.Size = Size.Large;
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Drink.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Drink.Size = Size.Small;
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Side.Size = Size.Large;
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Side.Size = Size.Medium;
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Side.Size = Size.Small;
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Drink = new SailorSoda();
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Side = new FriedMiraak();
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Entree = new SmokehouseSkeleton();
            });
        }

        [Fact]
        public void SpecialInstructionsChangesNotifyPropertyChanged()
        {
            var order = new Combo();
            order.Drink = new AretinoAppleJuice();
            order.Side = new DragonbornWaffleFries();
            order.Entree = new BriarheartBurger();

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                (order.Drink as AretinoAppleJuice).Ice = true;
            });
            
            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                (order.Entree as BriarheartBurger).Bun = false;
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Drink = new SailorSoda();
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Side = new FriedMiraak();
            });

            Assert.PropertyChanged(order, "SpecialInstructions", () =>
            {
                order.Entree = new SmokehouseSkeleton();
            });
        }

        [Fact]
        public void HasCorrectDescription()
        {
            string str = "";
            var order = new Combo();
            Assert.Equal(str, order.Description);
        }
    }
}