/*
* Author: Joseph Hathaway
* Class name: CandlehearthCoffee.cs
* Purpose: Class used to represent an order of a Candlehearth Coffee
*/

using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing an order of a Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink, IOrderItem
    {
        private Boolean ice = false;
        private Boolean roomForCream = false;
        private Boolean decaf = false;

        /// <value>
        /// Whether the order has ice
        /// </value>
        public Boolean Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChange(new PropertyChangedEventArgs("Ice"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Whether the order has cream
        /// </value>
        public Boolean RoomForCream
        {
            get { return roomForCream; }
            set
            {
                roomForCream = value;
                PropertyChange(new PropertyChangedEventArgs("RoomForCream"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        
        /// <value>
        /// Whether the order is decaf
        /// </value>
        public Boolean Decaf
        {
            get { return decaf; }
            set
            {
                decaf = value;
                PropertyChange(new PropertyChangedEventArgs("Decaf"));
            }
        }

        private Size size = Size.Small;

        /// <summary>
        /// The size of the drink
        /// </summary>
        public override Size Size
        {
            get { return size; }
            set
            {
                size = value;
                PropertyChange(new PropertyChangedEventArgs("Size"));
                PropertyChange(new PropertyChangedEventArgs("Price"));
                PropertyChange(new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <value>
        /// The value of the order
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.75;
                    case Size.Medium:
                        return 1.25;
                    case Size.Large:
                        return 1.75;
                    default:
                        return 0;
                }
            }
        }

        /// <value>
        /// The calories of the order
        /// </value>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 7;
                    case Size.Medium:
                        return 10;
                    case Size.Large:
                        return 20;
                    default:
                        return 0;
                }
            }
        }

        List<string> specs = new List<string>();

        /// <value>
        /// Special insructions for the order
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                specs.Clear();
                if (ice) specs.Add("Add ice");
                if (roomForCream) specs.Add("Add cream");
                return specs;
            }
        }

        /// <summary>
        /// Returns a string describing the order
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (Size)
            {
                case Size.Small:
                    sb.Append("Small");
                    break;
                case Size.Medium:
                    sb.Append("Medium");
                    break;
                case Size.Large:
                    sb.Append("Large");
                    break;
                default:
                    break;
            }
            if (decaf) sb.Append(" Decaf");
            sb.Append(" Candlehearth Coffee");
            return sb.ToString();
        }

        /// <summary>
        /// Description of the item
        /// </summary>
        string description = "Fair trade, fresh ground dark roast coffee.";

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description { get { return description; } }
    }
}
