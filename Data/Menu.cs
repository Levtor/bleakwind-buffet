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
using System.Linq;

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

        /// <summary>
        /// Filters a list of IOrderItems by whether each item contains each string in a passed list of terms
        /// </summary>
        /// <param name="list">the list being filtered</param>
        /// <param name="searchString">the string containing the terms to filter by</param>
        /// <returns>the filtered list of IOrderItems</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> list, string searchString)
        {
            if (searchString == null) return list;

            var terms = new List<string>();
            foreach (string term in searchString.Split(' '))
            {
                if (term.Length > 0) terms.Add(term);
            }

            if (terms.Count == 0) return list;

            var ret = new List<IOrderItem>();
            foreach (IOrderItem item in list)
            {
                bool add = false;
                foreach (string term in terms)
                {
                    //if (!item.ToString().Contains(term, StringComparison.CurrentCultureIgnoreCase))
                    if (item.ToString().ToLower().Contains(term.ToLower()))
                    {
                        add = true;
                        break;
                    }
                    if (item.Description.ToLower().Contains(term.ToLower()))
                    {
                        add = true;
                        break;
                    }
                }
                if (add) ret.Add(item);
            }
            return ret;
        }


        /// <summary>
        /// Filters a list of IOrderItems to only include the specified categories. If none are specified, does nothing
        /// </summary>
        /// <param name="list">the list being filtered</param>
        /// <param name="categories">list of the categories to include</param>
        /// <returns>the filtered list of IOrderItems</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> list, IEnumerable<string> categories)
        {
            if (categories == null) return list;

            bool drinks = categories.Contains("Drinks");
            bool entrees = categories.Contains("Entrees");
            bool sides = categories.Contains("Sides");

            if (drinks == entrees && entrees == sides) return list;

            var ret = new List<IOrderItem>();
            foreach (IOrderItem item in list)
            {
                if (drinks && item is Drink) ret.Add(item);
                else if (entrees && item is Entree) ret.Add(item);
                else if (sides && item is Side) ret.Add(item);
            }
            return ret;
        }


        /// <summary>
        /// Filters a list of IOrderItems by calories
        /// </summary>
        /// <param name="list">the list being filtered</param>
        /// <param name="max">the maximum calorie value</param>
        /// <param name="min">the minimum calorie value</param>
        /// <returns>the filtered list of IOrderItems</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> list, uint? max, uint? min)
        {
            if (max == null && min == null) return list;
            if (min == null) min = 0;
            if (max == null) max = 200000; // max drink + max side + max entree = 205 + 306 + 982 = 1493 (rounded up x100)

            var ret = new List<IOrderItem>();
            foreach (IOrderItem item in list)
            {
                uint i = item.Calories;
                if (i >= min && i <= max) ret.Add(item);
            }

            return ret;
        }

        /// <summary>
        /// Filters a list of IOrderItems by price
        /// </summary>
        /// <param name="list">the list being filtered</param>
        /// <param name="max">the maximum price value</param>
        /// <param name="min">the minimum price value</param>
        /// <returns>the filtered list of IOrderItems</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> list, double? max, double? min)
        {
            if (max == null && min == null) return list;
            if (min == null) min = 0;
            if (max == null) max = 2000; // max drink + max side + max entree = 2.07 + 2.88 + 8.32 = 13.27 (rounded up x100)

            var ret = new List<IOrderItem>();
            foreach (IOrderItem item in list)
            {
                double i = item.Price;
                if (i >= min && i <= max) ret.Add(item);
            }

            return ret;
        }
    }
}
