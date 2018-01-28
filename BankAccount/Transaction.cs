using BankAccount.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public struct Transaction : ITransaction
    {
        public Transaction(string reference, decimal amount)
        {
            Reference = reference;
            Amount = amount;
        }
        public string Reference { get; private set; }
        public decimal Amount { get; private set; }
    }
}
