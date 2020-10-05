/*
* Author: Joseph Hathaway
* Class name: MainWindow.xaml.cs
* Purpose: Holds all the components of the application
*/
using System;
using System.Collections.Generic;
using System.Data.Odbc;
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Creates the window and a component to allow the user to add an item to the order
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            openNewAddPage();
        }

        /// <summary>
        /// Adds the item the user has selected to the order and brings up a new page which allows
        /// the user to edit the added item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void addItemToOrder(object sender, RoutedEventArgs e)
        {
            AddOrderItemPage addPage = orderMakerBorder.Child as AddOrderItemPage;

            TextBlock toAddToOrderComponent = new TextBlock();
            toAddToOrderComponent.HorizontalAlignment = HorizontalAlignment.Center;
            toAddToOrderComponent.Text = addPage.returnSelectedOrderItem().ToString();

            orderComp.orderItemsListView.Items.Add(toAddToOrderComponent);
            orderComp.orderedItems.Add(addPage.returnSelectedOrderItem());
            int x = orderComp.orderItemsListView.Items.Count - 1;
            orderComp.orderItemsListView.SelectedItem = orderComp.orderItemsListView.Items[x];

            orderComp.updateNumbers();

            openNewEditPage(x);
        }

        /// <summary>
        /// Removes the item being edited from the order and pulls up a page which allows
        /// the user to add an item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void removeOrderItem(object sender, RoutedEventArgs e)
        {
            int i = (orderMakerBorder.Child as EditOrderItemPage).index;
            orderComp.orderItemsListView.Items.RemoveAt(i);
            orderComp.orderedItems.RemoveAt(i);

            orderComp.updateNumbers();

            openNewAddPage();
        }

        /// <summary>
        /// Pulls up a page which allows the user to edit the item in the order that
        /// is selected in the OrderComponent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void beginEditing(object sender, RoutedEventArgs e)
        {
            openNewEditPage(orderComp.orderItemsListView.Items.IndexOf(orderComp.orderItemsListView.SelectedItem));
        }

        /// <summary>
        /// Makes the edits the user selected to the item in the order that the user was editing and
        /// brings up a page allowing the user to add an item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eck"></param>
        void finishEditing(object sender, RoutedEventArgs eck)
        {
            var editPage = (orderMakerBorder.Child as EditOrderItemPage);
            IOrderItem toEdit = orderComp.orderedItems[editPage.index];
            
            (orderComp.orderItemsListView.Items[editPage.index] as TextBlock).Text = toEdit.ToString();
            orderComp.updateNumbers();

            openNewAddPage();
        }

        /// <summary>
        /// Opens a page allowing the user to edit an item in the order
        /// </summary>
        /// <param name="indexOfItemToEdit"></param>
        void openNewEditPage(int indexOfItemToEdit)
        {
            orderMakerBorder.Child = new EditOrderItemPage();
            EditOrderItemPage editPage = orderMakerBorder.Child as EditOrderItemPage;
            editPage.index = indexOfItemToEdit;

            (orderMakerBorder.Child as EditOrderItemPage).setup(orderComp.orderedItems[indexOfItemToEdit]);

            addButton.Visibility = Visibility.Collapsed;
            editButton.Visibility = Visibility.Collapsed;
            deleteButton.Visibility = Visibility.Visible;
            doneButton.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Opens a page that allows the user to add an item to the order
        /// </summary>
        void openNewAddPage()
        {
            orderMakerBorder.Child = new AddOrderItemPage();
            addButton.Visibility = Visibility.Visible;
            editButton.Visibility = Visibility.Visible;
            deleteButton.Visibility = Visibility.Collapsed;
            doneButton.Visibility = Visibility.Collapsed;
        }
    }
}
