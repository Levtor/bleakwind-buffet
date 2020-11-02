/*
* Author: Joseph Hathaway
* Class name: MenuProxy.cs
* Purpose: Class that functions as Menu.cs for the Website namespace
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;

namespace Website
{
    public static class MenuProxy
    {
        /// <summary>
        /// Lists the orderable entrees
        /// </summary>
        /// <returns>a list of the orderable entrees</returns>
        public static IEnumerable<(string, double, uint)> Entrees()
        {
            var ret = new List<(string, double, uint)>();
            foreach (IOrderItem i in Menu.Entrees())
            {
                ret.Add((i.ToString(), i.Price, i.Calories));
            }
            return ret;
        }
        /// <summary>
        /// Lists the orderable sides
        /// </summary>
        /// <returns>a list of the orderable sides</returns>
        public static IEnumerable<(string, double, uint)> Sides()
        {
            var ret = new List<(string, double, uint)>();
            foreach (IOrderItem i in Menu.Sides())
            {
                ret.Add((i.ToString(), i.Price, i.Calories));
            }
            return ret;
        }
        /// <summary>
        /// Lists the orderable drinks
        /// </summary>
        /// <returns>a list of the orderable drinks</returns>
        public static IEnumerable<(string, double, uint)> Drinks()
        {
            var ret = new List<(string, double, uint)>();
            foreach (IOrderItem i in Menu.Drinks())
            {
                ret.Add((i.ToString(), i.Price, i.Calories));
            }
            return ret;
        }
        /// <summary>
        /// Lists the orderable items
        /// </summary>
        /// <returns>a list of the orderable items</returns>
        public static IEnumerable<(string, double, uint)> FullMenu()
        {
            var ret = new List<(string, double, uint)>();
            foreach (IOrderItem i in Menu.FullMenu())
            {
                ret.Add((i.ToString(), i.Price, i.Calories));
            }
            return ret;
        }
    }
}
