using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public class OrderDetails
    {
        //OrderID {Auto Increment – OID4000}, BookingID, ProductID, PurchaseCount, PriceOfOrder
        private static int s_orderID = 4000;
        public string OrderID { get; }
        public string BookingID { get; set; }
        public string ProductID { get; set; }
        public int PurchaseCount { get; set; }
        public double PriceOfOrder { get; set; }
        public OrderDetails(string bookingID, string productID, int purchasecount, double price)
        {
            OrderID= "OID"+(++s_orderID);
            BookingID = bookingID;
            ProductID = productID;
            PurchaseCount = purchasecount;
            PriceOfOrder = price;
        }
    }
}