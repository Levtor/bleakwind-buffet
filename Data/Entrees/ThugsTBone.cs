using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /*
    * Author: Joseph Hathaway
    * Class name: ThugsTBone.cs
    * Purpose: Class used to represent an order of a Thugs T-Bone
    */
    public class ThugsTBone
    {
        public double Price
        {
            get { return 6.44; }
        }

        public uint Calories
        {
            get { return 982; }
        }

        private List<string> specs = new List<string>();

        public List<string> SpecialInstructions
        {
            get { return specs; }
        }

        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
