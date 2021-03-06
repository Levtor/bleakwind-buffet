﻿/*
* Author: Joseph Hathaway
* Class name: SailorSoda.cs
* Purpose: Class used to represent an order of a Sailor Soda
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
    /// A class representing an order of a Sailor Soda
    /// </summary>
    public class SailorSoda : Drink
    {
        private SodaFlavor flavor = SodaFlavor.Cherry;

        /// <value>
        /// The flavor of the order
        /// </value>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set
            {
                flavor = value;
                PropertyChange(new PropertyChangedEventArgs("Flavor"));
            }
        }
        
        private Boolean ice = true;

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
        /// The price of the order
        /// </value>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 1.42;
                    case Size.Medium:
                        return 1.74;
                    case Size.Large:
                        return 2.07;
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
                        return 117;
                    case Size.Medium:
                        return 153;
                    case Size.Large:
                        return 205;
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
                if (!ice) specs.Add("Hold ice");
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
                    sb.Append("Small ");
                    break;
                case Size.Medium:
                    sb.Append("Medium ");
                    break;
                case Size.Large:
                    sb.Append("Large ");
                    break;
                default:
                    break;
            }
            switch (flavor)
            {
                case SodaFlavor.Blackberry:
                    sb.Append("Blackberry");
                    break;
                case SodaFlavor.Cherry:
                    sb.Append("Cherry");
                    break;
                case SodaFlavor.Grapefruit:
                    sb.Append("Grapefruit");
                    break;
                case SodaFlavor.Lemon:
                    sb.Append("Lemon");
                    break;
                case SodaFlavor.Peach:
                    sb.Append("Peach");
                    break;
                case SodaFlavor.Watermelon:
                    sb.Append("Watermelon");
                    break;
                default:
                    break;
            }
            sb.Append(" Sailor Soda");
            return sb.ToString();
        }

        /// <summary>
        /// Description of the item
        /// </summary>
        string description = "An old-fashioned jerked soda, carbonated water and flavored syrup poured over a bed of crushed ice.";

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description { get { return description; } }
    }
}
