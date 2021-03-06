﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;


namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Joseph Hathaway
    * Class name: ThugsTBone.cs
    * Purpose: Class used to represent an order of a Thugs T-Bone
    */
    public class ThugsTBone : Entree, IOrderItem
    {
        /// <value>
        /// The price of the order
        /// </value>
        public override double Price
        {
            get { return 6.44; }
        }

        /// <value>
        /// The calories of the order
        /// </value>
        public override uint Calories
        {
            get { return 982; }
        }

        private List<string> specs = new List<string>();

        /// <value>
        /// Special insructions for the order
        /// </value>
        public override List<string> SpecialInstructions
        {
            get { return specs; }
        }

        /// <summary>
        /// Returns a string describing the order
        /// </summary>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

        /// <summary>
        /// Description of the item
        /// </summary>
        string description = "Juicy T-Bone, not much else to say.";

        /// <summary>
        /// Description of the item
        /// </summary>
        public override string Description { get { return description; } }
    }
}
