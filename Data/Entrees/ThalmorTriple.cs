﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Joseph Hathaway
    * Class name: ThalmorTriple.cs
    * Purpose: Class used to represent an order of a Thalmor Triple
    */
    public class ThalmorTriple : Entree, IOrderItem
    {
        private Boolean bun = true;
        private Boolean ketchup = true;
        private Boolean mustard = true;
        private Boolean pickle = true;
        private Boolean cheese = true;
        private Boolean tomato = true;
        private Boolean lettuce = true;
        private Boolean mayo = true;
        private Boolean bacon = true;
        private Boolean egg = true;

        /// <value>
        /// Whether the order has a bun
        /// </value>
        public Boolean Bun
        {
            get { return bun; }
            set
            {
                bun = value;
                PropertyChange(new PropertyChangedEventArgs("Bun"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChange(new PropertyChangedEventArgs("Ketchup"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChange(new PropertyChangedEventArgs("Mustard"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Whether the order has pickles
        /// </value>
        public Boolean Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChange(new PropertyChangedEventArgs("Pickle"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChange(new PropertyChangedEventArgs("Cheese"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChange(new PropertyChangedEventArgs("Tomato"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChange(new PropertyChangedEventArgs("Lettuce"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
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
                PropertyChange(new PropertyChangedEventArgs("Mayo"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Whether the order has bacon
        /// </value>
        public Boolean Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
                PropertyChange(new PropertyChangedEventArgs("Bacon"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Whether the order has egg
        /// </value>
        public Boolean Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                PropertyChange(new PropertyChangedEventArgs("Egg"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// The price of the order
        /// </value>
        public override double Price
        {
            get { return 8.32; }
        }

        /// <value>
        /// The calories of the order
        /// </value>
        public override uint Calories
        {
            get { return 943; }
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
                if (!bun) specs.Add("Hold bun");
                if (!ketchup) specs.Add("Hold ketchup");
                if (!mustard) specs.Add("Hold mustard");
                if (!pickle) specs.Add("Hold pickle");
                if (!cheese) specs.Add("Hold cheese");
                if (!tomato) specs.Add("Hold tomato");
                if (!lettuce) specs.Add("Hold lettuce");
                if (!mayo) specs.Add("Hold mayo");
                if (!bacon) specs.Add("Hold bacon");
                if (!egg) specs.Add("Hold egg");
                return specs;
            }
        }

        /// <summary>
        /// Returns a string describing the order
        /// </summary>
        public override string ToString()
        {
            return "Thalmor Triple";
        }

        /// <summary>
        /// Description of the item
        /// </summary>
        string description = "Think you are strong enough to take on the Thalmor? Inlcudes two 1/4lb patties with a 1/2lb patty inbetween with ketchup, mustard, pickle, cheese, tomato, lettuce, mayo, bacon, and an egg.";

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description { get { return description; } }
    }
}
