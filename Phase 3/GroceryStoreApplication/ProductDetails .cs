using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public class ProductDetails 
    {
        //ProductID {Auto Increment – PID2000}, ProductName, QuantityAvailable, PricePerQuantity
        private static int s_productID= 2000;
        public string ProductID { get;  }
        public string ProductName { get; set; }
        public int QuantityAvailable { get; set; }
        public double PricePerQuantity { get; set; }

        public ProductDetails(string productName, int quantity, double price)
        {
            ProductID = "PID"+(++s_productID);
            ProductName = productName;
            QuantityAvailable = quantity;
            PricePerQuantity = price;
        }
        //Method: ShowProductDetails

        public void ShowProductDetail()
        {
            Console.WriteLine($"ProductID :{ProductID}");
            Console.WriteLine($"ProductName :{ProductName}");
            Console.WriteLine($"QuantityAvailable :{QuantityAvailable}");
            Console.WriteLine($"PricePerQuantity :{PricePerQuantity}");
        }
    }
}