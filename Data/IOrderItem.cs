using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the order item
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories of the order item
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions to prepare the order item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
