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
        /// List of the OrderItems represented in the ListView of the OrderComponent
        /// </summary>
        public List<IOrderItem> orderedItems = new List<IOrderItem>();

        /// <summary>
        /// Creates the OrderComponent
        /// </summary>
        public OrderComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clears the list of OrderItems
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void clearOrder(object sender, RoutedEventArgs e)
        {
            orderedItems = new List<IOrderItem>();
            orderItemsListView.Items.Clear();

            updateNumbers();
        }

        /// <summary>
        /// Updates the displayed calorie and price values
        /// </summary>
        public void updateNumbers()
        {
            uint totCal = 0;
            double totPrice = 0;
            
            foreach (IOrderItem i in orderedItems)
            {
                totCal += i.Calories;
                totPrice += i.Price;
            }
            
            caloriesTextBlock.Text = "Total Calories: " + totCal;
            priceTextBlock.Text = "Total Price: $" + (totPrice - totPrice % 0.01);
        }
    }
}
