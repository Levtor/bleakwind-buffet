using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    /*
    * Author: Joseph Hathaway
    * Class name: WarriorWater.cs
    * Purpose: Class used to represent an order of a Warrior Water
    */
    class WarriorWater
    {
        private Boolean ice = true;
        private Boolean lemon = false;

        public Boolean Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        public Boolean Lemon
        {
            get { return lemon; }
            set { lemon = value; }
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
                return 0;
                switch (size)
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

        public uint Calories
        {
            get
            {
                return 0;
                switch (size)
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

        public List<string> SpecialInstructions
        {
            
            get
            {
                if (!ice) specs.Add("Hold ice");
                if (lemon) specs.Add("Add lemon");
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
            sb.Append(" Warrior Water"); 
            return sb.ToString();
        }
    }
}
