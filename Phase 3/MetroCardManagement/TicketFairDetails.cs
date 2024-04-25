using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TicketFairDetails
    {
        /// <summary>
        /// This private field is used to autoincrement user id.
        /// </summary> <summary>
        /// 
        /// </summary>

        private static int s_ticketID= 3000;
        /// <summary>
        /// This property is used to store unique ticket ID.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string TicketID { get;  }
        /// <summary>
        /// This property is used to store location of departure.
        /// </summary>
        /// <value></value>
        public string FromLocation { get; set; }
        /// <summary>
        ///  This property is used to store location of arrival.
        /// </summary>
        /// <value></value>
        public string ToLocation { get; set; }
        /// <summary>
        /// TicketPrice property is used to store ticket price.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public double TicketPrice { get; set; }
        /// <summary>
        /// This constructor is used to create object for the ticket.
        /// </summary>
        /// <param name="fromLocation">Contains data of departure location</param>
        /// <param name="toLocation">Contains data of arrival location</param>
        /// <param name="ticketPrice">Contains data of ticket price.</param> <summary>
        /// 
        /// </summary>
       
        public TicketFairDetails(string fromLocation, string toLocation, double ticketPrice)
        {
            TicketID ="MR"+(++s_ticketID);
            FromLocation = fromLocation;
            ToLocation = toLocation;
            TicketPrice = ticketPrice;
        }
        /// <summary>
        /// This constructor get ticket details as string from csv file and assign its respective values to the properties by splitting.
        /// </summary>
        /// <param name="ticket">Contains ticket details as string.</param> <summary>
        /// 
        /// </summary>
        public TicketFairDetails(string ticket)
        {
            string [] values = ticket.Split(",");
            s_ticketID = int.Parse(values[0].Remove(0,2));
            TicketID =values[0];
            FromLocation = values[1];
            ToLocation = values[2];
            TicketPrice = double.Parse(values[3]);
        }
        /// <summary>
        /// This method is used to display ticket fair details.
        /// </summary>

        public void ShowTicketFairDetails()
        {
            Console.WriteLine($"|{TicketID,-15}|\t|{FromLocation,-15}|\t|{ToLocation,-15}|\t|{TicketPrice,-15}|");
        }

    }
}