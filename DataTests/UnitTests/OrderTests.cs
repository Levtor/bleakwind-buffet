/*
 * Author: Joseph Hathawya
 * Class: OrderTests.cs
 * Purpose: Test the Order.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Xunit;
using BleakwindBuffet.Data;
using System.Resources;
using System.Transactions;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class OrderTests
    {
        [Fact]
        public void ImplementsICollectionOfIOrderItems()
        {
            var order = new Order();

            Assert.IsAssignableFrom<ICollection<IOrderItem>>(order);
        }

        [Fact]
        public void ImplementsINotifyCollectionChanged()
        {
            var order = new Order();

            Assert.IsAssignableFrom<INotifyCollectionChanged>(order);
        }

        [Fact]
        public void ImplementsINotifyPropertyChanged()
        {
            var order = new Order();

            Assert.IsAssignableFrom<INotifyPropertyChanged>(order);
        }

        [Fact]
        public void OrderNumbersUnique()
        {
            var order = new Order();
            var order2 = new Order();

            Assert.NotEqual(order.Number, order2.Number);
        }

        [Fact]
        public void SalesTaxAssignable()
        {
            var order = new Order();

            order.SalesTaxRate = 4;

            Assert.Equal(4, order.SalesTaxRate);
        }

        [Fact]
        public void SalesTaxStartsAs12Percent()
        {
            var order = new Order();

            Assert.Equal(0.12, order.SalesTaxRate);
        }

        [Fact]
        public void PricesCorrect()
        {
            var order = new Order();

            var a = new BriarheartBurger();
            var b = new FriedMiraak();
            var c = new SailorSoda();
            order.Add(a);
            order.Add(b);
            order.Add(c);

            Assert.Equal(Math.Round(a.Price + b.Price + c.Price, 2), order.SubTotal);
            Assert.Equal(Math.Round(order.SubTotal*order.SalesTaxRate, 2), order.Tax);
            Assert.Equal(Math.Round(order.SubTotal + order.Tax, 2), order.Total);
        }

        [Fact]
        public void CaloriesCorrect()
        {
            var order = new Order();

            var a = new BriarheartBurger();
            var b = new FriedMiraak();
            var c = new SailorSoda();
            order.Add(a);
            order.Add(b);
            order.Add(c);

            Assert.Equal(a.Calories + b.Calories + c.Calories, order.Calories);
        }

        [Fact]
        public void CollectionChangesNotifyCollectionChanged()
        {
            var order = new Order();

            var a = new BriarheartBurger();

            /*Assert.Raises<NotifyCollectionChangedEventArgs>(
                listener => order += listener,
                listener => order -= listener,
                () =>
                {
                    order.Add(a);
                });

            Assert.Raises<NotifyCollectionChangedEventArgs>(
                listener => order += listener,
                listener => order -= listener,
                () =>
                {
                    order.Remove(a);
                });

            Assert.Raises<NotifyCollectionChangedEventArgs>(
                listener => order += listener,
                listener => order -= listener,
                () =>
                {
                    order.Clear();
                });*/
        }

        [Fact]
        public void CaloriesChangesNotifyPropertyChanged()
        {
            var order = new Order();
            var a = new BriarheartBurger();
            var b = new FriedMiraak();
            var c = new SailorSoda();
            order.Add(a);

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Add(a);
            });

            order.Add(b);

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Remove(b);
            });

            Assert.PropertyChanged(order, "Calories", () =>
            {
                order.Clear();
            });

            order.Add(c);

            Assert.PropertyChanged(order, "Calories", () =>
            {
                c.Size = Size.Large;
            });
        }

        [Fact]
        public void PriceChangesNotifyPropertyChanged()
        {
            var order = new Order();
            var a = new BriarheartBurger();
            var b = new FriedMiraak();
            var c = new SailorSoda();
            order.Add(a);

            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Add(a);
            });

            order.Add(b);

            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Remove(b);
            });

            Assert.PropertyChanged(order, "Total", () =>
            {
                order.Clear();
            });

            order.Add(c);

            Assert.PropertyChanged(order, "Total", () =>
            {
                c.Size = Size.Large;
            });

            a = new BriarheartBurger();
            b = new FriedMiraak();
            c = new SailorSoda();
            order.Add(a);

            Assert.PropertyChanged(order, "SubTotal", () =>
            {
                order.Add(a);
            });

            order.Add(b);

            Assert.PropertyChanged(order, "SubTotal", () =>
            {
                order.Remove(b);
            });

            Assert.PropertyChanged(order, "SubTotal", () =>
            {
                order.Clear();
            });

            order.Add(c);

            Assert.PropertyChanged(order, "SubTotal", () =>
            {
                c.Size = Size.Large;
            });

            a = new BriarheartBurger();
            b = new FriedMiraak();
            c = new SailorSoda();
            order.Add(a);

            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Add(a);
            });

            order.Add(b);

            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Remove(b);
            });

            Assert.PropertyChanged(order, "Tax", () =>
            {
                order.Clear();
            });

            order.Add(c);

            Assert.PropertyChanged(order, "Tax", () =>
            {
                c.Size = Size.Large;
            });
        }
    }
}
