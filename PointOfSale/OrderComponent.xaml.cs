/*
* Author: Joseph Hathaway
* Class name: OrderComponent.xaml.cs
* Purpose: This is the component of the application that displays the order
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderComponent.xaml
    /// </summary>
    public partial class OrderComponent : UserControl
    {
        /// <summary>
        /// Creates the OrderComponent
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();

            DataContext = new Order();

            orderNumTextBlock.Text = "Order# " + (DataContext as Order).Number;

            Binding bindingCalories = new Binding("Calories");
            bindingCalories.Source = DataContext;
            caloriesTextBlock.SetBinding(TextBlock.TextProperty, bindingCalories);

            Binding bindingTotal = new Binding("Total");
            bindingTotal.Source = DataContext;
            totalTextBlock.SetBinding(TextBlock.TextProperty, bindingTotal);

            Binding bindingSub = new Binding("SubTotal");
            bindingSub.Source = DataContext;
            subtotalTextBlock.SetBinding(TextBlock.TextProperty, bindingSub);

            Binding bindingTax = new Binding("Tax");
            bindingTax.Source = DataContext;
            taxTextBlock.SetBinding(TextBlock.TextProperty, bindingTax);
        }
    }
}
