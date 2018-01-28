using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount.Interfaces
{
   public interface ITransaction
    {
        string Reference { get; set; }
        decimal Amount { get; set; }
    }
}
