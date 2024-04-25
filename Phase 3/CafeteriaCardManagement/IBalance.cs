using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public interface IBalance
    {
        //Properties: WalletBalance
        //Method: WalletRecharge, DeductAmount
        public double WalletBalance { get;}

        public void WalletRecharge(double amount);

        public void DeductAmount(double amount);
    }
}