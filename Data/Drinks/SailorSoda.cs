﻿using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class SailorSoda
    {
        private SodaFlavor flavor = SodaFlavor.Cherry;

        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        
        private Boolean ice = true;

        public Boolean Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        private BleakwindBuffet.Data.Enums.Size size = Size.Small;

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
                        return 1.42;
                    case Size.Medium:
                        return 1.74;
                    case Size.Large:
                        return 2.07;
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
                        return 117;
                    case Size.Medium:
                        return 153;
                    case Size.Large:
                        return 205;
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
                return specs;
            }

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (size)
            {
                case Size.Small:
                    sb.Append("Small ");
                    break;
                case Size.Medium:
                    sb.Append("Medium ");
                    break;
                case Size.Large:
                    sb.Append("Large ");
                    break;
                default:
                    break;
            }
            switch (flavor)
            {
                case SodaFlavor.Blackberry:
                    sb.Append("Blackberry");
                    break;
                case SodaFlavor.Cherry:
                    sb.Append("Cherry");
                    break;
                case SodaFlavor.Grapefruit:
                    sb.Append("Grapefruit");
                    break;
                case SodaFlavor.Lemon:
                    sb.Append("Lemon");
                    break;
                case SodaFlavor.Peach:
                    sb.Append("Peach");
                    break;
                case SodaFlavor.Watermelon:
                    sb.Append("Watermelon");
                    break;
                default:
                    break;
            }
            sb.Append(" Sailor Soda");
            return sb.ToString();
        }
    }
}
