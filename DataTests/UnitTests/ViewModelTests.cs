/*
 * Author: Joseph Hathaway
 * Class: ViewModelTests.cs
 * Purpose: Test the ViewModel.cs class in the Data library
 */
using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Enums;
using Xunit;
using BleakwindBuffet.Data;
using System.Resources;
using System.Transactions;
using PointOfSale;
using RoundRegister;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class ViewModelTests
    {
        [Fact]
        public void InPropertyChangesNotifyPropertyChanged()
        {
            var vm = new ViewModel(189.92);

            Assert.PropertyChanged(vm, "b100In", () =>
            {
                vm.b100In = 1;
            });
            Assert.PropertyChanged(vm, "b50In", () =>
            {
                vm.b50In = 1;
            });
            Assert.PropertyChanged(vm, "b20In", () =>
            {
                vm.b20In = 1;
            });
            Assert.PropertyChanged(vm, "b10In", () =>
            {
                vm.b10In = 1;
            });
            Assert.PropertyChanged(vm, "b5In", () =>
            {
                vm.b5In = 1;
            });
            Assert.PropertyChanged(vm, "b2In", () =>
            {
                vm.b2In = 1;
            });
            Assert.PropertyChanged(vm, "b1In", () =>
            {
                vm.b1In = 1;
            });
            Assert.PropertyChanged(vm, "c100In", () =>
            {
                vm.c100In = 1;
            });
            Assert.PropertyChanged(vm, "c50In", () =>
            {
                vm.c50In = 1;
            });
            Assert.PropertyChanged(vm, "c25In", () =>
            {
                vm.c25In = 1;
            });
            Assert.PropertyChanged(vm, "c10In", () =>
            {
                vm.c10In = 1;
            });
            Assert.PropertyChanged(vm, "c5In", () =>
            {
                vm.c5In = 1;
            });
            Assert.PropertyChanged(vm, "c1In", () =>
            {
                vm.c1In = 1;
            });
        }

        [Fact]
        public void MoveMoneyUpdatesCashDrawer()
        {
            CashDrawer.ResetDrawer();

            var vm = new ViewModel(180);

            int a = vm.b100Have;
            int b = vm.b50Have;
            int c = vm.b20Have;
            int d = vm.b10Have;
            int e = vm.b5Have;
            int f = vm.b2Have;
            int g = vm.b1Have;
            int h = vm.c100Have;
            int i = vm.c50Have;
            int j = vm.c25Have;
            int k = vm.c10Have;
            int l = vm.c5Have;
            int m = vm.c1Have;

            vm.b100In = 1;
            vm.b50In = 1;
            vm.b20In = 1;
            vm.b10In = 1;
            vm.b5In = 1;
            vm.b2In = 1;
            vm.b1In = 1;
            vm.c100In = 1;
            vm.c50In = 1;
            vm.c25In = 1;
            vm.c10In = 1;
            vm.c5In = 1;
            vm.c1In = 1;

            vm.updateChange();
            vm.moveMoney();

            Assert.Equal(a, vm.b100Have - 1);
            Assert.Equal(b, vm.b50Have - 1);
            Assert.Equal(c, vm.b20Have - 1);
            Assert.Equal(d, vm.b10Have - 1);
            Assert.Equal(e, vm.b5Have);
            Assert.Equal(f, vm.b2Have);
            Assert.Equal(g, vm.b1Have + 1);
            Assert.Equal(h, vm.c100Have - 1);
            Assert.Equal(i, vm.c50Have);
            Assert.Equal(j, vm.c25Have);
            Assert.Equal(k, vm.c10Have);
            Assert.Equal(l, vm.c5Have);
            Assert.Equal(m, vm.c1Have);
        }

        [Fact]
        public void RunningPrintReceiptDoesntCrashAnything()
        {
            var ord = new Order();
            var combo = new Combo();
            combo.Drink = new AretinoAppleJuice();
            (combo.Drink as AretinoAppleJuice).Ice = !(combo.Drink as AretinoAppleJuice).Ice;
            combo.Side = new DragonbornWaffleFries();
            (combo.Side as DragonbornWaffleFries).Size = Size.Medium;
            combo.Entree = new BriarheartBurger();
            (combo.Entree as BriarheartBurger).Ketchup = false;
            (combo.Entree as BriarheartBurger).Mustard = false;
            ord.Add(combo);
            ord.Add(new BriarheartBurger());
            var vm = new ViewModel(ord.Total);
            vm.printReceipt(ord, false);
        }

        [Fact]
        public void CalculateDebtDoesSo()
        {
            var vm = new ViewModel(189.92);

            vm.b100In = 1;
            vm.b50In = 1;
            vm.b20In = 1;
            vm.b10In = 1;
            vm.b5In = 1;
            vm.b2In = 1;
            vm.b1In = 1;
            vm.c100In = 1;
            vm.c50In = 1;
            vm.c25In = 1;
            vm.c10In = 1;
            vm.c5In = 1;
            vm.c1In = 1;

            Assert.Equal(0.01, vm.calculateDebt());
        }

        [Theory]
        [InlineData(10.25, 189.75)]
        [InlineData(189.92, 10.08)]
        [InlineData(500, 0)]
        public void CalculateChangeDoesSoANDUpdateChangeDoesSo(double inn, double outt)
        {
            CashDrawer.ResetDrawer();
            
            var vm = new ViewModel(inn);

            vm.b100In = 2;

            vm.updateChange();

            Assert.Equal(outt, vm.calculateChange());
        }
    }
}
