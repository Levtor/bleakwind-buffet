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

        /// <value>
        /// Whether the order has a bun
        /// </value>
        public Boolean Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <value>
        /// Whether the order has ketchup
        /// </value>
        public Boolean Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
            }
        }

        /// <value>
        /// Whether the order has mustard
        /// </value>
        public Boolean Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
            }
        }

        /// <value>
        /// Whether the order has a pickle
        /// </value>
        public Boolean Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
            }
        }

        /// <value>
        /// Whether the order has cheese
        /// </value>
        public Boolean Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
            }
        }

        /// <value>
        /// The price of the order
        /// </value>
        public double Price
        {
            get { return 6.32; }
        }

        /// <value>
        /// The calories of the order
        /// </value>
        public uint Calories
        {
            get { return 743; }
        }

        private List<string> specs = new List<string>();

        /// <value>
        /// Special insructions for the order
        /// </value>
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

        /// <summary>
        /// Returns a string describing the order
        /// </summary>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
