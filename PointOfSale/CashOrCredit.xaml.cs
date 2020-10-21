/*
* Author: Joseph Hathaway
* Class name: CashOrCredit.xaml.cs
* Purpose: Handles the user interactions for finalizing a transaction
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
using RoundRegister;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashOrCredit.xaml
    /// </summary>
    public partial class CashOrCredit : UserControl
    {
        public CashOrCredit(Order o)
        {
            InitializeComponent();
            DataContext = o;
            cashTransaction.Child = new Cash(o.Total);
        }

        void cash(object sender, RoutedEventArgs e)
        {
            ccc.Visibility = Visibility.Collapsed;
            cashTransaction.Visibility = Visibility.Visible;
        }

        void credit(object sender, RoutedEventArgs e)
        {
            if (CardReader.RunCard((DataContext as Order).Total) == CardTransactionResult.Approved)
            {
                receipt(false);
            }
        }

        public void back(object sender, RoutedEventArgs e)
        {
            (((Parent as Border).Parent as Grid).Parent as MainWindow).nonCheckoutGUI.Visibility = Visibility.Visible;
            (((Parent as Border).Parent as Grid).Parent as MainWindow).checkoutGUI.Visibility = Visibility.Collapsed;
        }

        public void receipt(bool usedCash)
        {
            ((cashTransaction.Child as Cash).DataContext as ViewModel).printReceipt(DataContext as Order, usedCash);

            (((Parent as Border).Parent as Grid).Parent as MainWindow).openNewAddPage();
            (((Parent as Border).Parent as Grid).Parent as MainWindow).orderCompBorder.Child = new OrderComponent();

            (((Parent as Border).Parent as Grid).Parent as MainWindow).nonCheckoutGUI.Visibility = Visibility.Visible;
            (((Parent as Border).Parent as Grid).Parent as MainWindow).checkoutGUI.Visibility = Visibility.Collapsed;
        }
    }
}
