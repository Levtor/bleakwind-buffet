using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /*
    * Author: Joseph Hathaway
    * Class name: DragonbornWaffleFries.cs
    * Purpose: Class used to represent an order of Dragonborn Waffle Fries
    */
    public class DragonbornWaffleFries
    {
        private Size size = Size.Small;

        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        public double Price
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 0.42;
                    case Size.Medium:
                        return 0.76;
                    case Size.Large:
                        return 0.96;
                    default:
                        return 0;
                }
            }
        }

        public uint Calories
        {
            get
            {
                switch (size)
                {
                    case Size.Small:
                        return 77;
                    case Size.Medium:
                        return 89;
                    case Size.Large:
                        return 100;
                    default:
                        return 0;
                }
            }
        }

        public List<string> SpecialInstructions
        {
            get { return new List<string>(); }
        }

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
            sb.Append(" Dragonborn Waffle Fries");
            return sb.ToString();
        }
    }
}
