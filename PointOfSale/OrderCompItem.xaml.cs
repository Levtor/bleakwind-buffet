/*
 * Author: Joseph Hathaway
 * Class: OrderCompItem.cs
 * Purpose: Represent an IOrderItem in the OrderComponent
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderCompItem.xaml
    /// </summary>
    public partial class OrderCompItem : UserControl
    {
        /// <summary>
        /// Creates the OrderCompItem, representing various information about an IOrderItem
        /// </summary>
        /// <param name="dContext">the represented IOrderItem</param>
        public OrderCompItem(IOrderItem dContext)
        {
            InitializeComponent();
            DataContext = dContext;

            (DataContext as IOrderItem).PropertyChanged += SIChangeListener;
            
            Title.Text = (DataContext as IOrderItem).ToString();

            Specials.Items.Clear();
            foreach (string str in (DataContext as IOrderItem).SpecialInstructions)
            {
                TextBlock tb = new TextBlock();
                tb.Text = str;
                Specials.Items.Add(tb);
            }

            double sum = (DataContext as IOrderItem).Price;
            sum *= 100;
            sum -= sum % 1;
            sum /= 100;
            PriceBox.Text = "$" + sum;
        }

        /// <summary>
        /// Listens for if the properties of the represented IOrderItem change and changes the displayed information appropriately
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void SIChangeListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "SpecialInstructions")
            {
                Title.Text = (DataContext as IOrderItem).ToString();

                Specials.Items.Clear();
                foreach (string str in (DataContext as IOrderItem).SpecialInstructions)
                {
                    TextBlock tb = new TextBlock();
                    tb.Text = str;
                    Specials.Items.Add(tb);
                }
            }
            else if (e.PropertyName == "Size" || e.PropertyName == "Flavor")
            {
                Title.Text = (DataContext as IOrderItem).ToString();
            }
            else if (e.PropertyName == "Price")
            {
                double sum = (DataContext as IOrderItem).Price;
                sum *= 100;
                sum -= sum % 1;
                sum /= 100;
                PriceBox.Text = "$" + sum;
            }
        }
    }
}
