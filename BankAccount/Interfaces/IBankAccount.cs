using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Interfaces
{
    public interface IAccount
    {
        string Name { get; }
        IReadOnlyCollection<ITransaction> Transactions { get; }

        void AddTransaction(ITransaction transaction);
        decimal GetCurrentBalance();
    }
}
