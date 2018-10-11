using Domain;
using Services;
using System;
using System.Windows.Forms;

namespace AccountsForms
{
    public partial class Form1 : Form
    {
        IAccountServices accService = new AccountService();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string accountName = txtAccountName.Text;
            listBoxAccounts.Items.Add(accountName);
            accService.CreateAccount(accountName, AccountType.Silver);
        }

        private void listBoxAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string accName = listBoxAccounts.SelectedItem.ToString();
            decimal balance = accService.GetAccountBalance(accName);

            txtBalance.Text = balance.ToString();
        }
    }
}
