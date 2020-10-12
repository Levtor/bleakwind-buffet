/*
* Author: Joseph Hathaway
* Class name: EditOrderItemPage.xaml.cs
* Purpose: This is the component of the application that allows the user to edit an item in the order
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
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EditOrderItemPage.xaml
    /// </summary>
    public partial class EditOrderItemPage : UserControl
    {
        /// <summary>
        /// Creates the page to edit the order item
        /// </summary>
        /// <param name="toEdit">the order item to be edited</param>
        public EditOrderItemPage(IOrderItem toEdit)
        {
            InitializeComponent();

            headerTextBlock.Text = "Edit " + toEdit.ToString() +" Order";
            caloriesTextBlock.Text = "Calories: " + toEdit.Calories;
            priceTextBlock.Text = "Price: " + toEdit.Price;
            
            if (toEdit is Entree)
            {
                if (toEdit is BriarheartBurger)
                {
                    DataContext = toEdit as BriarheartBurger;

                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox bun = new CheckBox();
                    bun.Content = "Bun";
                    Binding bindingBun = new Binding("Bun");
                    bindingBun.Source = DataContext;
                    bun.SetBinding(CheckBox.IsCheckedProperty, bindingBun);
                    optionsStackPanel.Children.Add(bun);

                    CheckBox ketchup = new CheckBox();
                    ketchup.Content = "Ketchup";
                    Binding bindingKetchup = new Binding("Ketchup");
                    bindingKetchup.Source = DataContext;
                    ketchup.SetBinding(CheckBox.IsCheckedProperty, bindingKetchup);
                    optionsStackPanel.Children.Add(ketchup);

                    CheckBox mustard = new CheckBox();
                    mustard.Content = "Mustard";
                    Binding bindingMustard = new Binding("Mustard");
                    bindingMustard.Source = DataContext;
                    mustard.SetBinding(CheckBox.IsCheckedProperty, bindingMustard);
                    optionsStackPanel.Children.Add(mustard);

                    CheckBox pickle = new CheckBox();
                    pickle.Content = "Pickle";
                    Binding bindingPickle = new Binding("Pickle");
                    bindingPickle.Source = DataContext;
                    pickle.SetBinding(CheckBox.IsCheckedProperty, bindingPickle);
                    optionsStackPanel.Children.Add(pickle);

                    CheckBox cheese = new CheckBox();
                    cheese.Content = "Cheese";
                    Binding bindingCheese = new Binding("Cheese");
                    bindingCheese.Source = DataContext;
                    cheese.SetBinding(CheckBox.IsCheckedProperty, bindingCheese);
                    optionsStackPanel.Children.Add(cheese);

                }
                else if (toEdit is DoubleDraugr)
                {
                    DataContext = toEdit as DoubleDraugr;

                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox bun = new CheckBox();
                    bun.Content = "Bun";
                    Binding bindingBun = new Binding("Bun");
                    bindingBun.Source = DataContext;
                    bun.SetBinding(CheckBox.IsCheckedProperty, bindingBun);
                    optionsStackPanel.Children.Add(bun);

                    CheckBox ketchup = new CheckBox();
                    ketchup.Content = "Ketchup";
                    Binding bindingKetchup = new Binding("Ketchup");
                    bindingKetchup.Source = DataContext;
                    ketchup.SetBinding(CheckBox.IsCheckedProperty, bindingKetchup);
                    optionsStackPanel.Children.Add(ketchup);

                    CheckBox mustard = new CheckBox();
                    mustard.Content = "Mustard";
                    Binding bindingMustard = new Binding("Mustard");
                    bindingMustard.Source = DataContext;
                    mustard.SetBinding(CheckBox.IsCheckedProperty, bindingMustard);
                    optionsStackPanel.Children.Add(mustard);

                    CheckBox pickle = new CheckBox();
                    pickle.Content = "Pickle";
                    Binding bindingPickle = new Binding("Pickle");
                    bindingPickle.Source = DataContext;
                    pickle.SetBinding(CheckBox.IsCheckedProperty, bindingPickle);
                    optionsStackPanel.Children.Add(pickle);

                    CheckBox cheese = new CheckBox();
                    cheese.Content = "Cheese";
                    Binding bindingCheese = new Binding("Cheese");
                    bindingCheese.Source = DataContext;
                    cheese.SetBinding(CheckBox.IsCheckedProperty, bindingCheese);
                    optionsStackPanel.Children.Add(cheese);

                    CheckBox tomato = new CheckBox();
                    tomato.Content = "Tomato";
                    Binding bindingTomato = new Binding("Tomato");
                    bindingTomato.Source = DataContext;
                    tomato.SetBinding(CheckBox.IsCheckedProperty, bindingTomato);
                    optionsStackPanel.Children.Add(tomato);

                    CheckBox lettuce = new CheckBox();
                    lettuce.Content = "Lettuce";
                    Binding bindingLettuce = new Binding("Lettuce");
                    bindingLettuce.Source = DataContext;
                    lettuce.SetBinding(CheckBox.IsCheckedProperty, bindingLettuce);
                    optionsStackPanel.Children.Add(lettuce);

                    CheckBox mayo = new CheckBox();
                    mayo.Content = "Mayo";
                    Binding bindingMayo = new Binding("Mayo");
                    bindingMayo.Source = DataContext;
                    mayo.SetBinding(CheckBox.IsCheckedProperty, bindingMayo);
                    optionsStackPanel.Children.Add(mayo);
                }
                else if (toEdit is GardenOrcOmelette)
                {
                    DataContext = toEdit as GardenOrcOmelette;

                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox broccoli = new CheckBox();
                    broccoli.Content = "Broccoli";
                    Binding bindingBroccoli = new Binding("Broccoli");
                    bindingBroccoli.Source = DataContext;
                    broccoli.SetBinding(CheckBox.IsCheckedProperty, bindingBroccoli);
                    optionsStackPanel.Children.Add(broccoli);

                    CheckBox mushrooms = new CheckBox();
                    mushrooms.Content = "Mushrooms";
                    Binding bindingMushrooms = new Binding("Mushrooms");
                    bindingMushrooms.Source = DataContext;
                    mushrooms.SetBinding(CheckBox.IsCheckedProperty, bindingMushrooms);
                    optionsStackPanel.Children.Add(mushrooms);

                    CheckBox tomato = new CheckBox();
                    tomato.Content = "Tomato";
                    Binding bindingTomato = new Binding("Tomato");
                    bindingTomato.Source = DataContext;
                    tomato.SetBinding(CheckBox.IsCheckedProperty, bindingTomato);
                    optionsStackPanel.Children.Add(tomato);

                    CheckBox cheddar = new CheckBox();
                    cheddar.Content = "Cheddar";
                    Binding bindingCheddar = new Binding("Cheddar");
                    bindingCheddar.Source = DataContext;
                    cheddar.SetBinding(CheckBox.IsCheckedProperty, bindingCheddar);
                    optionsStackPanel.Children.Add(cheddar);
                }
                else if (toEdit is PhillyPoacher)
                {
                    DataContext = toEdit as PhillyPoacher;

                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox sirloin = new CheckBox();
                    sirloin.Content = "Sirloin";
                    Binding bindingSirloin = new Binding("Sirloin");
                    bindingSirloin.Source = DataContext;
                    sirloin.SetBinding(CheckBox.IsCheckedProperty, bindingSirloin);
                    optionsStackPanel.Children.Add(sirloin);

                    CheckBox onion = new CheckBox();
                    onion.Content = "Onions";
                    Binding bindingOnion = new Binding("Onion");
                    bindingOnion.Source = DataContext;
                    onion.SetBinding(CheckBox.IsCheckedProperty, bindingOnion);
                    optionsStackPanel.Children.Add(onion);

                    CheckBox roll = new CheckBox();
                    roll.Content = "Roll";
                    Binding bindingRoll = new Binding("Roll");
                    bindingRoll.Source = DataContext;
                    roll.SetBinding(CheckBox.IsCheckedProperty, bindingRoll);
                    optionsStackPanel.Children.Add(roll);
                }
                else if (toEdit is SmokehouseSkeleton)
                {
                    DataContext = toEdit as SmokehouseSkeleton;

                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox sausage = new CheckBox();
                    sausage.Content = "Sausage";
                    Binding bindingSausage = new Binding("SausageLink");
                    bindingSausage.Source = DataContext;
                    sausage.SetBinding(CheckBox.IsCheckedProperty, bindingSausage);
                    optionsStackPanel.Children.Add(sausage);

                    CheckBox egg = new CheckBox();
                    egg.Content = "Eggs";
                    Binding bindingEgg = new Binding("Egg");
                    bindingEgg.Source = DataContext;
                    egg.SetBinding(CheckBox.IsCheckedProperty, bindingEgg);
                    optionsStackPanel.Children.Add(egg);

                    CheckBox hash = new CheckBox();
                    hash.Content = "Hash Browns";
                    Binding bindingHash = new Binding("HashBrowns");
                    bindingHash.Source = DataContext;
                    hash.SetBinding(CheckBox.IsCheckedProperty, bindingHash);
                    optionsStackPanel.Children.Add(hash);

                    CheckBox pancake = new CheckBox();
                    pancake.Content = "Pancakes";
                    Binding bindingPancake = new Binding("Pancake");
                    bindingPancake.Source = DataContext;
                    pancake.SetBinding(CheckBox.IsCheckedProperty, bindingPancake);
                    optionsStackPanel.Children.Add(pancake);
                }
                else if (toEdit is ThalmorTriple)
                {
                    DataContext = toEdit as ThalmorTriple;

                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox bun = new CheckBox();
                    bun.Content = "Bun";
                    Binding bindingBun = new Binding("Bun");
                    bindingBun.Source = DataContext;
                    bun.SetBinding(CheckBox.IsCheckedProperty, bindingBun);
                    optionsStackPanel.Children.Add(bun);

                    CheckBox ketchup = new CheckBox();
                    ketchup.Content = "Ketchup";
                    Binding bindingKetchup = new Binding("Ketchup");
                    bindingKetchup.Source = DataContext;
                    ketchup.SetBinding(CheckBox.IsCheckedProperty, bindingKetchup);
                    optionsStackPanel.Children.Add(ketchup);

                    CheckBox mustard = new CheckBox();
                    mustard.Content = "Mustard";
                    Binding bindingMustard = new Binding("Mustard");
                    bindingMustard.Source = DataContext;
                    mustard.SetBinding(CheckBox.IsCheckedProperty, bindingMustard);
                    optionsStackPanel.Children.Add(mustard);

                    CheckBox pickle = new CheckBox();
                    pickle.Content = "Pickle";
                    Binding bindingPickle = new Binding("Pickle");
                    bindingPickle.Source = DataContext;
                    pickle.SetBinding(CheckBox.IsCheckedProperty, bindingPickle);
                    optionsStackPanel.Children.Add(pickle);

                    CheckBox cheese = new CheckBox();
                    cheese.Content = "Cheese";
                    Binding bindingCheese = new Binding("Cheese");
                    bindingCheese.Source = DataContext;
                    cheese.SetBinding(CheckBox.IsCheckedProperty, bindingCheese);
                    optionsStackPanel.Children.Add(cheese);

                    CheckBox tomato = new CheckBox();
                    tomato.Content = "Tomato";
                    Binding bindingTomato = new Binding("Tomato");
                    bindingTomato.Source = DataContext;
                    tomato.SetBinding(CheckBox.IsCheckedProperty, bindingTomato);
                    optionsStackPanel.Children.Add(tomato);

                    CheckBox lettuce = new CheckBox();
                    lettuce.Content = "Lettuce";
                    Binding bindingLettuce = new Binding("Lettuce");
                    bindingLettuce.Source = DataContext;
                    lettuce.SetBinding(CheckBox.IsCheckedProperty, bindingLettuce);
                    optionsStackPanel.Children.Add(lettuce);

                    CheckBox mayo = new CheckBox();
                    mayo.Content = "Mayo";
                    Binding bindingMayo = new Binding("Mayo");
                    bindingMayo.Source = DataContext;
                    mayo.SetBinding(CheckBox.IsCheckedProperty, bindingMayo);
                    optionsStackPanel.Children.Add(mayo);

                    CheckBox bacon = new CheckBox();
                    bacon.Content = "Bacon";
                    Binding bindingBacon = new Binding("Bacon");
                    bindingBacon.Source = DataContext;
                    bacon.SetBinding(CheckBox.IsCheckedProperty, bindingBacon);
                    optionsStackPanel.Children.Add(bacon);

                    CheckBox egg = new CheckBox();
                    egg.Content = "Egg";
                    Binding bindingEgg = new Binding("Egg");
                    bindingEgg.Source = DataContext;
                    egg.SetBinding(CheckBox.IsCheckedProperty, bindingEgg);
                    optionsStackPanel.Children.Add(egg);
                }
                else if (toEdit is ThugsTBone)
                {
                    DataContext = toEdit as ThugsTBone;

                    TextBlock tb = new TextBlock();
                    tb.Text = "No editing options available";
                    optionsStackPanel.Children.Add(tb);
                }
            }



            else if (toEdit is Side)
            {
                DataContext = toEdit as Side;
                
                TextBlock sizeHeader = new TextBlock();
                sizeHeader.Text = "Size:";
                optionsStackPanel.Children.Add(sizeHeader);

                SizeChanger sizes = new SizeChanger();
                sizes.DataContext = toEdit as Side;

                Binding bindingSize = new Binding("Size");
                bindingSize.Source = DataContext;
                sizes.lBox.SetBinding(ListBox.SelectedItemProperty, bindingSize);

                optionsStackPanel.Children.Add(sizes);
            }



            else if (toEdit is Drink)
            {
                if (toEdit is AretinoAppleJuice)
                {
                    DataContext = toEdit as AretinoAppleJuice;

                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox ice = new CheckBox();
                    ice.Content = "Ice";
                    Binding bindingIce = new Binding("Ice");
                    bindingIce.Source = DataContext;
                    ice.SetBinding(CheckBox.IsCheckedProperty, bindingIce);
                    optionsStackPanel.Children.Add(ice);
                }
                else if (toEdit is CandlehearthCoffee)
                {
                    DataContext = toEdit as CandlehearthCoffee;


                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox ice = new CheckBox();
                    ice.Content = "Ice";
                    Binding bindingIce = new Binding("Ice");
                    bindingIce.Source = DataContext;
                    ice.SetBinding(CheckBox.IsCheckedProperty, bindingIce);
                    optionsStackPanel.Children.Add(ice);

                    CheckBox cream = new CheckBox();
                    cream.Content = "Room for Cream";
                    Binding bindingCream = new Binding("RoomForCream");
                    bindingCream.Source = DataContext;
                    cream.SetBinding(CheckBox.IsCheckedProperty, bindingCream);
                    optionsStackPanel.Children.Add(cream);

                    CheckBox decaf = new CheckBox();
                    decaf.Content = "Decaf";
                    Binding bindingDecaf = new Binding("Decaf");
                    bindingDecaf.Source = DataContext;
                    decaf.SetBinding(CheckBox.IsCheckedProperty, bindingDecaf);
                    optionsStackPanel.Children.Add(decaf);
                }
                else if (toEdit is MarkarthMilk)
                {
                    DataContext = toEdit as MarkarthMilk;

                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox ice = new CheckBox();
                    ice.Content = "Ice";
                    Binding bindingIce = new Binding("Ice");
                    bindingIce.Source = DataContext;
                    ice.SetBinding(CheckBox.IsCheckedProperty, bindingIce);
                    optionsStackPanel.Children.Add(ice);
                }
                else if (toEdit is SailorSoda)
                {
                    DataContext = toEdit as SailorSoda;

                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox ice = new CheckBox();
                    ice.Content = "Ice";
                    Binding bindingIce = new Binding("Ice");
                    bindingIce.Source = DataContext;
                    ice.SetBinding(CheckBox.IsCheckedProperty, bindingIce);
                    optionsStackPanel.Children.Add(ice);

                    TextBlock flavorHeader = new TextBlock();
                    flavorHeader.Text = "Flavor:";
                    optionsStackPanel.Children.Add(flavorHeader);

                    FlavorChanger flavors = new FlavorChanger();
                    flavors.lBox.DataContext = toEdit as SailorSoda;

                    Binding bindingFlavor = new Binding("Flavor");
                    bindingFlavor.Source = DataContext;
                    flavors.lBox.SetBinding(ListBox.SelectedItemProperty, bindingFlavor);

                    optionsStackPanel.Children.Add(flavors);
                }
                else if (toEdit is WarriorWater)
                {
                    DataContext = toEdit as WarriorWater;
                    
                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox ice = new CheckBox();
                    ice.Content = "Ice";
                    Binding bindingIce = new Binding("Ice");
                    bindingIce.Source = DataContext;
                    ice.SetBinding(CheckBox.IsCheckedProperty, bindingIce);
                    optionsStackPanel.Children.Add(ice);

                    CheckBox lemon = new CheckBox();
                    lemon.Content = "Lemon";
                    Binding bindingLemon = new Binding("Lemon");
                    bindingLemon.Source = DataContext;
                    lemon.SetBinding(CheckBox.IsCheckedProperty, bindingLemon);
                    optionsStackPanel.Children.Add(lemon);
                }

                TextBlock sizeHeader = new TextBlock();
                sizeHeader.Text = "Size:";
                optionsStackPanel.Children.Add(sizeHeader);

                SizeChanger sizes = new SizeChanger();
                sizes.DataContext = toEdit as Drink;

                Binding bindingSize = new Binding("Size");
                bindingSize.Source = DataContext;
                sizes.lBox.SetBinding(ListBox.SelectedItemProperty, bindingSize);

                optionsStackPanel.Children.Add(sizes);
            }
        }
    }
}
