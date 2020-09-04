using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Joseph Hathaway
    * Class name: BriarheartBurger.cs
    * Purpose: Class used to represent an order of a Briarheart Burger
    */
    public class BriarheartBurger
    {
        private Boolean bun = true;
        private Boolean ketchup = true;
        private Boolean mustard = true;
        private Boolean pickle = true;
        private Boolean cheese = true;

        public Boolean Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        public Boolean Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
            }
        }

        public Boolean Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
            }
        }

        public Boolean Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
            }
        }

        public Boolean Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
            }
        }

        public double Price
        {
            get { return 6.32; }
        }

        public uint Calories
        {
            get { return 743; }
        }

        private List<string> specs = new List<string>();

        public List<string> SpecialInstructions
        {
            get
            {
                if (!bun) specs.Add("Hold bun");
                if (!ketchup) specs.Add("Hold ketchup");
                if (!mustard) specs.Add("Hold mustard");
                if (!pickle) specs.Add("Hold pickle");
                if (!cheese) specs.Add("Hold cheese");
                return specs;
            }
        }

        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
