/*
* Author: Joseph Hathaway
* Class name: ViewModel.cs
* Purpose: Helps facilitate communication between RoundRegister and the GUI
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoundRegister;
using BleakwindBuffet.Data;

namespace PointOfSale
{
    public class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private double Total;
        public ViewModel(double total)
        {
            Total = total;
        }

        /// <summary>
        /// $100 in register
        /// </summary>
        public int b100Have => CashDrawer.Hundreds;
        /// <summary>
        /// $50 in register
        /// </summary>
        public int b50Have => CashDrawer.Fifties;
        /// <summary>
        /// $20 in register
        /// </summary>
        public int b20Have => CashDrawer.Twenties;
        /// <summary>
        /// $10 in register
        /// </summary>
        public int b10Have => CashDrawer.Tens;
        /// <summary>
        /// $5 in register
        /// </summary>
        public int b5Have => CashDrawer.Fives;
        /// <summary>
        /// $2 in register
        /// </summary>
        public int b2Have => CashDrawer.Twos;
        /// <summary>
        /// $1 in register
        /// </summary>
        public int b1Have => CashDrawer.Ones;
        /// <summary>
        /// Dollar coins in register
        /// </summary>
        public int c100Have => CashDrawer.Dollars;
        /// <summary>
        /// Half dollars in register
        /// </summary>
        public int c50Have => CashDrawer.HalfDollars;
        /// <summary>
        /// Quarters in register
        /// </summary>
        public int c25Have => CashDrawer.Quarters;
        /// <summary>
        /// Dimes in register
        /// </summary>
        public int c10Have => CashDrawer.Dimes;
        /// <summary>
        /// Nickels in register
        /// </summary>
        public int c5Have => CashDrawer.Nickels;
        /// <summary>
        /// Pennies in register
        /// </summary>
        public int c1Have => CashDrawer.Pennies;

        private int B100In;
        /// <summary>
        /// $100s paid
        /// </summary>
        public int b100In
        {
            get
            {
                return B100In;
            }
            set
            {
                B100In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("b100In"));
            }
        }
        private int B50In;
        /// <summary>
        /// $50s paid
        /// </summary>
        public int b50In
        {
            get
            {
                return B50In;
            }
            set
            {
                B50In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("b50In"));
            }
        }
        private int B20In;
        /// <summary>
        /// $20s paid
        /// </summary>
        public int b20In
        {
            get
            {
                return B20In;
            }
            set
            {
                B20In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("b20In"));
            }
        }
        private int B10In;
        /// <summary>
        /// $10s paid
        /// </summary>
        public int b10In
        {
            get
            {
                return B10In;
            }
            set
            {
                B10In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("b10In"));
            }
        }
        private int B5In;
        /// <summary>
        /// $5s paid
        /// </summary>
        public int b5In
        {
            get
            {
                return B5In;
            }
            set
            {
                B5In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("b5In"));
            }
        }
        private int B2In;
        /// <summary>
        /// $2s paid
        /// </summary>
        public int b2In
        {
            get
            {
                return B2In;
            }
            set
            {
                B2In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("b2In"));
            }
        }
        private int B1In;
        /// <summary>
        /// $1s paid
        /// </summary>
        public int b1In
        {
            get
            {
                return B1In;
            }
            set
            {
                B1In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("b1In"));
            }
        }

        private int C100In;
        /// <summary>
        /// Dollars paid
        /// </summary>
        public int c100In
        {
            get
            {
                return C100In;
            }
            set
            {
                C100In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c100In"));
            }
        }
        private int C50In;
        /// <summary>
        /// Half dollars paid
        /// </summary>
        public int c50In
        {
            get
            {
                return C50In;
            }
            set
            {
                C50In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c50In"));
            }
        }
        private int C25In;
        /// <summary>
        /// Quarters paid
        /// </summary>
        public int c25In
        {
            get
            {
                return C25In;
            }
            set
            {
                C25In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c25In"));
            }
        }
        private int C10In;
        /// <summary>
        /// Dimes paid
        /// </summary>
        public int c10In
        {
            get
            {
                return C10In;
            }
            set
            {
                C10In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c10In"));
            }
        }
        private int C5In;
        /// <summary>
        /// Nickels paid
        /// </summary>
        public int c5In
        {
            get
            {
                return C5In;
            }
            set
            {
                C5In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c5In"));
            }
        }
        private int C1In;
        /// <summary>
        /// Pennies paid
        /// </summary>
        public int c1In
        {
            get
            {
                return C1In;
            }
            set
            {
                C1In = value;
                updateChange();
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("c1In"));
            }
        }

        /// <summary>
        /// $100 change
        /// </summary>
        public int b100Out { get; set; }
        /// <summary>
        /// $50 change
        /// </summary>
        public int b50Out { get; set; }
        /// <summary>
        /// $20 change
        /// </summary>
        public int b20Out { get; set; }
        /// <summary>
        /// $10 change
        /// </summary>
        public int b10Out { get; set; }
        /// <summary>
        /// $5 change
        /// </summary>
        public int b5Out { get; set; }
        /// <summary>
        /// $2 change
        /// </summary>
        public int b2Out { get; set; }
        /// <summary>
        /// $1 change
        /// </summary>
        public int b1Out { get; set; }
        /// <summary>
        /// Dollar coins change
        /// </summary>
        public int c100Out { get; set; }
        /// <summary>
        /// Half dollars change
        /// </summary>
        public int c50Out { get; set; }
        /// <summary>
        /// Quarters change
        /// </summary>
        public int c25Out { get; set; }
        /// <summary>
        /// Dimes change
        /// </summary>
        public int c10Out { get; set; }
        /// <summary>
        /// Nickels change
        /// </summary>
        public int c5Out { get; set; }
        /// <summary>
        /// Pennies change
        /// </summary>
        public int c1Out { get; set; }

        /// <summary>
        /// Updates the cash drawer's money record based on the money paid and given as change
        /// </summary>
        public void moveMoney()
        {
            CashDrawer.OpenDrawer();
            CashDrawer.Hundreds += b100In;
            CashDrawer.Hundreds -= b100Out;
            CashDrawer.Fifties += b50In;
            CashDrawer.Fifties -= b50Out;
            CashDrawer.Twenties += b20In;
            CashDrawer.Twenties -= b20Out;
            CashDrawer.Tens += b10In;
            CashDrawer.Tens -= b10Out;
            CashDrawer.Fives += b5In;
            CashDrawer.Fives -= b5Out;
            CashDrawer.Twos += b2In;
            CashDrawer.Twos -= b2Out;
            CashDrawer.Ones += b1In;
            CashDrawer.Ones -= b1Out;
            CashDrawer.Dollars += c100In;
            CashDrawer.Dollars -= c100Out;
            CashDrawer.HalfDollars += c50In;
            CashDrawer.HalfDollars -= c50Out;
            CashDrawer.Quarters += c25In;
            CashDrawer.Quarters -= c25Out;
            CashDrawer.Dimes += c10In;
            CashDrawer.Dimes -= c10Out;
            CashDrawer.Nickels += c5In;
            CashDrawer.Nickels -= c5Out;
            CashDrawer.Pennies += c1In;
            CashDrawer.Pennies -= c1Out;
        }

        /// <summary>
        /// Prints a reciept of the order
        /// </summary>
        /// <param name="ord">the order the reciept represents</param>
        /// <param name="usedCash">whether the customer paid with cash (false implies paid with credit/debit)</param>
        public void printReceipt(Order ord, bool usedCash)
        {
            string stars10 = "**********";
            RecieptPrinter.PrintLine(stars10 + stars10 + stars10 + stars10);
            RecieptPrinter.PrintLine("Order# " + ord.Number);
            RecieptPrinter.PrintLine(DateTime.Now.ToString());
            RecieptPrinter.PrintLine(stars10 + stars10 + stars10 + stars10);

            foreach (IOrderItem item in ord)
            {
                string priceString = "$" + item.Price;
                int spacesToAdd = 40 - item.ToString().Length - priceString.Length;
                if (spacesToAdd > 0)
                {
                    StringBuilder sb = new StringBuilder(item.ToString());
                    for (int i = 0; i < spacesToAdd; i++){
                        sb.Append(" ");
                    }
                    sb.Append(priceString);

                    RecieptPrinter.PrintLine(sb.ToString());
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < 40 - priceString.Length; i++)
                    {
                        sb.Append(" ");
                    }
                    sb.Append(priceString);

                    RecieptPrinter.PrintLine(item.ToString());
                    RecieptPrinter.PrintLine(sb.ToString());
                }
                if (item is Combo combo)
                {
                    RecieptPrinter.PrintLine(stars10);
                    RecieptPrinter.PrintLine(combo.Entree.ToString());
                    foreach (string special in combo.Entree.SpecialInstructions)
                    {
                        RecieptPrinter.PrintLine("-" + special);
                    }
                    RecieptPrinter.PrintLine(combo.Side.ToString());
                    foreach (string special in combo.Side.SpecialInstructions)
                    {
                        RecieptPrinter.PrintLine("-" + special);
                    }
                    RecieptPrinter.PrintLine(combo.Drink.ToString());
                    foreach (string special in combo.Drink.SpecialInstructions)
                    {
                        RecieptPrinter.PrintLine("-" + special);
                    }
                }
                else
                {
                    foreach (string special in item.SpecialInstructions)
                    {
                        RecieptPrinter.PrintLine("-" + special);
                    }
                }
                RecieptPrinter.PrintLine(stars10 + stars10 + stars10 + stars10);
            }

            RecieptPrinter.PrintLine("Subtotal: $" + ord.SubTotal);
            RecieptPrinter.PrintLine("Tax: $" + ord.Tax);
            RecieptPrinter.PrintLine("Total: $" + ord.Total);
            if (usedCash)
            {
                RecieptPrinter.PrintLine("Payment Method: Cash");
                RecieptPrinter.PrintLine("Change: $" + calculateChange());
            }
            else
            {
                RecieptPrinter.PrintLine("Payment Method: Credit/Debit");
                RecieptPrinter.PrintLine("Change: N/A");
            }

            RecieptPrinter.CutTape();
        }

        /// <summary>
        /// Calculates the amount left for the customer to pay
        /// </summary>
        /// <returns>the amount the customer needs to pay</returns>
        public double calculateDebt()
        {
            int sum =(int)( Math.Round(Total*100)
                - b100In * 10000
                - b50In * 5000
                - b20In * 2000
                - b10In * 1000
                - b5In * 500
                - b2In * 200
                - b1In * 100
                - c100In * 100
                - c50In * 50
                - c25In * 25
                - c10In * 10
                - c5In * 5
                - c1In * 1);
            double ret = sum;
            ret /= 100;
            return ret;
        }

        /// <summary>
        /// Calculates the amount of change to be given
        /// </summary>
        /// <returns>the amount of change to be given</returns>
        public double calculateChange()
        {
            int sum = b100Out * 10000
                + b50Out * 5000
                + b20Out * 2000
                + b10Out * 1000
                + b5Out * 500
                + b2Out * 200
                + b1Out * 100
                + c100Out * 100
                + c50Out * 50
                + c25Out * 25
                + c10Out * 10
                + c5Out * 5
                + c1Out * 1;
            double ret = sum;
            ret /= 100;
            return ret;
        }

        /// <summary>
        /// Updates the values representing the money to be given to the customer in change based on the money paid
        /// </summary>
        public void updateChange()
        {
            int change =(int)( -100 * calculateDebt());
            int temp = 0;
            if (change > 0)
            {
                temp = change / 10000;
                if (temp > b100Have + b100In) b100Out = b100Have + b100In;
                else b100Out = temp;
                change -= b100Out * 10000;

                temp = change / 5000;
                if (temp > b50Have + b50In) b50Out = b50Have + b50In;
                else b50Out = temp;
                change -= b50Out * 5000;

                temp = change / 2000;
                if (temp > b20Have + b20In) b20Out = b20Have + b20In;
                else b20Out = temp;
                change -= b20Out * 2000;

                temp = change / 1000;
                if (temp > b10Have + b10In) b10Out = b10Have + b10In;
                else b10Out = temp;
                change -= b10Out * 1000;

                temp = change / 500;
                if (temp > b5Have + b5In) b5Out = b5Have + b5In;
                else b5Out = temp;
                change -= b5Out * 500;

                temp = change / 200;
                if (temp > b2Have + b2In) b2Out = b2Have + b2In;
                else b2Out = temp;
                change -= b2Out * 200;

                temp = change / 100;
                if (temp > b1Have + b1In) b1Out = b1Have + b1In;
                else b1Out = temp;
                change -= b1Out * 100;

                temp = change / 100;
                if (temp > c100Have + c100In) c100Out = c100Have + c100In;
                else c100Out = temp;
                change -= c100Out * 100;

                temp = change / 50;
                if (temp > c50Have + c50In) c50Out = c50Have + c50In;
                else c50Out = temp;
                change -= c50Out * 50;

                temp = change / 25;
                if (temp > c25Have + c25In) c25Out = c25Have + c25In;
                else c25Out = temp;
                change -= c25Out * 25;

                temp = change / 10;
                if (temp > c10Have + c10In) c10Out = c10Have + c10In;
                else c10Out = temp;
                change -= c10Out * 10;

                temp = change / 5;
                if (temp > c5Have + c5In) c5Out = c5Have + c5In;
                else c5Out = temp;
                change -= c5Out * 5;

                temp = change;
                if (temp > c1Have + c1In)
                {
                    c1Out = c1Have + c1In;

                    change -= c1Out;
                    if (change < 5 && c5Have + c5In - c5Out > 0) c5Out++;
                    else if (change < 10 && c10Have + c10In - c10Out > 0) c10Out++;
                    else if (change < 25 && c25Have + c25In - c25Out > 0) c25Out++;
                    else if (change < 50 && c50Have + c50In -c50Out > 0) c50Out++;
                    else if (change < 100 && c100Have + c100In - c100Out > 0) c100Out++;
                    else if (change < 100 && b1Have + b1In - b1Out > 0) b1Out++;
                    else if (change < 200 && b2Have + b2In - b2Out > 0) b2Out++;
                    else if (change < 500 && b5Have + b5In - b5Out > 0) b5Out++;
                    else if (change < 1000 && b10Have + b10In - b10Out > 0) b10Out++;
                    else if (change < 2000 && b20Have + b20In - b20Out > 0) b20Out++;
                    else if (change < 5000 && b50Have + b50In - b50Out > 0) b50Out++;
                    else if (change < 10000 && b100Have + b100In - b100Out > 0) b100Out++;
                }
                else c1Out = temp;
            }
            else
            {
                b100Out = 0;
                b50Out = 0;
                b20Out = 0;
                b10Out = 0;
                b5Out = 0;
                b2Out = 0;
                b1Out = 0;
                c100Out = 0;
                c50Out = 0;
                c25Out = 0;
                c10Out = 0;
                c5Out = 0;
                c1Out = 0;
            }
        }
    }
}
