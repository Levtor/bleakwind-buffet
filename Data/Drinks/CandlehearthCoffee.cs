using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Drinks
{
    class CandlehearthCoffee
    {
        private Boolean ice = false;
        private Boolean roomForCream = false;
        private Boolean decaf = false;

        public Boolean Ice
        {
            get { return ice; }
            set { ice = value; }
        }

        public Boolean RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }

        public Boolean Decaf
        {
            get { return decaf; }
            set { decaf = value; }
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
                        return 0.75;
                    case Size.Medium:
                        return 1.25;
                    case Size.Large:
                        return 1.75;
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
                        return 7;
                    case Size.Medium:
                        return 10;
                    case Size.Large:
                        return 20;
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
                if (roomForCream) specs.Add("Add cream");
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
            if (decaf) sb.Append(" Decaf");
            sb.Append(" Candlehearth Coffee");
            return sb.ToString();
        }
    }
}
