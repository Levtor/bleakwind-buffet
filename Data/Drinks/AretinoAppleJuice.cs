using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{

    /*
    * Author: Joseph Hathaway
    * Class name: AretinoAppleJuice.cs
    * Purpose: Class used to represent an order of an Aretino Apple Juice
    */
    class AretinoAppleJuice
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

        public uint Calories
        {
            get
            {
                switch (size)
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
            sb.Append(" Aretino Apple Juice");
            return sb.ToString();
        }
    }
}
