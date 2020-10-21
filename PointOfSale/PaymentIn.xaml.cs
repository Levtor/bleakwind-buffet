/*
* Author: Joseph Hathaway
* Class name: PaymentIn.xaml.cs
* Purpose: Represents a positive value that the user can increment and decrement via buttons
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentIn.xaml
    /// </summary>
    public partial class PaymentIn : UserControl
    {
        public PaymentIn()
        {
            InitializeComponent();
        }

        void up(object sender, RoutedEventArgs e)
        {
            Cash o = (Parent as Grid).Parent as Cash;
            
            switch (Name)
            {
                case "b100InBox":
                    (o.DataContext as ViewModel).b100In++;
                    break;
                case "b50InBox":
                    (o.DataContext as ViewModel).b50In++;
                    break;
                case "b20InBox":
                    (o.DataContext as ViewModel).b20In++;
                    break;
                case "b10InBox":
                    (o.DataContext as ViewModel).b10In++;
                    break;
                case "b5InBox":
                    (o.DataContext as ViewModel).b5In++;
                    break;
                case "b2InBox":
                    (o.DataContext as ViewModel).b2In++;
                    break;
                case "b1InBox":
                    (o.DataContext as ViewModel).b1In++;
                    break;
                case "c100InBox":
                    (o.DataContext as ViewModel).c100In++;
                    break;
                case "c50InBox":
                    (o.DataContext as ViewModel).c50In++;
                    break;
                case "c25InBox":
                    (o.DataContext as ViewModel).c25In++;
                    break;
                case "c10InBox":
                    (o.DataContext as ViewModel).c10In++;
                    break;
                case "c5InBox":
                    (o.DataContext as ViewModel).c5In++;
                    break;
                case "c1InBox":
                    (o.DataContext as ViewModel).c1In++;
                    break;
            }
        }

        void down(object sender, RoutedEventArgs e)
        {
            switch (Name)
            {
                case "b100InBox":
                    if ((DataContext as ViewModel).b100In > 0) (DataContext as ViewModel).b100In--;
                    break;
                case "b50InBox":
                    if ((DataContext as ViewModel).b50In > 0) (DataContext as ViewModel).b50In--;
                    break;
                case "b20InBox":
                    if ((DataContext as ViewModel).b20In > 0) (DataContext as ViewModel).b20In--;
                    break;
                case "b10InBox":
                    if ((DataContext as ViewModel).b10In > 0) (DataContext as ViewModel).b10In--;
                    break;
                case "b5InBox":
                    if ((DataContext as ViewModel).b5In > 0) (DataContext as ViewModel).b5In--;
                    break;
                case "b2InBox":
                    if ((DataContext as ViewModel).b2In > 0) (DataContext as ViewModel).b2In--;
                    break;
                case "b1InBox":
                    if ((DataContext as ViewModel).b1In > 0) (DataContext as ViewModel).b1In--;
                    break;
                case "c100InBox":
                    if ((DataContext as ViewModel).c100In > 0) (DataContext as ViewModel).c100In--;
                    break;
                case "c50InBox":
                    if ((DataContext as ViewModel).c50In > 0) (DataContext as ViewModel).c50In--;
                    break;
                case "c25InBox":
                    if ((DataContext as ViewModel).c25In > 0) (DataContext as ViewModel).c25In--;
                    break;
                case "c10InBox":
                    if ((DataContext as ViewModel).c10In > 0) (DataContext as ViewModel).c10In--;
                    break;
                case "c5InBox":
                    if ((DataContext as ViewModel).c5In > 0) (DataContext as ViewModel).c5In--;
                    break;
                case "c1InBox":
                    if ((DataContext as ViewModel).c1In > 0) (DataContext as ViewModel).c1In--;
                    break;
            }
        }
    }
}
