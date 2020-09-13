/*
* Author: Joseph Hathaway
* Class name: MadOtarGrits.cs
* Purpose: Class used to represent an order of Mad Otar Grits
*/

using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A class representing an order of Mad Otar Grits
    /// </summary>
    public class MadOtarGrits : Side, IOrderItem
    {
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
                        return 1.22;
                    case Size.Medium:
                        return 1.58;
                    case Size.Large:
                        return 1.93;
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
                        return 105;
                    case Size.Medium:
                        return 142;
                    case Size.Large:
                        return 179;
                    default:
                        return 0;
                }
            }
        }

        /// <value>
        /// Special insructions for the order
        /// </value>
        public override List<string> SpecialInstructions
        {
            get { return new List<string>(); }
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
            sb.Append(" Mad Otar Grits");
            return sb.ToString();
        }
    }
}
