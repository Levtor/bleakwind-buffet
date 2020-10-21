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
using System.ComponentModel.Design;

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

            if (newItem is Combo)
            {
                openComboEditPage(newItem);
            }
            else
            {
                openNewEditPage(newItem);
            }

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

            int i = (o.DataContext as Order).list.IndexOf((orderMakerBorder.Child as UserControl).DataContext as IOrderItem);

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
            var item = (o.orderItemsListView.SelectedItem as OrderCompItem).DataContext as IOrderItem;
            if (item is Combo) openComboEditPage(item);
            else openNewEditPage(item);
        }

        /// <summary>
        /// Makes the edits the user selected to the item in the order that the user was editing and
        /// brings up a page allowing the user to add an item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void finishEditing(object sender, RoutedEventArgs e)
        {
            if (!(orderMakerBorder.Child is EditComboPage))
            {
                foreach (UserControl uc in (orderCompBorder.Child as OrderComponent).orderItemsListView.Items)
                {
                    if (uc.DataContext is Combo combo)
                    {
                        IOrderItem i = (orderMakerBorder.Child as EditOrderItemPage).DataContext as IOrderItem;
                        if (i is Drink)
                        {
                            if (i == combo.Drink)
                            {
                                openComboEditPage(combo);
                                return;
                            }
                        }
                        else if (i is Side)
                        {
                            if (i == combo.Side)
                            {
                                openComboEditPage(combo);
                                return;
                            }
                        }
                        else if (i is Entree)
                        {
                            if (i == combo.Entree)
                            {
                                openComboEditPage(combo);
                                return;
                            }
                        }
                    }
                }
            }
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
        /// Allows the user to edit the entree of a combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void editEntree(object sender, RoutedEventArgs e)
        {
            openNewEditPage(((orderMakerBorder.Child as EditComboPage).DataContext as Combo).Entree);
            deleteButton.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Allows the user to edit the side of a combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void editSide(object sender, RoutedEventArgs e)
        {
            openNewEditPage(((orderMakerBorder.Child as EditComboPage).DataContext as Combo).Side);
            deleteButton.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Allows the user to edit the drink of a combo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void editDrink(object sender, RoutedEventArgs e)
        {
            openNewEditPage(((orderMakerBorder.Child as EditComboPage).DataContext as Combo).Drink);
            deleteButton.Visibility = Visibility.Collapsed;
        }


        void checkout(object sender, RoutedEventArgs e)
        {
            nonCheckoutGUI.Visibility = Visibility.Collapsed;
            checkoutGUI.Visibility = Visibility.Visible;
            checkoutGUI.Child = new CashOrCredit((orderCompBorder.Child as OrderComponent).DataContext as Order);
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

            entreeButton.Visibility = Visibility.Collapsed;
            sideButton.Visibility = Visibility.Collapsed;
            drinkButton.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Opens a page that allows the user to add an item to the order
        /// </summary>
        public void openNewAddPage()
        {
            orderMakerBorder.Child = new AddOrderItemPage();

            addButton.Visibility = Visibility.Visible;
            editButton.Visibility = Visibility.Visible;
            deleteButton.Visibility = Visibility.Collapsed;
            doneButton.Visibility = Visibility.Collapsed;

            entreeButton.Visibility = Visibility.Collapsed;
            sideButton.Visibility = Visibility.Collapsed;
            drinkButton.Visibility = Visibility.Collapsed;
        }

        /// <summary>
        /// Opens a page that allows the user to add a combo to the order
        /// </summary>
        void openComboEditPage(IOrderItem toEdit)
        {
            orderMakerBorder.Child = new EditComboPage(toEdit);

            addButton.Visibility = Visibility.Collapsed;
            editButton.Visibility = Visibility.Collapsed;
            deleteButton.Visibility = Visibility.Visible;
            doneButton.Visibility = Visibility.Visible;

            entreeButton.Visibility = Visibility.Visible;
            sideButton.Visibility = Visibility.Visible;
            drinkButton.Visibility = Visibility.Visible;
        }
    }
}
