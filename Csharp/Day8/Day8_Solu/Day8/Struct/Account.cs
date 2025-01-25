using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.Struct
{
    struct Account
    {
        //attribute
        private int accountId;
        private string accountHolder;
        private int balance;

        //prop
        public int AccountId { 
            get { return accountId; }
            set { accountId = value; }
        }
            
        public string AccountHolder {
            get { return accountHolder; }
            set{ accountHolder = value; }
        }
        public int Balance
        {
            get { return balance; }
            set {balance = value; }
        }

        //ctor
        public Account(int accountId, string accountHolder, int balance) : this()
        {
            AccountId = accountId;
            AccountHolder = accountHolder;
            Balance = balance;
        }
        public override string ToString()
        {
            return $"Account Id: {AccountId} ,Account Holder: {AccountHolder} ,Balance: {Balance} ";
        }
    }
}
