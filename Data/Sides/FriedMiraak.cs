/*
* Author: Joseph Hathaway
* Class name: FriedMiraak.cs
* Purpose: Class used to represent an order of Fried Miraak
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing an order of Fried Miraak
    /// </summary>
    public class FriedMiraak
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
                        return 1.78;
                    case Size.Medium:
                        return 2.01;
                    case Size.Large:
                        return 2.88;
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
                        return 151;
                    case Size.Medium:
                        return 236;
                    case Size.Large:
                        return 306;
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
            sb.Append(" Fried Miraak");
            return sb.ToString();
        }
    }
}
