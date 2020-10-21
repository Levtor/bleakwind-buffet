/*
 * Author: Joseph Hathaway
 * Class: Combo.cs
 * Purpose: To hold a drink, entree, and side
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.ComponentModel;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data
{
    public class Combo : IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Entree entree = null;
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                if (entree != null)
                {
                    entree.PropertyChanged -= ComboItemChangeListener;
                }
                
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

                entree.PropertyChanged += ComboItemChangeListener;
            }
        }

        private Side side = null;
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                if (side != null)
                {
                    side.PropertyChanged -= ComboItemChangeListener;
                }

                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

                side.PropertyChanged += ComboItemChangeListener;
            }
        }

        private Drink drink = null;
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                if (drink != null)
                {
                    drink.PropertyChanged -= ComboItemChangeListener;
                }

                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));

                drink.PropertyChanged += ComboItemChangeListener;
            }
        }

        public double Price
        {
            get
            {
                double sum = 0;
                sum += this.Drink.Price;
                sum += this.Entree.Price;
                sum += this.Side.Price;
                sum -= 1;
                return sum;
            }
        }

        public uint Calories
        {
            get
            {
                uint sum = 0;
                sum += this.Drink.Calories;
                sum += this.Entree.Calories;
                sum += this.Side.Calories;
                return sum;
            }
        }

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> ret = new List<string>();

                ret.Add(this.Entree.ToString());
                foreach (string item in this.Entree.SpecialInstructions)
                {
                    ret.Add(item);
                }

                ret.Add(this.Side.ToString());
                foreach (string item in this.Side.SpecialInstructions)
                {
                    ret.Add(item);
                }

                ret.Add(this.Drink.ToString());
                foreach (string item in this.Drink.SpecialInstructions)
                {
                    ret.Add(item);
                }

                return ret;
            }
        }

        void ComboItemChangeListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Size")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
            else if (e.PropertyName == "SpecialInstructions")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Returns a string describing the combo
        /// </summary>
        /// <returns>a string describing the combo</returns>
        public override string ToString()
        {
            return "Combo";
        }
    }
}
