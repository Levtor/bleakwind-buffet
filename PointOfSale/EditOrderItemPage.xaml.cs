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
        /// Holds the index which refers to the location in the listview of the OrderComponent where
        /// the OrderItem being edited is located
        /// </summary>
        public int index;
        
        /// <summary>
        /// Creates the EditOrderItemPage
        /// </summary>
        public EditOrderItemPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Fills the instance with the appropriate controls, based on the item which 
        /// is to be edited by the component
        /// </summary>
        /// <param name="toEdit"></param>
        public void Setup(IOrderItem toEdit)
        {
            headerTextBlock.Text = "Edit " + toEdit.ToString() +" Order";
            caloriesTextBlock.Text = "Calories: " + toEdit.Calories;
            priceTextBlock.Text = "Price: " + toEdit.Price;
            
            if (toEdit is Entree)
            {
                if (toEdit is BriarheartBurger)
                {
                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox bun = new CheckBox();
                    bun.Content = "Bun";
                    bun.Name = "bunBox";
                    bun.IsChecked = (toEdit as BriarheartBurger).Bun;
                    optionsStackPanel.Children.Add(bun);

                    CheckBox ketchup = new CheckBox();
                    ketchup.Content = "Ketchup";
                    ketchup.Name = "ketchupBox";
                    ketchup.IsChecked = (toEdit as BriarheartBurger).Ketchup;
                    optionsStackPanel.Children.Add(ketchup);

                    CheckBox mustard = new CheckBox();
                    mustard.Content = "Mustard";
                    mustard.Name = "mustardBox";
                    mustard.IsChecked = (toEdit as BriarheartBurger).Mustard;
                    optionsStackPanel.Children.Add(mustard);

                    CheckBox pickle = new CheckBox();
                    pickle.Content = "Pickle";
                    pickle.Name = "pickleBox";
                    pickle.IsChecked = (toEdit as BriarheartBurger).Pickle;
                    optionsStackPanel.Children.Add(pickle);

                    CheckBox cheese = new CheckBox();
                    cheese.Content = "Cheese";
                    cheese.Name = "cheeseBox";
                    cheese.IsChecked = (toEdit as BriarheartBurger).Cheese;
                    optionsStackPanel.Children.Add(cheese);

                }
                else if (toEdit is DoubleDraugr)
                {
                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox bun = new CheckBox();
                    bun.Content = "Bun";
                    bun.Name = "bunBox";
                    bun.IsChecked = (toEdit as DoubleDraugr).Bun;
                    optionsStackPanel.Children.Add(bun);

                    CheckBox ketchup = new CheckBox();
                    ketchup.Content = "Ketchup";
                    ketchup.Name = "ketchupBox";
                    ketchup.IsChecked = (toEdit as DoubleDraugr).Ketchup;
                    optionsStackPanel.Children.Add(ketchup);

                    CheckBox mustard = new CheckBox();
                    mustard.Content = "Mustard";
                    mustard.Name = "mustardBox";
                    mustard.IsChecked = (toEdit as DoubleDraugr).Mustard;
                    optionsStackPanel.Children.Add(mustard);

                    CheckBox pickle = new CheckBox();
                    pickle.Content = "Pickle";
                    pickle.Name = "pickleBox";
                    pickle.IsChecked = (toEdit as DoubleDraugr).Pickle;
                    optionsStackPanel.Children.Add(pickle);

                    CheckBox cheese = new CheckBox();
                    cheese.Content = "Cheese";
                    cheese.Name = "cheeseBox";
                    cheese.IsChecked = (toEdit as DoubleDraugr).Cheese;
                    optionsStackPanel.Children.Add(cheese);

                    CheckBox tomato = new CheckBox();
                    tomato.Content = "Tomato";
                    tomato.Name = "tomatoBox";
                    tomato.IsChecked = (toEdit as DoubleDraugr).Tomato;
                    optionsStackPanel.Children.Add(tomato);

                    CheckBox lettuce = new CheckBox();
                    lettuce.Content = "Lettuce";
                    lettuce.Name = "lettuceBox";
                    lettuce.IsChecked = (toEdit as DoubleDraugr).Lettuce;
                    optionsStackPanel.Children.Add(lettuce);

                    CheckBox mayo = new CheckBox();
                    mayo.Content = "Mayo";
                    mayo.Name = "mayoBox";
                    mayo.IsChecked = (toEdit as DoubleDraugr).Mayo;
                    optionsStackPanel.Children.Add(mayo);
                }
                else if (toEdit is GardenOrcOmelette)
                {
                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox broccoli = new CheckBox();
                    broccoli.Content = "Broccoli";
                    broccoli.Name = "broccoliBox";
                    broccoli.IsChecked = (toEdit as GardenOrcOmelette).Broccoli;
                    optionsStackPanel.Children.Add(broccoli);

                    CheckBox mushrooms = new CheckBox();
                    mushrooms.Content = "Mushrooms";
                    mushrooms.Name = "mushroomsBox";
                    mushrooms.IsChecked = (toEdit as GardenOrcOmelette).Mushrooms;
                    optionsStackPanel.Children.Add(mushrooms);

                    CheckBox tomato = new CheckBox();
                    tomato.Content = "Tomato";
                    tomato.Name = "tomatoBox";
                    tomato.IsChecked = (toEdit as GardenOrcOmelette).Tomato;
                    optionsStackPanel.Children.Add(tomato);

                    CheckBox cheddar = new CheckBox();
                    cheddar.Content = "Cheddar";
                    cheddar.Name = "cheddarBox";
                    cheddar.IsChecked = (toEdit as GardenOrcOmelette).Cheddar;
                    optionsStackPanel.Children.Add(cheddar);
                }
                else if (toEdit is PhillyPoacher)
                {
                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox sirloin = new CheckBox();
                    sirloin.Content = "Sirloin";
                    sirloin.Name = "sirloinBox";
                    sirloin.IsChecked = (toEdit as PhillyPoacher).Sirloin;
                    optionsStackPanel.Children.Add(sirloin);

                    CheckBox onion = new CheckBox();
                    onion.Content = "Onions";
                    onion.Name = "onionBox";
                    onion.IsChecked = (toEdit as PhillyPoacher).Onion;
                    optionsStackPanel.Children.Add(onion);

                    CheckBox roll = new CheckBox();
                    roll.Content = "Roll";
                    roll.Name = "rollBox";
                    roll.IsChecked = (toEdit as PhillyPoacher).Roll;
                    optionsStackPanel.Children.Add(roll);
                }
                else if (toEdit is SmokehouseSkeleton)
                {
                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox sausage = new CheckBox();
                    sausage.Content = "Sausage";
                    sausage.Name = "sausageBox";
                    sausage.IsChecked = (toEdit as SmokehouseSkeleton).SausageLink;
                    optionsStackPanel.Children.Add(sausage);

                    CheckBox egg = new CheckBox();
                    egg.Content = "Eggs";
                    egg.Name = "eggBox";
                    egg.IsChecked = (toEdit as SmokehouseSkeleton).Egg;
                    optionsStackPanel.Children.Add(egg);

                    CheckBox hash = new CheckBox();
                    hash.Content = "Hash Browns";
                    hash.Name = "hashBox";
                    hash.IsChecked = (toEdit as SmokehouseSkeleton).HashBrowns;
                    optionsStackPanel.Children.Add(hash);

                    CheckBox pancake = new CheckBox();
                    pancake.Content = "Pancakes";
                    pancake.Name = "pancakeBox";
                    pancake.IsChecked = (toEdit as SmokehouseSkeleton).Pancake;
                    optionsStackPanel.Children.Add(pancake);
                }
                else if (toEdit is ThalmorTriple)
                {
                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox bun = new CheckBox();
                    bun.Content = "Bun";
                    bun.Name = "bunBox";
                    bun.IsChecked = (toEdit as ThalmorTriple).Bun;
                    optionsStackPanel.Children.Add(bun);

                    CheckBox ketchup = new CheckBox();
                    ketchup.Content = "Ketchup";
                    ketchup.Name = "ketchupBox";
                    ketchup.IsChecked = (toEdit as ThalmorTriple).Ketchup;
                    optionsStackPanel.Children.Add(ketchup);

                    CheckBox mustard = new CheckBox();
                    mustard.Content = "Mustard";
                    mustard.Name = "mustardBox";
                    mustard.IsChecked = (toEdit as ThalmorTriple).Mustard;
                    optionsStackPanel.Children.Add(mustard);

                    CheckBox pickle = new CheckBox();
                    pickle.Content = "Pickle";
                    pickle.Name = "pickleBox";
                    pickle.IsChecked = (toEdit as ThalmorTriple).Pickle;
                    optionsStackPanel.Children.Add(pickle);

                    CheckBox cheese = new CheckBox();
                    cheese.Content = "Cheese";
                    cheese.Name = "cheeseBox";
                    cheese.IsChecked = (toEdit as ThalmorTriple).Cheese;
                    optionsStackPanel.Children.Add(cheese);

                    CheckBox tomato = new CheckBox();
                    tomato.Content = "Tomato";
                    tomato.Name = "tomatoBox";
                    tomato.IsChecked = (toEdit as ThalmorTriple).Tomato;
                    optionsStackPanel.Children.Add(tomato);

                    CheckBox lettuce = new CheckBox();
                    lettuce.Content = "Lettuce";
                    lettuce.Name = "lettuceBox";
                    lettuce.IsChecked = (toEdit as ThalmorTriple).Lettuce;
                    optionsStackPanel.Children.Add(lettuce);

                    CheckBox mayo = new CheckBox();
                    mayo.Content = "Mayo";
                    mayo.Name = "mayoBox";
                    mayo.IsChecked = (toEdit as ThalmorTriple).Mayo;
                    optionsStackPanel.Children.Add(mayo);

                    CheckBox bacon = new CheckBox();
                    bacon.Content = "Bacon";
                    bacon.Name = "baconBox";
                    bacon.IsChecked = (toEdit as ThalmorTriple).Bacon;
                    optionsStackPanel.Children.Add(bacon);

                    CheckBox egg = new CheckBox();
                    egg.Content = "Egg";
                    egg.Name = "eggBox";
                    egg.IsChecked = (toEdit as ThalmorTriple).Egg;
                    optionsStackPanel.Children.Add(egg);
                }
                else if (toEdit is ThugsTBone)
                {
                    TextBlock tb = new TextBlock();
                    tb.Text = "No editing options available";
                    optionsStackPanel.Children.Add(tb);
                }
            }
            else if (toEdit is Side)
            {
                TextBlock sizeHeader = new TextBlock();
                sizeHeader.Text = "Size:";
                optionsStackPanel.Children.Add(sizeHeader);
                
                RadioButton small = new RadioButton();
                small.Content = "Small";
                small.GroupName = "sizes";
                small.Name = "smallRadioButton";
                small.IsChecked = (toEdit as Side).Size == BleakwindBuffet.Data.Enums.Size.Small;
                optionsStackPanel.Children.Add(small);

                RadioButton medium = new RadioButton();
                medium.Content = "Medium";
                medium.GroupName = "sizes";
                medium.Name = "mediumRadioButton";
                medium.IsChecked = (toEdit as Side).Size == BleakwindBuffet.Data.Enums.Size.Medium;
                optionsStackPanel.Children.Add(medium);

                RadioButton large = new RadioButton();
                large.Content = "Large";
                large.GroupName = "sizes";
                large.Name = "largeRadioButton";
                large.IsChecked = (toEdit as Side).Size == BleakwindBuffet.Data.Enums.Size.Large;
                optionsStackPanel.Children.Add(large);
            }
            else if (toEdit is Drink)
            {
                TextBlock sizeHeader = new TextBlock();
                sizeHeader.Text = "Size:";
                optionsStackPanel.Children.Add(sizeHeader);

                RadioButton small = new RadioButton();
                small.Content = "Small";
                small.GroupName = "sizes";
                small.Name = "smallRadioButton";
                small.IsChecked = (toEdit as Drink).Size == BleakwindBuffet.Data.Enums.Size.Small;
                optionsStackPanel.Children.Add(small);

                RadioButton medium = new RadioButton();
                medium.Content = "Medium";
                medium.GroupName = "sizes";
                medium.Name = "mediumRadioButton";
                medium.IsChecked = (toEdit as Drink).Size == BleakwindBuffet.Data.Enums.Size.Medium;
                optionsStackPanel.Children.Add(medium);

                RadioButton large = new RadioButton();
                large.Content = "Large";
                large.GroupName = "sizes";
                large.Name = "largeRadioButton";
                large.IsChecked = (toEdit as Drink).Size == BleakwindBuffet.Data.Enums.Size.Large;
                optionsStackPanel.Children.Add(large);

                if (toEdit is AretinoAppleJuice)
                {
                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox ice = new CheckBox();
                    ice.Content = "Ice";
                    ice.Name = "iceBox";
                    ice.IsChecked = (toEdit as AretinoAppleJuice).Ice;
                    optionsStackPanel.Children.Add(ice);
                }
                else if (toEdit is CandlehearthCoffee)
                {
                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox ice = new CheckBox();
                    ice.Content = "Ice";
                    ice.Name = "iceBox";
                    ice.IsChecked = (toEdit as CandlehearthCoffee).Ice;
                    optionsStackPanel.Children.Add(ice);

                    CheckBox cream = new CheckBox();
                    cream.Content = "Room for Cream";
                    cream.Name = "creamBox";
                    cream.IsChecked = (toEdit as CandlehearthCoffee).RoomForCream;
                    optionsStackPanel.Children.Add(cream);

                    CheckBox decaf = new CheckBox();
                    decaf.Content = "Ice";
                    decaf.Name = "iceBox";
                    decaf.IsChecked = (toEdit as CandlehearthCoffee).Decaf;
                    optionsStackPanel.Children.Add(decaf);
                }
                else if (toEdit is MarkarthMilk)
                {
                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox ice = new CheckBox();
                    ice.Content = "Ice";
                    ice.Name = "iceBox";
                    ice.IsChecked = (toEdit as MarkarthMilk).Ice;
                    optionsStackPanel.Children.Add(ice);
                }
                else if (toEdit is SailorSoda)
                {
                    TextBlock flavorHeader = new TextBlock();
                    flavorHeader.Text = "Flavor:";
                    optionsStackPanel.Children.Add(flavorHeader);

                    RadioButton blackberry = new RadioButton();
                    blackberry.Content = "Blackberry";
                    blackberry.GroupName = "flavors";
                    blackberry.Name = "blackberryRadioButton";
                    blackberry.IsChecked = (toEdit as SailorSoda).Flavor == SodaFlavor.Blackberry;
                    optionsStackPanel.Children.Add(blackberry);

                    RadioButton cherry = new RadioButton();
                    cherry.Content = "Cherry";
                    cherry.GroupName = "flavors";
                    cherry.Name = "cherryRadioButton";
                    cherry.IsChecked = (toEdit as SailorSoda).Flavor == SodaFlavor.Cherry;
                    optionsStackPanel.Children.Add(cherry);

                    RadioButton grapefruit = new RadioButton();
                    grapefruit.Content = "Grapefruit";
                    grapefruit.GroupName = "flavors";
                    grapefruit.Name = "grapefruitRadioButton";
                    grapefruit.IsChecked = (toEdit as SailorSoda).Flavor == SodaFlavor.Grapefruit;
                    optionsStackPanel.Children.Add(grapefruit);

                    RadioButton lemon = new RadioButton();
                    lemon.Content = "Lemon";
                    lemon.GroupName = "flavors";
                    lemon.Name = "lemonRadioButton";
                    lemon.IsChecked = (toEdit as SailorSoda).Flavor == SodaFlavor.Lemon;
                    optionsStackPanel.Children.Add(lemon);

                    RadioButton peach = new RadioButton();
                    peach.Content = "Peach";
                    peach.GroupName = "flavors";
                    peach.Name = "peachRadioButton";
                    peach.IsChecked = (toEdit as SailorSoda).Flavor == SodaFlavor.Peach;
                    optionsStackPanel.Children.Add(peach);

                    RadioButton watermelon = new RadioButton();
                    watermelon.Content = "Watermelon";
                    watermelon.GroupName = "flavors";
                    watermelon.Name = "watermelonRadioButton";
                    watermelon.IsChecked = (toEdit as SailorSoda).Flavor == SodaFlavor.Watermelon;
                    optionsStackPanel.Children.Add(watermelon);

                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox ice = new CheckBox();
                    ice.Content = "Ice";
                    ice.Name = "iceBox";
                    ice.IsChecked = (toEdit as SailorSoda).Ice;
                    optionsStackPanel.Children.Add(ice);
                }
                else if (toEdit is WarriorWater)
                {
                    TextBlock optionsHeader = new TextBlock();
                    optionsHeader.Text = "Options:";
                    optionsStackPanel.Children.Add(optionsHeader);

                    CheckBox ice = new CheckBox();
                    ice.Content = "Ice";
                    ice.Name = "iceBox";
                    ice.IsChecked = (toEdit as WarriorWater).Ice;
                    optionsStackPanel.Children.Add(ice);

                    CheckBox lemon = new CheckBox();
                    lemon.Content = "Lemon";
                    lemon.Name = "lemonBox";
                    lemon.IsChecked = (toEdit as WarriorWater).Lemon;
                    optionsStackPanel.Children.Add(lemon);
                }
            }
        }
    }
}
