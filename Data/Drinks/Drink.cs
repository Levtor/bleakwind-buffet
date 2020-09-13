/*
* Author: Joseph Hathaway
* Class name: Drink.cs
* Purpose: Base class for drink objects
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A base class representing the common properties of drinks
    /// </summary>
    public abstract class Drink : IOrderItem
    {
        private Size size;

        /// <summary>
        /// The size of the drink
        /// </summary>
        public virtual Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// The price of the drink 
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
