using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheShoppingList
{
    class Wallet
    {

        private string name;
        private string walletNr;
        private double balance;

        public void SetName(string name)
        {
            this.name = name;

        }

        public void SetWalletNr(string walletNr)
        {
            this.walletNr = walletNr;

        }

        public void SetBalance(double balance)
        {
            this.balance = balance;

        }

        public string GetName()
        {
            return name;
        }

        public string GetWalletNr()
        {
            return walletNr;
        }


        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double walletamount)
        {
            balance += walletamount;
        }

        public void Withdraw(double walletamount)
        {
            if (walletamount <= balance)
            {
                this.balance -= walletamount;
            }
            else
                MessageBox.Show("Please enter a withdraw amount less than the current bank amount.");
        }

        public string GetInfo()
        {
            return $"{name} with account nr: {walletNr} balance: {balance}";
        }

    }
}
