using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public interface IBalance 
    {
        /// <summary>
        /// Balance property is used to store balance of an user.
        /// </summary>
        /// <value></value>
        public double Balance { get; set; }
        /// <summary>
        /// This method is used to add amount to the balance.
        /// </summary>
        /// <param name="amount"></param> <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
        public void WalletRecharge(double amount);
        /// <summary>
        /// DeductBalance method detects the amount from the user's balance.
        /// </summary>
        /// <param name="amount"></param> <summary>
        /// 
        /// </summary>
        /// <param name="amount"></param>
         public void DeductBalance(double amount);
    }
}