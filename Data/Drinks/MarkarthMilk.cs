/*
* Author: Joseph Hathaway
* Class name: MarkarthMilk.cs
* Purpose: Class used to represent an order of a Markarth Milk
*/

using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// A class representing an order of a Markarth Milk
    /// </summary>
    public class MarkarthMilk
    {
        private Boolean ice = false;

        /// <value>
        /// Whether the order has ice
        /// </value>
        public Boolean Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private BleakwindBuffet.Data.Enums.Size size = BleakwindBuffet.Data.Enums.Size.Small;

        /// <value>
        /// The size of the order
        /// </value>
        public BleakwindBuffet.Data.Enums.Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <value>
        /// The price of the order
        /// </value>
        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 1.05;
                    case Size.Medium:
                        return 1.11;
                    case Size.Large:
                        return 1.22;
                    default:
                        return 0;
                }
            }
        }

        /// <value>
        /// The calories of the order
        /// </value>
        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 56;
                    case Size.Medium:
                        return 72;
                    case Size.Large:
                        return 93;
                    default:
                        return 0;
                }
            }
        }

        List<string> specs = new List<string>();

        /// <value>
        /// Special insructions for the order
        /// </value>
        public List<string> SpecialInstructions
        {
            
            get
            {
                if (ice) specs.Add("Add ice");
                return specs;
            }
        }

        /// <summary>
        /// Returns a string describing the order
        /// </summary>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (size)
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
            sb.Append(" Markarth Milk");
            return sb.ToString();
        }
    }
}
