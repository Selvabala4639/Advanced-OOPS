using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFoodDeliveryApplication
{
    public interface IBalance
    {
        public double WalletBalance { get;  }

        public void WalletRecharge(double amount);
        public void DeductBalance(double amount);

    }
}