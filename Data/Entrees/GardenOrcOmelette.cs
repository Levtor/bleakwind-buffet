using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Joseph Hathaway
    * Class name: GardenOrcOmelette.cs
    * Purpose: Class used to represent an order of a Garden Orc Omelette
    */
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        private Boolean broccoli = true;
        private Boolean mushrooms = true;
        private Boolean tomato = true;
        private Boolean cheddar = true;

        /// <value>
        /// Whether the order has broccoli
        /// </value>
        public Boolean Broccoli
        {
            get { return broccoli; }
            set
            {
                broccoli = value;
                PropertyChange(new PropertyChangedEventArgs("Broccoli"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// Whether the order has mushrooms
        /// </value>
        public Boolean Mushrooms
        {
            get { return mushrooms; }
            set
            {
                mushrooms = value;
                PropertyChange(new PropertyChangedEventArgs("Mushrooms"));
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
        /// Whether the order has cheddar
        /// </value>
        public Boolean Cheddar
        {
            get { return cheddar; }
            set
            {
                cheddar = value;
                PropertyChange(new PropertyChangedEventArgs("Cheddar"));
                PropertyChange(new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <value>
        /// The price of the order
        /// </value>
        public override double Price
        {
            get { return 4.57; }
        }

        /// <value>
        /// The calories of the order
        /// </value>
        public override uint Calories
        {
            get { return 404; }
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
                if (!broccoli) specs.Add("Hold broccoli");
                if (!mushrooms) specs.Add("Hold mushrooms");
                if (!tomato) specs.Add("Hold tomato");
                if (!cheddar) specs.Add("Hold cheddar");
                return specs;
            }
        }

        /// <summary>
        /// Returns a string describing the order
        /// </summary>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }

        /// <summary>
        /// Description of the item
        /// </summary>
        string description = "Vegetarian. Two egg omelette packed with a mix of broccoli, mushrooms, and tomatoes. Topped with cheddar cheese.";

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description { get { return description; } }
    }
}
