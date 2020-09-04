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
    public class SmokehouseSkeleton
    {
        private Boolean sausageLink = true;
        private Boolean egg = true;
        private Boolean hashBrowns = true;
        private Boolean pancake = true;

        public Boolean SausgeLink
        {
            get { return sausageLink; }
            set
            {
                sausageLink = value;
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

        public Boolean HashBrowns
        {
            get { return hashBrowns; }
            set
            {
                hashBrowns = value;
            }
        }

        public Boolean Pancake
        {
            get { return pancake; }
            set
            {
                pancake = value;
            }
        }

        public double Price
        {
            get { return 5.62; }
        }

        public uint Calories
        {
            get { return 602; }
        }

        private List<string> specs = new List<string>();

        public List<string> SpecialInstructions
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

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
