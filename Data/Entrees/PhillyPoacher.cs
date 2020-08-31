using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Joseph Hathaway
    * Class name: PhillyPoacher.cs
    * Purpose: Class used to represent an order of a Philly Poacher
    */
    class PhillyPoacher
    {
        private Boolean sirloin = true;
        private Boolean onion = true;
        private Boolean roll = true;

        public Boolean Sirloin
        {
            get { return sirloin; }
            set
            {
                sirloin = value;
            }
        }

        public Boolean Onion
        {
            get { return onion; }
            set
            {
                onion = value;
            }
        }

        public Boolean Roll
        {
            get { return roll; }
            set
            {
                roll = value;
            }
        }

        public double Price
        {
            get { return 7.23; }
        }

        public uint Calories
        {
            get { return 784; }
        }

        private List<string> specs = new List<string>();

        public List<string> SpecialInstructions
        {
            get
            {
                if (!sirloin) specs.Add("Hold sirloin");
                if (!onion) specs.Add("Hold onions");
                if (!roll) specs.Add("Hold roll");
                return specs;
            }
        }

        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
