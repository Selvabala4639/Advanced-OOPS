using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public class CartItem
    {
        // •	ItemID (Auto - ITID101) 
        // •	OrderID
        // •	FoodID
        // •	OrderPrice
        // •	OrderQuantity
        private static int s_itemId= 101;
        public string ItemId { get; }
        public string OrderID { get; set; }
        public string FoodID { get; set; }
        public double OrderPrice { get; set; }
        public int OrderQuantity { get; set; }

        public CartItem(string orderID , string foodID, double orderPrice, int orderQuantity)
        {
            ItemId = "ITI" + (++s_itemId);
            OrderID = orderID;
            FoodID = foodID;
            OrderPrice = orderPrice;
            OrderQuantity = orderQuantity;
        }
    }
}