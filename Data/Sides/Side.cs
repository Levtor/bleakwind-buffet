﻿/*
* Author: Joseph Hathaway
* Class name: Side.cs
* Purpose: Base class for side objects
*/

using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing the common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void PropertyChange(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
        
        private Size size = Size.Small;

        /// <summary>
        /// The size of the side
        /// </summary>
        public virtual Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// The price of the side
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }

        /// <summary>
        /// The calories of the side
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Description of the side
        /// </summary>
        public abstract string Description { get; }
    }
}
