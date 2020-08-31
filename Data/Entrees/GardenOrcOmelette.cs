using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Joseph Hathaway
    * Class name: GardenOrcOmelette.cs
    * Purpose: Class used to represent an order of a Garden Orc Omelette
    */
    class GardenOrcOmelette
    {
        private Boolean broccoli = true;
        private Boolean mushrooms = true;
        private Boolean tomato = true;
        private Boolean cheddar = true;

        public Boolean Broccoli
        {
            get { return broccoli; }
            set
            {
                broccoli = value;
            }
        }

        public Boolean Mushrooms
        {
            get { return mushrooms; }
            set
            {
                mushrooms = value;
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

        public Boolean Cheddar
        {
            get { return cheddar; }
            set
            {
                cheddar = value;
            }
        }

        public double Price
        {
            get { return 4.57; }
        }

        public uint Calories
        {
            get { return 404; }
        }

        private List<string> specs = new List<string>();

        public List<string> SpecialInstructions
        {
            get
            {
                if (!broccoli) specs.Add("Hold broccoli");
                if (!mushrooms) specs.Add("Hold mushrooms");
                if (!tomato) specs.Add("Hold tomato");
                if (!cheddar) specs.Add("Hold cheddar");
                return specs;
            }
        }

        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
