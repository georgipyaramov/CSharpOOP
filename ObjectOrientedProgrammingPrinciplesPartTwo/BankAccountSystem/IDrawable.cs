﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccountSystem
{
    public interface IDrawable
    {
        void WithdrawMoney(decimal amount);
    }
}
