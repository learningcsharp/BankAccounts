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
        public string Reference { get; set; }
        public decimal Amount { get; set; }
    }
}
