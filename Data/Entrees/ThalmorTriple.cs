﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Joseph Hathaway
    * Class name: ThalmorTriple.cs
    * Purpose: Class used to represent an order of a Thalmor Triple
    */
    public class ThalmorTriple
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

        public Boolean Bun
        {
            get { return bun; }
            set
            {
                bun = value;
            }
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

        public Boolean Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
            }
        }

        public Boolean Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
            }
        }

        public Boolean Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
            }
        }

        public Boolean Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
            }
        }

        public Boolean Egg
        {
            get { return egg; }
            set
            {
                egg = value;
            }
        }

        public double Price
        {
            get { return 8.32; }
        }

        public uint Calories
        {
            get { return 943; }
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
                if (!tomato) specs.Add("Hold tomato");
                if (!lettuce) specs.Add("Hold lettuce");
                if (!mayo) specs.Add("Hold mayo");
                if (!bacon) specs.Add("Hold bacon");
                if (!egg) specs.Add("Hold egg");
                return specs;
            }
        }

        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
