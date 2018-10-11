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

        private void DepositButton_Click(object sender, EventArgs e)
        {
            Decimal amount = Decimal.Parse(DepositTextBox.Text);
            string accName = CurrentAccountListBox1.SelectedItem.ToString();
            accServices.Deposit(accName, amount);
            DepositTextBox.Text = "";

            Decimal bal = accServices.GetAccountBalance(accName);
            AccountBalTextBox.Text = bal.ToString();
        }

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
