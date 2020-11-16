using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Joseph Hathaway
    * Class name: PhillyPoacher.cs
    * Purpose: Class used to represent an order of a Philly Poacher
    */
    public class PhillyPoacher : Entree, IOrderItem
    {
        private Boolean sirloin = true;
        private Boolean onion = true;
        private Boolean roll = true;

        /// <value>
        /// Whether the order has sirloin
        /// </value>
        public Boolean Sirloin
        {
            get { return sirloin; }
            set
            {
                sirloin = value;
                PropertyChange(new PropertyChangedEventArgs("Sirloin"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Whether the order has onions
        /// </value>
        public Boolean Onion
        {
            get { return onion; }
            set
            {
                onion = value;
                PropertyChange(new PropertyChangedEventArgs("Onion"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Whether the order has a roll
        /// </value>
        public Boolean Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                PropertyChange(new PropertyChangedEventArgs("Roll"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// The price of the order
        /// </value>
        public override double Price
        {
            get { return 7.23; }
        }

        /// <value>
        /// The calories of the order
        /// </value>
        public override uint Calories
        {
            get { return 784; }
        }

        private List<string> specs = new List<string>();

        /// <value>
        /// Special insructions for the order
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                specs.Clear();
                if (!sirloin) specs.Add("Hold sirloin");
                if (!onion) specs.Add("Hold onions");
                if (!roll) specs.Add("Hold roll");
                return specs;
            }
        }

        /// <summary>
        /// Returns a string describing the order
        /// </summary>
        public override string ToString()
        {
            return "Philly Poacher";
        }

        /// <summary>
        /// Description of the item
        /// </summary>
        string description = "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.";

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description { get { return description; } }
    }
}
