/*
* Author: Joseph Hathaway
* Class name: AddOrderItemPage.xaml.cs
* Purpose: This is the component of the application that allows the user to add items to the order
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
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for AddOrderItemPage.xaml
    /// </summary>
    public partial class AddOrderItemPage : UserControl
    {
        /// <summary>
        /// Creates an AddOrderItemPage to prompt the user to add an item to the order
        /// </summary>
        public AddOrderItemPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Finds and returns an instance of whichever OrderItem is currently selected by the radio buttons
        /// </summary>
        /// <returns>a new instance of the selected OrderItem</returns>
        public IOrderItem returnSelectedOrderItem()
        {
            if ((bool)ComboButton.IsChecked)
            {
                var ret = new Combo();
                ret.Entree = new BriarheartBurger();
                ret.Side = new DragonbornWaffleFries();
                ret.Drink = new SailorSoda();
                return ret;
            }
            if ((bool)BriarheartBurgerButton.IsChecked) return new BriarheartBurger();
            if ((bool)DoubleDraugrButton.IsChecked) return new DoubleDraugr();
            if ((bool)GardenOrcOmeletteButton.IsChecked) return new GardenOrcOmelette();
            if ((bool)PhillyPoacherButton.IsChecked) return new PhillyPoacher();
            if ((bool)SmokehouseSkeletonButton.IsChecked) return new SmokehouseSkeleton();
            if ((bool)ThalmorTripleButton.IsChecked) return new ThalmorTriple();
            if ((bool)ThugsTBoneButton.IsChecked) return new ThugsTBone();
            if ((bool)DragonbornWaffleFriesButton.IsChecked) return new DragonbornWaffleFries();
            if ((bool)FriedMiraakButton.IsChecked) return new FriedMiraak();
            if ((bool)MadOtarGritsButton.IsChecked) return new MadOtarGrits();
            if ((bool)VokunSaladButton.IsChecked) return new VokunSalad();
            if ((bool)AretinoAppleJuiceButton.IsChecked) return new AretinoAppleJuice();
            if ((bool)CandlehearthCoffeeButton.IsChecked) return new CandlehearthCoffee();
            if ((bool)MarkarthMilkButton.IsChecked) return new MarkarthMilk();
            if ((bool)SailorSodaButton.IsChecked) return new SailorSoda();
            if ((bool)WarriorWaterButton.IsChecked) return new WarriorWater();
            
            return null;
        }
    }
}
