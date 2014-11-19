using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountSystem
{
    public interface IDepositable
    {
        void DepositMoney(decimal amount);
    }
}
