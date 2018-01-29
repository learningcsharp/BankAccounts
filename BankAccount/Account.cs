using BankAccount.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account : IAccount
    {
        private List<ITransaction>  _Transactions { get; set; }
        public string Name { get; protected set; }

        public Account(string name)
        {
            Name = name;

            _Transactions = new List<ITransaction>();
        }



        /// <summary>
        /// Method to add a transaction to the bank account
        /// </summary>
        /// <param name="transaction">The transaction to add</param>
        public void AddTransaction(ITransaction transaction)
        {
            _Transactions.Add(transaction);
        }

        /// <summary>
        /// Retrieve the current balance for the bank account
        /// </summary>
        /// <returns>The Current Balance</returns>
        public decimal GetCurrentBalance()
        {
            if (_Transactions.Count == 0)
                return 0;
            else
                return _Transactions.Sum(x => x.Amount);
        }

        /// <summary>
        /// Represents the transactions held in the bank account, read-only status stops list being modified outside of this class.
        /// </summary>
        public IReadOnlyCollection<ITransaction> Transactions { get { return _Transactions.AsReadOnly(); } }


    }
}
