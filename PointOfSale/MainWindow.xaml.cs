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
            OpenNewAddPage();
        }

        /// <summary>
        /// Adds the item the user has selected to the order and brings up a new page which allows
        /// the user to edit the added item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void AddItemToOrder(object sender, RoutedEventArgs e)
        {
            AddOrderItemPage addPage = orderMakerBorder.Child as AddOrderItemPage;

            TextBlock toAddToOrderComponent = new TextBlock();
            toAddToOrderComponent.HorizontalAlignment = HorizontalAlignment.Center;
            toAddToOrderComponent.Text = addPage.ReturnSelectedOrderItem().ToString();

            orderComp.orderItemsListView.Items.Add(toAddToOrderComponent);
            orderComp.orderedItems.Add(addPage.ReturnSelectedOrderItem());
            int x = orderComp.orderItemsListView.Items.Count - 1;
            orderComp.orderItemsListView.SelectedItem = orderComp.orderItemsListView.Items[x];

            orderComp.UpdateNumbers();

            OpenNewEditPage(x);
        }

        /// <summary>
        /// Removes the item being edited from the order and pulls up a page which allows
        /// the user to add an item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void RemoveOrderItem(object sender, RoutedEventArgs e)
        {
            int i = (orderMakerBorder.Child as EditOrderItemPage).index;
            orderComp.orderItemsListView.Items.RemoveAt(i);
            orderComp.orderedItems.RemoveAt(i);

            orderComp.UpdateNumbers();

            OpenNewAddPage();
        }

        /// <summary>
        /// Pulls up a page which allows the user to edit the item in the order that
        /// is selected in the OrderComponent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void BeginEditing(object sender, RoutedEventArgs e)
        {
            OpenNewEditPage(orderComp.orderItemsListView.Items.IndexOf(orderComp.orderItemsListView.SelectedItem));
        }

        /// <summary>
        /// Makes the edits the user selected to the item in the order that the user was editing and
        /// brings up a page allowing the user to add an item to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="eck"></param>
        void FinishEditing(object sender, RoutedEventArgs eck)
        {
            var editPage = (orderMakerBorder.Child as EditOrderItemPage);
            IOrderItem toEdit = orderComp.orderedItems[editPage.index];

            if (toEdit is Entree)
            {
                if (toEdit is BriarheartBurger)
                {
                    BriarheartBurger e = toEdit as BriarheartBurger;
                    e.Bun = (bool)(editPage.optionsStackPanel.Children[1] as CheckBox).IsChecked;
                    e.Ketchup = (bool)(editPage.optionsStackPanel.Children[2] as CheckBox).IsChecked;
                    e.Mustard = (bool)(editPage.optionsStackPanel.Children[3] as CheckBox).IsChecked;
                    e.Pickle = (bool)(editPage.optionsStackPanel.Children[4] as CheckBox).IsChecked;
                    e.Cheese = (bool)(editPage.optionsStackPanel.Children[5] as CheckBox).IsChecked;
                }
                else if (toEdit is DoubleDraugr)
                {
                    DoubleDraugr e = toEdit as DoubleDraugr;
                    e.Bun = (bool)(editPage.optionsStackPanel.Children[1] as CheckBox).IsChecked;
                    e.Ketchup = (bool)(editPage.optionsStackPanel.Children[2] as CheckBox).IsChecked;
                    e.Mustard = (bool)(editPage.optionsStackPanel.Children[3] as CheckBox).IsChecked;
                    e.Pickle = (bool)(editPage.optionsStackPanel.Children[4] as CheckBox).IsChecked;
                    e.Cheese = (bool)(editPage.optionsStackPanel.Children[5] as CheckBox).IsChecked;
                    e.Tomato = (bool)(editPage.optionsStackPanel.Children[6] as CheckBox).IsChecked;
                    e.Lettuce = (bool)(editPage.optionsStackPanel.Children[7] as CheckBox).IsChecked;
                    e.Mayo = (bool)(editPage.optionsStackPanel.Children[8] as CheckBox).IsChecked;
                }
                else if (toEdit is GardenOrcOmelette)
                {
                    GardenOrcOmelette e = toEdit as GardenOrcOmelette;
                    e.Broccoli = (bool)(editPage.optionsStackPanel.Children[1] as CheckBox).IsChecked;
                    e.Mushrooms = (bool)(editPage.optionsStackPanel.Children[2] as CheckBox).IsChecked;
                    e.Tomato = (bool)(editPage.optionsStackPanel.Children[3] as CheckBox).IsChecked;
                    e.Cheddar = (bool)(editPage.optionsStackPanel.Children[4] as CheckBox).IsChecked;
                }
                else if (toEdit is PhillyPoacher)
                {
                    PhillyPoacher e = toEdit as PhillyPoacher;
                    e.Sirloin = (bool)(editPage.optionsStackPanel.Children[1] as CheckBox).IsChecked;
                    e.Onion = (bool)(editPage.optionsStackPanel.Children[2] as CheckBox).IsChecked;
                    e.Roll = (bool)(editPage.optionsStackPanel.Children[3] as CheckBox).IsChecked;
                }
                else if (toEdit is SmokehouseSkeleton)
                {
                    SmokehouseSkeleton e = toEdit as SmokehouseSkeleton;
                    e.SausageLink = (bool)(editPage.optionsStackPanel.Children[1] as CheckBox).IsChecked;
                    e.Egg = (bool)(editPage.optionsStackPanel.Children[2] as CheckBox).IsChecked;
                    e.HashBrowns = (bool)(editPage.optionsStackPanel.Children[3] as CheckBox).IsChecked;
                    e.Pancake = (bool)(editPage.optionsStackPanel.Children[4] as CheckBox).IsChecked;
                }
                else if (toEdit is ThalmorTriple)
                {
                    ThalmorTriple e = toEdit as ThalmorTriple;
                    e.Bun = (bool)(editPage.optionsStackPanel.Children[1] as CheckBox).IsChecked;
                    e.Ketchup = (bool)(editPage.optionsStackPanel.Children[2] as CheckBox).IsChecked;
                    e.Mustard = (bool)(editPage.optionsStackPanel.Children[3] as CheckBox).IsChecked;
                    e.Pickle = (bool)(editPage.optionsStackPanel.Children[4] as CheckBox).IsChecked;
                    e.Cheese = (bool)(editPage.optionsStackPanel.Children[5] as CheckBox).IsChecked;
                    e.Tomato = (bool)(editPage.optionsStackPanel.Children[6] as CheckBox).IsChecked;
                    e.Lettuce = (bool)(editPage.optionsStackPanel.Children[7] as CheckBox).IsChecked;
                    e.Mayo = (bool)(editPage.optionsStackPanel.Children[8] as CheckBox).IsChecked;
                    e.Bacon = (bool)(editPage.optionsStackPanel.Children[9] as CheckBox).IsChecked;
                    e.Egg = (bool)(editPage.optionsStackPanel.Children[10] as CheckBox).IsChecked;
                }
                else if (toEdit is ThugsTBone) return;
            }
            else if (toEdit is Side)
            {
                Side e = toEdit as Side;
                if ((bool)(editPage.optionsStackPanel.Children[1] as RadioButton).IsChecked)
                    e.Size = BleakwindBuffet.Data.Enums.Size.Small;
                if ((bool)(editPage.optionsStackPanel.Children[2] as RadioButton).IsChecked)
                    e.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                if ((bool)(editPage.optionsStackPanel.Children[3] as RadioButton).IsChecked)
                    e.Size = BleakwindBuffet.Data.Enums.Size.Large;
            }
            else if (toEdit is Drink)
            {
                Drink f = toEdit as Drink;
                if ((bool)(editPage.optionsStackPanel.Children[1] as RadioButton).IsChecked)
                    f.Size = BleakwindBuffet.Data.Enums.Size.Small;
                if ((bool)(editPage.optionsStackPanel.Children[2] as RadioButton).IsChecked)
                    f.Size = BleakwindBuffet.Data.Enums.Size.Medium;
                if ((bool)(editPage.optionsStackPanel.Children[3] as RadioButton).IsChecked)
                    f.Size = BleakwindBuffet.Data.Enums.Size.Large;

                if (toEdit is AretinoAppleJuice)
                {
                    AretinoAppleJuice e = toEdit as AretinoAppleJuice;
                    e.Ice = (bool)(editPage.optionsStackPanel.Children[5] as CheckBox).IsChecked;
                }
                else if (toEdit is CandlehearthCoffee)
                {
                    CandlehearthCoffee e = toEdit as CandlehearthCoffee;
                    e.Ice = (bool)(editPage.optionsStackPanel.Children[5] as CheckBox).IsChecked;
                    e.RoomForCream = (bool)(editPage.optionsStackPanel.Children[6] as CheckBox).IsChecked;
                    e.Decaf = (bool)(editPage.optionsStackPanel.Children[7] as CheckBox).IsChecked;
                }
                else if (toEdit is MarkarthMilk)
                {
                    MarkarthMilk e = toEdit as MarkarthMilk;
                    e.Ice = (bool)(editPage.optionsStackPanel.Children[5] as CheckBox).IsChecked;
                }
                else if (toEdit is SailorSoda)
                {

                    SailorSoda e = toEdit as SailorSoda;
                    if ((bool)(editPage.optionsStackPanel.Children[5] as RadioButton).IsChecked)
                        e.Flavor = SodaFlavor.Blackberry;
                    if ((bool)(editPage.optionsStackPanel.Children[6] as RadioButton).IsChecked)
                        e.Flavor = SodaFlavor.Cherry;
                    if ((bool)(editPage.optionsStackPanel.Children[7] as RadioButton).IsChecked)
                        e.Flavor = SodaFlavor.Grapefruit;
                    if ((bool)(editPage.optionsStackPanel.Children[8] as RadioButton).IsChecked)
                        e.Flavor = SodaFlavor.Lemon;
                    if ((bool)(editPage.optionsStackPanel.Children[9] as RadioButton).IsChecked)
                        e.Flavor = SodaFlavor.Peach;
                    if ((bool)(editPage.optionsStackPanel.Children[10] as RadioButton).IsChecked)
                        e.Flavor = SodaFlavor.Watermelon;

                    e.Ice = (bool)(editPage.optionsStackPanel.Children[12] as CheckBox).IsChecked;
                }
                else if (toEdit is WarriorWater)
                {
                    WarriorWater e = toEdit as WarriorWater;
                    e.Ice = (bool)(editPage.optionsStackPanel.Children[5] as CheckBox).IsChecked;
                    e.Lemon = (bool)(editPage.optionsStackPanel.Children[6] as CheckBox).IsChecked;
                }
            }

            (orderComp.orderItemsListView.Items[editPage.index] as TextBlock).Text = toEdit.ToString();
            orderComp.UpdateNumbers();

            OpenNewAddPage();
        }

        /// <summary>
        /// Opens a page allowing the user to edit an item in the order
        /// </summary>
        /// <param name="indexOfItemToEdit"></param>
        void OpenNewEditPage(int indexOfItemToEdit)
        {
            orderMakerBorder.Child = new EditOrderItemPage();
            EditOrderItemPage editPage = orderMakerBorder.Child as EditOrderItemPage;
            editPage.index = indexOfItemToEdit;

            (orderMakerBorder.Child as EditOrderItemPage).Setup(orderComp.orderedItems[indexOfItemToEdit]);

            addButton.Visibility = Visibility.Collapsed;
            editButton.Visibility = Visibility.Collapsed;
            deleteButton.Visibility = Visibility.Visible;
            doneButton.Visibility = Visibility.Visible;
        }

        /// <summary>
        /// Opens a page that allows the user to add an item to the order
        /// </summary>
        void OpenNewAddPage()
        {
            orderMakerBorder.Child = new AddOrderItemPage();
            addButton.Visibility = Visibility.Visible;
            editButton.Visibility = Visibility.Visible;
            deleteButton.Visibility = Visibility.Collapsed;
            doneButton.Visibility = Visibility.Collapsed;
        }
    }
}
