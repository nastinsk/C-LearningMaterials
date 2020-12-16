using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class BankAccount
    {
        //Properties
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    //or we can type: balance = balance + item.Amount
                    //we also can substract that way, for example: balance -= item.Amount
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        //This is a data member. It's private, which means it can only be accessed by code inside the BankAccount class. It's a way of separating the public responsibilities (like having an account number) from the private implementation (how account numbers are generated). It is also static, which means it is shared by all of the BankAccount objects. The value of a non-static variable is unique to each instance of the BankAccount object. 

        private static int AccNumberSeed = 123456789;

        //Objects Constructor
        public BankAccount(string name, decimal initialBalance)
        {
            //we can skip the word "this
            this.Number = AccNumberSeed.ToString();
            AccNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

        }

        //Methods

        //void in methods specifies that method does not returns the value
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        //"string" here because we want this method return a string
        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;

            //"\t" - represents tabs
            report.AppendLine("Date\t\tAmount\tBalance\tNote");

            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
    }
}
