/*
* Author: Joseph Hathaway
* Class name: Menu.cs
* Purpose: Class representing/storing the menu of orderable items
*/

using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// A static class which can produce lists of the different types of orderable items
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Lists the orderable entrees
        /// </summary>
        /// <returns>a list of the orderable entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            Entree addE;

            addE = new BriarheartBurger();
            list.Add(addE);
            addE = new DoubleDraugr();
            list.Add(addE);
            addE = new GardenOrcOmelette();
            list.Add(addE);
            addE = new PhillyPoacher();
            list.Add(addE);
            addE = new SmokehouseSkeleton();
            list.Add(addE);
            addE = new ThalmorTriple();
            list.Add(addE);
            addE = new ThugsTBone();
            list.Add(addE);

            IEnumerable<IOrderItem> ret = list;
            return ret;
        }

        /// <summary>
        /// Lists the orderable sides
        /// </summary>
        /// <returns>a list of the orderable sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            Side addS;

            addS = new DragonbornWaffleFries();
            addS.Size = Size.Small;
            list.Add(addS);
            addS = new DragonbornWaffleFries();
            addS.Size = Size.Medium;
            list.Add(addS);
            addS = new DragonbornWaffleFries();
            addS.Size = Size.Large;
            list.Add(addS);

            addS = new FriedMiraak();
            addS.Size = Size.Small;
            list.Add(addS);
            addS = new FriedMiraak();
            addS.Size = Size.Medium;
            list.Add(addS);
            addS = new FriedMiraak();
            addS.Size = Size.Large;
            list.Add(addS);

            addS = new MadOtarGrits();
            addS.Size = Size.Small;
            list.Add(addS);
            addS = new MadOtarGrits();
            addS.Size = Size.Medium;
            list.Add(addS);
            addS = new MadOtarGrits();
            addS.Size = Size.Large;
            list.Add(addS);

            addS = new VokunSalad();
            addS.Size = Size.Small;
            list.Add(addS);
            addS = new VokunSalad();
            addS.Size = Size.Medium;
            list.Add(addS);
            addS = new VokunSalad();
            addS.Size = Size.Large;
            list.Add(addS);

            IEnumerable<IOrderItem> ret = list;
            return ret;
        }

        /// <summary>
        /// Lists the orderable drinks
        /// </summary>
        /// <returns>a list of the orderable drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            Drink addD;

            addD = new AretinoAppleJuice();
            addD.Size = Size.Small;
            list.Add(addD);
            addD = new AretinoAppleJuice();
            addD.Size = Size.Medium;
            list.Add(addD);
            addD = new AretinoAppleJuice();
            addD.Size = Size.Large;
            list.Add(addD);

            addD = new CandlehearthCoffee();
            addD.Size = Size.Small;
            list.Add(addD);
            addD = new CandlehearthCoffee();
            addD.Size = Size.Medium;
            list.Add(addD);
            addD = new CandlehearthCoffee();
            addD.Size = Size.Large;
            list.Add(addD);

            addD = new MarkarthMilk();
            addD.Size = Size.Small;
            list.Add(addD);
            addD = new MarkarthMilk();
            addD.Size = Size.Medium;
            list.Add(addD);
            addD = new MarkarthMilk();
            addD.Size = Size.Large;
            list.Add(addD);

            addD = new WarriorWater();
            addD.Size = Size.Small;
            list.Add(addD);
            addD = new WarriorWater();
            addD.Size = Size.Medium;
            list.Add(addD);
            addD = new WarriorWater();
            addD.Size = Size.Large;
            list.Add(addD);

            SailorSoda ad;
            for (int i=0; i<6; i++)
            {
                ad = new SailorSoda();
                ad.Flavor = (SodaFlavor)i;
                ad.Size = Size.Small;
                list.Add(ad);
                ad = new SailorSoda();
                ad.Flavor = (SodaFlavor)i;
                ad.Size = Size.Medium;
                list.Add(ad);
                ad = new SailorSoda();
                ad.Flavor = (SodaFlavor)i;
                ad.Size = Size.Large;
                list.Add(ad);
            }
            
            IEnumerable<IOrderItem> ret = list;
            return ret;
        }

        /// <summary>
        /// Lists the orderable items
        /// </summary>
        /// <returns>a list of the orderable items</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> list = new List<IOrderItem>();
            Entree addE;
            Side addS;
            Drink addD;

            addE = new BriarheartBurger();
            list.Add(addE);
            addE = new DoubleDraugr();
            list.Add(addE);
            addE = new GardenOrcOmelette();
            list.Add(addE);
            addE = new PhillyPoacher();
            list.Add(addE);
            addE = new SmokehouseSkeleton();
            list.Add(addE);
            addE = new ThalmorTriple();
            list.Add(addE);
            addE = new ThugsTBone();
            list.Add(addE);


            addS = new DragonbornWaffleFries();
            addS.Size = Size.Small;
            list.Add(addS);
            addS = new DragonbornWaffleFries();
            addS.Size = Size.Medium;
            list.Add(addS);
            addS = new DragonbornWaffleFries();
            addS.Size = Size.Large;
            list.Add(addS);

            addS = new FriedMiraak();
            addS.Size = Size.Small;
            list.Add(addS);
            addS = new FriedMiraak();
            addS.Size = Size.Medium;
            list.Add(addS);
            addS = new FriedMiraak();
            addS.Size = Size.Large;
            list.Add(addS);

            addS = new MadOtarGrits();
            addS.Size = Size.Small;
            list.Add(addS);
            addS = new MadOtarGrits();
            addS.Size = Size.Medium;
            list.Add(addS);
            addS = new MadOtarGrits();
            addS.Size = Size.Large;
            list.Add(addS);

            addS = new VokunSalad();
            addS.Size = Size.Small;
            list.Add(addS);
            addS = new VokunSalad();
            addS.Size = Size.Medium;
            list.Add(addS);
            addS = new VokunSalad();
            addS.Size = Size.Large;
            list.Add(addS);


            addD = new AretinoAppleJuice();
            addD.Size = Size.Small;
            list.Add(addD);
            addD = new AretinoAppleJuice();
            addD.Size = Size.Medium;
            list.Add(addD);
            addD = new AretinoAppleJuice();
            addD.Size = Size.Large;
            list.Add(addD);

            addD = new CandlehearthCoffee();
            addD.Size = Size.Small;
            list.Add(addD);
            addD = new CandlehearthCoffee();
            addD.Size = Size.Medium;
            list.Add(addD);
            addD = new CandlehearthCoffee();
            addD.Size = Size.Large;
            list.Add(addD);

            addD = new MarkarthMilk();
            addD.Size = Size.Small;
            list.Add(addD);
            addD = new MarkarthMilk();
            addD.Size = Size.Medium;
            list.Add(addD);
            addD = new MarkarthMilk();
            addD.Size = Size.Large;
            list.Add(addD);

            addD = new WarriorWater();
            addD.Size = Size.Small;
            list.Add(addD);
            addD = new WarriorWater();
            addD.Size = Size.Medium;
            list.Add(addD);
            addD = new WarriorWater();
            addD.Size = Size.Large;
            list.Add(addD);

            SailorSoda ad;
            for (int i = 0; i < 6; i++)
            {
                ad = new SailorSoda();
                ad.Flavor = (SodaFlavor)i;
                ad.Size = Size.Small;
                list.Add(ad);
                ad = new SailorSoda();
                ad.Flavor = (SodaFlavor)i;
                ad.Size = Size.Medium;
                list.Add(ad);
                ad = new SailorSoda();
                ad.Flavor = (SodaFlavor)i;
                ad.Size = Size.Large;
                list.Add(ad);
            }

            IEnumerable<IOrderItem> ret = list;
            return ret;
        }
    }
}
