using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardManagement
{
    public class FoodDetails
    {
        // •	FoodID (Auto - FID101)
        // •	FoodName
        // •	FoodPrice
        // •	AvailableQuantity
        private static int s_foodID=1000;
        public string FoodID { get;  }
        public string FoodName { get; set; }
        public double FoodPrice { get; set; }
        public int AvailableQuantity { get; set; }
        
        public FoodDetails(string foodName, int availableQuantity, double foodPrice)
        {
            FoodID = "FID"+(++s_foodID);
            FoodName = foodName;
            FoodPrice = foodPrice;
            AvailableQuantity = availableQuantity;
        }
        
    }
}