using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFoodDeliveryApplication
{
    public class FoodDetails
    {
        private static int s_foodId= 2000;
        public string FoodId { get; }
        public string FoodName { get; set; }
        public double PricePerQuantity { get; set; }
        public int QuantityAvailable { get; set; }

        public FoodDetails(string foodName, double pricePerQuantity, int quantityAvailable)
        {
            FoodId = "FID"+(++s_foodId);
            FoodName = foodName;
            PricePerQuantity = pricePerQuantity;
            QuantityAvailable=quantityAvailable;
        }
        public FoodDetails(string food)
        {
            string [] values = food.Split(",");
            s_foodId = int.Parse(values[0].Remove(0,3));
            FoodId =values[0];
            FoodName = values[1];
            PricePerQuantity = double.Parse(values[2]);
            QuantityAvailable=int.Parse(values[3]);
        }
    }
}