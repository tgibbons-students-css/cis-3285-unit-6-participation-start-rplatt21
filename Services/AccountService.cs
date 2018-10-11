﻿ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Services
{
    public class AccountService : IAccountServices
    {
        // store the accounts in a dictionary indexed by the account name
        private Dictionary<string, AccountBase> accountsDictionary;

        public AccountService()
        {
            //instantiate the dictionary for accounts
            accountsDictionary = new Dictionary<string, AccountBase>();
        }

        public void CreateAccount(string accountName, AccountType accountType)
        // create a new account
        {
            AccountBase newAccount = AccountBase.CreateAccount(accountType);
            accountsDictionary.Add(accountName, newAccount);
        }

        public decimal GetAccountBalance(string accountName)
        // find the balance of the given account
        {
            AccountBase acc = FindAccount(accountName);
            return acc.Balance;
        }
        public int GetRewardPoints(string accountName)
        // find the reward points of the given account
        {
            AccountBase acc = FindAccount(accountName);
            return acc.RewardPoints;
        }

        public void Deposit(string accountName, decimal amount)
        // deposit the given account into the account named
        {
            AccountBase acc = FindAccount(accountName);
            acc.AddTransaction(amount);
        }

        public void Withdrawal(string accountName, decimal amount)
        // withdrawal the given account into the account named
        {
            //takes account name and adds transaction: parameters are multiplied by -1 for that it is subtracted from account
            AccountBase acc = FindAccount(accountName);
            acc.AddTransaction(amount * -1);
        }

        private AccountBase FindAccount(string accountName)
        {
            if (accountsDictionary.ContainsKey(accountName))
            {
                return accountsDictionary[accountName];
            }
            return null;
        }

    }
}
