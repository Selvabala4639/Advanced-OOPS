using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public enum BookingStatus{Default, Initiated,Booked,Cancelled}
    /// <summary>
    /// Class <see cref="BookingDetails"/> contails detilals of booking.
    /// </summary> 
    public class BookingDetails 
    {
        //BookingID {Auto Increment – BID3000}, CustomerID, TotalPrice, DateOfBooking, Booking Status – Default, Initiated, Booked, 
        /// <summary>
        ///  private string field used to store booking ID
        /// </summary> 
        private static int s_bookingID=3000;
        public string BookingID { get;  }
        /// <summary>
        /// property CusotmerID which contains cusometer id of <see cref="CustomerID"/> class's object
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string CustomerID { get; set; }
        /// <summary>
        /// This property contains total price.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public double TotalPrice { get; set; }
        /// <summary>
        /// This property is used to store date of booking.
        /// </summary>
        /// <value></value>
        public DateTime DateOfBooking { get; set; }
        public BookingStatus BookingStatus { get; set; }
        
        public BookingDetails(string customerID, double totalPrice, DateTime dateofBooking, BookingStatus status)
        {
            BookingID ="BID"+(++s_bookingID);
            CustomerID = customerID;
            TotalPrice = totalPrice;
            DateOfBooking = dateofBooking;
            BookingStatus =status;
        }

        //Method: ShowBookingDetails
        public void ShowBookingDetails()
        {
            Console.WriteLine($"BookingID: {BookingID}");
            Console.WriteLine($"CustomerID: {CustomerID}");
            Console.WriteLine($"TotalPrice: {TotalPrice}");
            Console.WriteLine($"DateOfBooking: {DateOfBooking}");
            Console.WriteLine($"BookingStatus: {BookingStatus}");
        }
    }

}