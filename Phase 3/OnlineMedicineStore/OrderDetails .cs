using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicineStore
{
    public enum OrderStatus{Purchased, Cancelled}
    public class OrderDetails 
    {
        /// <summary>
        /// this private field autoincrement the order id.
        /// </summary> <summary>
        /// 
        /// </summary>
        private static int s_orderID = 2000;
        /// <summary>
        /// Used to store orderID data.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string  OrderID { get;  }
        /// <summary>
        /// Used to store user ID data.
        /// </summary>
        /// <value></value>
        public string UserID { get; set; }
        /// <summary>
        /// Used to store medicineID data.
        /// </summary>
        /// <value></value>
        public string MedicineID { get; set; }
        /// <summary>
        /// Used to store medicine count data.
        /// </summary>
        /// <value></value>
        public int MedicineCount { get; set; }
        /// <summary>
        /// Used to store total price.
        /// </summary>
        /// <value></value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// Used to store oreder date data.
        /// </summary>
        /// <value></value>
        public DateTime OrderDate { get; set; }
        /// <summary>
        /// Used to store order status data.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public OrderStatus OrderStatus { get; set; }
        /// <summary>
        ///  This constructor is used to create object for user details.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="medicineID"></param>
        /// <param name="count"></param>
        /// <param name="price"></param>
        /// <param name="date"></param>
        /// <param name="status"></param>

        public OrderDetails(string user,string medicineID, int count, double price, DateTime date, OrderStatus status)
        {
            OrderID = "OID"+(++s_orderID);
            UserID = user;
            MedicineID = medicineID;
            MedicineCount = count;
            TotalPrice = price;
            OrderDate = date;
            OrderStatus = status;
        }
        /// <summary>
        /// Gets the data as string and split those strings and store it in respective properties.
        /// </summary>
        /// <param name="order"></param> <summary>
        /// 
        /// </summary>
        /// <param name="order"></param>
        public OrderDetails(string order)
        {
            string[] values = order.Split(",");
            s_orderID = int.Parse(values[0].Remove(0,3));
            OrderID =values[0];
            UserID = values[1];
            MedicineID = values[2];
            MedicineCount = int.Parse(values[3]);
            TotalPrice = double.Parse(values[4]);
            OrderDate = DateTime.ParseExact(values[5],"dd/MM/yyyy",null);
            OrderStatus = Enum.Parse<OrderStatus>(values[6]);
        }
    }
}