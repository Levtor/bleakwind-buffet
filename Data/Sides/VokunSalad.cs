using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    class VokunSalad
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
            sb.Append(" Vokun Salad");
            return sb.ToString();
        }
    }
}
