using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public interface IBalance
    {
        public void WalletRecharge(double amount);
        public double WalletBalance { get; set; }
    }
}