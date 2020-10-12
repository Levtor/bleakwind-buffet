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
            orderCompBorder.Child = new OrderComponent();
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
            OrderComponent o = (orderCompBorder.Child as OrderComponent);
            IOrderItem newItem = addPage.returnSelectedOrderItem();
            var toAddToOrderComponent = new OrderCompItem(newItem);

            o.orderItemsListView.Items.Add(toAddToOrderComponent);
            (o.DataContext as Order).Add(newItem);
            o.orderItemsListView.SelectedItem = toAddToOrderComponent;

            openNewEditPage(newItem);
        }

        /// <summary>
        /// Removes the item being edited from the order and pulls up a page which allows
        /// the user to add an item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void removeOrderItem(object sender, RoutedEventArgs e)
        {
            OrderComponent o = orderCompBorder.Child as OrderComponent;
            EditOrderItemPage editPage = orderMakerBorder.Child as EditOrderItemPage;

            int i = (o.DataContext as Order).list.IndexOf(editPage.DataContext as IOrderItem);

            o.orderItemsListView.Items.RemoveAt(i);
            (o.DataContext as Order).list.RemoveAt(i);

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
            var o = orderCompBorder.Child as OrderComponent;
            openNewEditPage((o.orderItemsListView.SelectedItem as OrderCompItem).DataContext as IOrderItem);
        }

        /// <summary>
        /// Makes the edits the user selected to the item in the order that the user was editing and
        /// brings up a page allowing the user to add an item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void finishEditing(object sender, RoutedEventArgs e)
        {
            openNewAddPage();
        }

        /// <summary>
        /// Clears the current order and starts a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void clearOrder(object sender, RoutedEventArgs e)
        {
            openNewAddPage();

            orderCompBorder.Child = new OrderComponent();
        }

        /// <summary>
        /// Opens a page allowing the user to edit an item in the order
        /// </summary>
        /// <param name="indexOfItemToEdit"></param>
        void openNewEditPage(IOrderItem toEdit)
        {
            orderMakerBorder.Child = new EditOrderItemPage(toEdit);

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
