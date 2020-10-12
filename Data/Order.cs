/*
 * Author: Joseph Hathawya
 * Class: Order.cs
 * Purpose: Hold multiple IOrderItems
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

namespace BleakwindBuffet.Data
{
    public class Order : ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public List<IOrderItem> list = new List<IOrderItem>();

        private static int nextNumber = 1001;

        public int Number
        {
            get;
            set;
        }

        public Order()
        {
            Number = nextNumber;
            nextNumber++;
        }

        private double salesTaxRate = 0.12;
        public double SalesTaxRate
        {
            get
            {
                return salesTaxRate;
            }
            set
            {
                salesTaxRate = value;
            }
        }

        public double SubTotal
        {
            get
            {
                double sum = 0;
                foreach (IOrderItem item in list)
                {
                    sum += item.Price;
                }
                sum *= 100;
                sum -= sum % 1;
                sum /= 100;
                return sum;
            }
        }

        public double Tax
        {
            get
            {
                double sum = SubTotal * SalesTaxRate;
                sum *= 100;
                sum -= sum % 1;
                sum /= 100;
                return sum;
            }
        }

        public double Total
        {
            get
            {
                double sum = SubTotal + Tax;
                sum *= 100;
                sum -= sum % 1;
                sum /= 100;
                return sum;
            }
        }

        public uint Calories
        {
            get
            {
                uint sum = 0;
                foreach (IOrderItem item in list)
                {
                    sum += item.Calories;
                }
                return sum;
            }
        }

        public int Count => list.Count;

        public bool IsReadOnly => false;

        public event PropertyChangedEventHandler PropertyChanged;
        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public void Add(IOrderItem item)
        {
            list.Add(item);
            item.PropertyChanged += ItemChangeListener;
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        public void Clear()
        {
            foreach (IOrderItem item in list)
            {
                item.PropertyChanged -= ItemChangeListener;
            }

            list.Clear();
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        public bool Contains(IOrderItem item)
        {
            return list.Contains(item);
        }

        public void CopyTo(IOrderItem[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public bool Remove(IOrderItem item)
        {
            item.PropertyChanged -= ItemChangeListener;
            bool ret = list.Remove(item);
            CollectionChanged?.Invoke(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            return ret;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return list.GetEnumerator();
        }

        void ItemChangeListener(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Size")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }
    }
}
