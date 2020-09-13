using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Joseph Hathaway
    * Class name: SmokehouseSkeleton.cs
    * Purpose: Class used to represent an order of a Smokehouse Skeleton
    */
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        private Boolean sausageLink = true;
        private Boolean egg = true;
        private Boolean hashBrowns = true;
        private Boolean pancake = true;

        /// <value>
        /// Whether the order has sausage
        /// </value>
        public Boolean SausageLink
        {
            get { return sausageLink; }
            set
            {
                sausageLink = value;
            }
        }

        /// <value>
        /// Whether the order has eggs
        /// </value>
        public Boolean Egg
        {
            get { return egg; }
            set
            {
                egg = value;
            }
        }

        /// <value>
        /// Whether the order has hashbrowns
        /// </value>
        public Boolean HashBrowns
        {
            get { return hashBrowns; }
            set
            {
                hashBrowns = value;
            }
        }

        /// <value>
        /// Whether the order has pancakes
        /// </value>
        public Boolean Pancake
        {
            get { return pancake; }
            set
            {
                pancake = value;
            }
        }

        /// <value>
        /// The price of the order
        /// </value>
        public override double Price
        {
            get { return 5.62; }
        }

        /// <value>
        /// The calories of the order
        /// </value>
        public override uint Calories
        {
            get { return 602; }
        }

        private List<string> specs = new List<string>();

        /// <value>
        /// Special insructions for the order
        /// </value>
        public override List<string> SpecialInstructions
        {
            get
            {
                if (!sausageLink) specs.Add("Hold sausage");
                if (!egg) specs.Add("Hold eggs");
                if (!hashBrowns) specs.Add("Hold hash browns");
                if (!pancake) specs.Add("Hold pancakes");
                return specs;
            }
        }

        /// <summary>
        /// Returns a string describing the order
        /// </summary>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
