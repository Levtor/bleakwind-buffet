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
using System.ComponentModel;

namespace BleakwindBuffet.Data.Drinks
{   
    /// <summary>
    /// A class representing an order of a Warrior Water
    /// </summary>
    public class WarriorWater : Drink
    {
        private Boolean ice = true;
        private Boolean lemon = false;
        
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
        /// Whether the order has a lemon
        /// </value>
        public Boolean Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                PropertyChange(new PropertyChangedEventArgs("Lemon"));
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
                return 0;
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

        /// <summary>
        /// Description of the item
        /// </summary>
        string description = "It’s water. Just water.";

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description { get { return description; } }
    }
}
