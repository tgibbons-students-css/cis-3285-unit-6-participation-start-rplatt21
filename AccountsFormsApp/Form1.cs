using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace AccountsFormsApp
{
    public partial class Form1 : Form
    {
        IAccountServices accServices = new AccountService();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton1_Click(object sender, EventArgs e)
        {
            string accName = accNameText.Text;
            CurrentAccountListBox1.Items.Add(accName);
            accNameText.Text = "";

            accServices.CreateAccount(accName, Domain.AccountType.Silver);
        }

        private void CurrentAccountListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accName = CurrentAccountListBox1.SelectedItem.ToString();
            Decimal bal = accServices.GetAccountBalance(accName);
           AccountBalTextBox.Text = bal.ToString();
        }

        /// <summary>
        /// Deposit Button gets user input from textbox, sets amount in account name that is selected. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DepositButton_Click(object sender, EventArgs e)
        {
            Decimal amount = Decimal.Parse(DepositTextBox.Text);
            string accName = CurrentAccountListBox1.SelectedItem.ToString();
            accServices.Deposit(accName, amount);
            DepositTextBox.Text = "";

            Decimal bal = accServices.GetAccountBalance(accName);
            AccountBalTextBox.Text = bal.ToString();
        }

        /// <summary>
        /// Withdraw button takes user input from textbox and calls Withdrawal method: takes away amount from selected item/account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WithdrawalButton_Click(object sender, EventArgs e)
        {
            Decimal amount = Decimal.Parse(WithTextBox.Text);
            string accName = CurrentAccountListBox1.SelectedItem.ToString();
            accServices.Withdrawal(accName, amount);
            WithTextBox.Text = "";

            Decimal bal = accServices.GetAccountBalance(accName);
            AccountBalTextBox.Text = bal.ToString();
        }
    }
}
