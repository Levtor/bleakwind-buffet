using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Joseph Hathaway
    * Class name: DoubleDraugr.cs
    * Purpose: Class used to represent an order of a Double Draugr
    */
    public class DoubleDraugr : Entree, IOrderItem
    {
        private Boolean bun = true;
        private Boolean ketchup = true;
        private Boolean mustard = true;
        private Boolean pickle = true;
        private Boolean cheese = true;
        private Boolean tomato = true;
        private Boolean lettuce = true;
        private Boolean mayo = true;

        /// <value>
        /// Whether the order has a bun
        /// </value>
        public Boolean Bun
        {
            get { return bun; }
            set
            {
                bun = value;
            }
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
        /// Whether the order has pickle
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
        /// Whether the order has tomato
        /// </value>
        public Boolean Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
            }
        }

        /// <value>
        /// Whether the order has lettuce
        /// </value>
        public Boolean Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
            }
        }

        /// <value>
        /// Whether the order has mayo
        /// </value>
        public Boolean Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
            }
        }

        /// <value>
        /// The price of the order
        /// </value>
        public override double Price
        {
            get { return 7.32; }
        }

        /// <value>
        /// The calories of the order
        /// </value>
        public override uint Calories
        {
            get { return 843; }
        }

        private List<string> specs = new List<string>();

        /// <value>
        /// Special insructions for the order
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                if (!bun) specs.Add("Hold bun");
                if (!ketchup) specs.Add("Hold ketchup");
                if (!mustard) specs.Add("Hold mustard");
                if (!pickle) specs.Add("Hold pickle");
                if (!cheese) specs.Add("Hold cheese");
                if (!tomato) specs.Add("Hold tomato");
                if (!lettuce) specs.Add("Hold lettuce");
                if (!mayo) specs.Add("Hold mayo");
                return specs;
            }
        }

        /// <summary>
        /// Returns a string describing the order
        /// </summary>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
