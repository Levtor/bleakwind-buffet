/*
* Author: Joseph Hathaway
* Class name: EditComboPage.xaml.cs
* Purpose: This is the component of the application that allows the user to edit a combo in the order
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
    /// Interaction logic for EditComboPage.xaml
    /// </summary>
    public partial class EditComboPage : UserControl
    {
        public EditComboPage(IOrderItem combo)
        {
            InitializeComponent();
            DataContext = combo as Combo;

            if ((DataContext as Combo).Entree is BriarheartBurger) BriarheartBurgerButton.IsChecked = true;
            if ((DataContext as Combo).Entree is DoubleDraugr) DoubleDraugrButton.IsChecked = true;
            if ((DataContext as Combo).Entree is GardenOrcOmelette) GardenOrcOmeletteButton.IsChecked = true;
            if ((DataContext as Combo).Entree is PhillyPoacher) PhillyPoacherButton.IsChecked = true;
            if ((DataContext as Combo).Entree is SmokehouseSkeleton) SmokehouseSkeletonButton.IsChecked = true;
            if ((DataContext as Combo).Entree is ThalmorTriple) ThalmorTripleButton.IsChecked = true;
            if ((DataContext as Combo).Entree is ThugsTBone) ThugsTBoneButton.IsChecked = true;

            if ((DataContext as Combo).Side is DragonbornWaffleFries) DragonbornWaffleFriesButton.IsChecked = true;
            if ((DataContext as Combo).Side is FriedMiraak) FriedMiraakButton.IsChecked = true;
            if ((DataContext as Combo).Side is MadOtarGrits) MadOtarGritsButton.IsChecked = true;
            if ((DataContext as Combo).Side is VokunSalad) VokunSaladButton.IsChecked = true;

            if ((DataContext as Combo).Drink is AretinoAppleJuice) AretinoAppleJuiceButton.IsChecked = true;
            if ((DataContext as Combo).Drink is CandlehearthCoffee) CandlehearthCoffeeButton.IsChecked = true;
            if ((DataContext as Combo).Drink is MarkarthMilk) MarkarthMilkButton.IsChecked = true;
            if ((DataContext as Combo).Drink is SailorSoda) SailorSodaButton.IsChecked = true;
            if ((DataContext as Combo).Drink is WarriorWater) WarriorWaterButton.IsChecked = true;
        }

        void radioClick(object sender, RoutedEventArgs e)
        {
            if ((bool)BriarheartBurgerButton.IsChecked) (DataContext as Combo).Entree = new BriarheartBurger();
            if ((bool)DoubleDraugrButton.IsChecked) (DataContext as Combo).Entree = new DoubleDraugr();
            if ((bool)GardenOrcOmeletteButton.IsChecked) (DataContext as Combo).Entree = new GardenOrcOmelette();
            if ((bool)PhillyPoacherButton.IsChecked) (DataContext as Combo).Entree = new PhillyPoacher();
            if ((bool)SmokehouseSkeletonButton.IsChecked) (DataContext as Combo).Entree = new SmokehouseSkeleton();
            if ((bool)ThalmorTripleButton.IsChecked) (DataContext as Combo).Entree = new ThalmorTriple();
            if ((bool)ThugsTBoneButton.IsChecked) (DataContext as Combo).Entree = new ThugsTBone();

            if ((bool)DragonbornWaffleFriesButton.IsChecked) (DataContext as Combo).Side = new DragonbornWaffleFries();
            if ((bool)FriedMiraakButton.IsChecked) (DataContext as Combo).Side = new FriedMiraak();
            if ((bool)MadOtarGritsButton.IsChecked) (DataContext as Combo).Side = new MadOtarGrits();
            if ((bool)VokunSaladButton.IsChecked) (DataContext as Combo).Side = new VokunSalad();

            if((bool)AretinoAppleJuiceButton.IsChecked)(DataContext as Combo).Drink = new AretinoAppleJuice();
            if ((bool)CandlehearthCoffeeButton.IsChecked) (DataContext as Combo).Drink = new CandlehearthCoffee();
            if ((bool)MarkarthMilkButton.IsChecked) (DataContext as Combo).Drink = new MarkarthMilk();
            if ((bool)SailorSodaButton.IsChecked) (DataContext as Combo).Drink = new SailorSoda();
            if ((bool)WarriorWaterButton.IsChecked) (DataContext as Combo).Drink = new WarriorWater();
        }
    }
}
