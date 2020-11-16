/*
* Author: Joseph Hathaway
* Class name: AretinoAppleJuice.cs
* Purpose: Class used to represent an order of an Aretino Apple Juice
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
    /// A class representing an order of an Aretino Apple Juice
    /// </summary>
    public class AretinoAppleJuice : Drink
    {
        private Boolean ice = false;

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
                        return 0.62;
                    case Size.Medium:
                        return 0.87;
                    case Size.Large:
                        return 1.01;
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
                        return 44;
                    case Size.Medium:
                        return 88;
                    case Size.Large:
                        return 132;
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
            sb.Append(" Aretino Apple Juice");
            return sb.ToString();
        }

        /// <summary>
        /// Description of the item
        /// </summary>
        string description = "Fresh squeezed apple juice.";

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description { get { return description; } }
    }
}
