using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class MarkarthMilk
    {
        private Boolean ice = false;

        public Boolean Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private BleakwindBuffet.Data.Enums.Size size = BleakwindBuffet.Data.Enums.Size.Small;

        public BleakwindBuffet.Data.Enums.Size Size
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

        public List<string> SpecialInstructions
        {
            
            get
            {
                if (ice) specs.Add("Add ice");
                return specs;
            }
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
            sb.Append(" Markarth Milk");
            return sb.ToString();
        }
    }
}
