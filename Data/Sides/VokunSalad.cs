/*
* Author: Joseph Hathaway
* Class name: VokunSalad.cs
* Purpose: Class used to represent an order of a Vokun Salad
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing an order of a Vokun Salad
    /// </summary>
    public class VokunSalad
    {
        private Size size = Size.Small;

        /// <value>
        /// The size of the order
        /// </value>
        public Size Size
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
                        return 0.93;
                    case Size.Medium:
                        return 1.28;
                    case Size.Large:
                        return 1.82;
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
                        return 41;
                    case Size.Medium:
                        return 52;
                    case Size.Large:
                        return 73;
                    default:
                        return 0;
                }
            }
        }

        /// <value>
        /// Special insructions for the order
        /// </value>
        public List<string> SpecialInstructions
        {
            get { return new List<string>(); }
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
            sb.Append(" Vokun Salad");
            return sb.ToString();
        }
    }
}
