/*
* Author: Joseph Hathaway
* Class name: WarriorWater.cs
* Purpose: Class used to represent an order of a Warrior Water
*/
    

using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{   
    /// <summary>
    /// A class representing an order of a Warrior Water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem
    {
        private Boolean ice = true;
        private Boolean lemon = false;
        
        /// <value>
        /// Whether the order has ice
        /// </value>
        public Boolean Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        /// <value>
        /// Whether the order has a lemon
        /// </value>
        public Boolean Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }

        /// <value>
        /// The price of the order
        /// </value>
        public override double Price
        {
            get
            {
                return 0;
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
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
                return 0;
                switch (Size)
                {
                    case Size.Small:
                        return 0;
                    case Size.Medium:
                        return 0;
                    case Size.Large:
                        return 0;
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
                if (!ice) specs.Add("Hold ice");
                if (lemon) specs.Add("Add lemon");
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
            sb.Append(" Warrior Water"); 
            return sb.ToString();
        }
    }
}
