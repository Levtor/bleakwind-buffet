/*
* Author: Joseph Hathaway
* Class name: Cash.xaml.cs
* Purpose: Handles the user interactions for a customer paying with cash
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Cash.xaml
    /// </summary>
    public partial class Cash : UserControl
    {
        public Cash(double total)
        {
            InitializeComponent();

            PriceBox.Text = "$" + total;

            var vm = new ViewModel(total);
            vm.PropertyChanged += HandlePropertyChanged;
            DataContext = vm;
        }

        void HandlePropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            ViewModel o = DataContext as ViewModel;
            switch (e.PropertyName)
            {
                case "b100In":
                    update(b100InBox, o.b100In);
                    break;
                case "b50In":
                    update(b50InBox, o.b50In);
                    break;
                case "b20In":
                    update(b20InBox, o.b20In);
                    break;
                case "b10In":
                    update(b10InBox, o.b10In);
                    break;
                case "b5In":
                    update(b5InBox, o.b5In);
                    break;
                case "b2In":
                    update(b2InBox, o.b2In);
                    break;
                case "b1In":
                    update(b1InBox, o.b1In);
                    break;
                case "c100In":
                    update(c100InBox, o.c100In);
                    break;
                case "c50In":
                    update(c50InBox, o.c50In);
                    break;
                case "c25In":
                    update(c25InBox, o.c25In);
                    break;
                case "c10In":
                    update(c10InBox, o.c10In);
                    break;
                case "c5In":
                    update(c5InBox, o.c5In);
                    break;
                case "c1In":
                    update(c1InBox, o.c1In);
                    break;
            }
            b100Box.Text = "" + o.b100Out;
            b50Box.Text = "" + o.b50Out;
            b20Box.Text = "" + o.b20Out;
            b10Box.Text = "" + o.b10Out;
            b5Box.Text = "" + o.b5Out;
            b2Box.Text = "" + o.b2Out;
            b1Box.Text = "" + o.b1Out;
            c100Box.Text = "" + o.c100Out;
            c50Box.Text = "" + o.c50Out;
            c25Box.Text = "" + o.c25Out;
            c10Box.Text = "" + o.c10Out;
            c5Box.Text = "" + o.c5Out;
            c1Box.Text = "" + o.c1Out;
        }

        void update (PaymentIn inPaid, int nPaid)
        {
            inPaid.value.Text = "" + nPaid;

            double debt = (DataContext as ViewModel).calculateDebt();
            if (debt > 0)
            {
                DebtBox.Text = "$" + debt;
                ChangeBox.Text = "$0.00";
                finButton.IsEnabled = false;
            }
            else
            {
                ChangeBox.Text = "$" + (DataContext as ViewModel).calculateChange(); ;
                DebtBox.Text = "$0.00";
                finButton.IsEnabled = true;
            }
        }

        void back(object sender, RoutedEventArgs e)
        {
            (((Parent as Border).Parent as Grid).Parent as CashOrCredit).back(sender, e);
        }

        void finalize(object sender, RoutedEventArgs e)
        {
            (DataContext as ViewModel).moveMoney();
            (((Parent as Border).Parent as Grid).Parent as CashOrCredit).receipt(true);
        }
    }
}
