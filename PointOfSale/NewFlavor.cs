/*
 * Author: Joseph Hathaway
 * Class name: NewFlavor.cs
 * Purpose: Class used to represent flavors through an enumeration
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BleakwindBuffet.Data.Enums;

namespace PointOfSale
{
    public enum NewFlavor
    {
        blackberry = SodaFlavor.Blackberry,
        cherry = SodaFlavor.Cherry,
        grapefruit = SodaFlavor.Grapefruit,
        lemon = SodaFlavor.Lemon,
        peach = SodaFlavor.Peach,
        watermelon = SodaFlavor.Watermelon
    }
}
