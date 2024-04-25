using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    public class TravelDetails
    {
        //Private field
        /// <summary>
        /// This private field is used to autoincrement travelID.
        /// </summary> <summary>
        /// 
        /// </summary>
        private static int s_travelId= 2000;
        //Properties
        /// <summary>
        /// this property is used to store Travel ID.
        /// </summary>
        /// <value></value>
        public string TravelID { get; }
        /// <summary>
        /// CardNumber Property is used to store card number.
        /// </summary>
        /// <value></value>
        public string CardNumber { get; set; }
        /// <summary>
        /// This property is used to store location of departure.
        /// </summary>
        /// <value></value>
        public string FromLocation { get; set; }
        /// <summary>
        ///  This property is used to store location of arrival.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string ToLocation { get; set; }
        /// <summary>
        /// Date property is used to store the date of travel.
        /// </summary>
        /// <value></value>
        public DateTime Date { get; set; }
        /// <summary>
        /// TravelCost is used to store cost of the respective travel.
        /// </summary> <summary>
        public double TravelCost { get; set; }

        //Constructors
        /// <summary>
        /// TravelDetails constructor is used to create object for travel details.
        /// </summary>
        /// <param name="cardNumber">Contains data of card number</param>
        /// <param name="fromLocation">Contains data of departure location</param>
        /// <param name="toLocation">Contains data of arrival location</param>
        /// <param name="date">Contains data of date of travel</param>
        /// <param name="travelCost">Contains data of cost for travel</param>
        public TravelDetails(string cardNumber, string fromLocation, string toLocation, DateTime date, double travelCost)
        {
            TravelID ="TID"+(++s_travelId);
            CardNumber = cardNumber;
            FromLocation = fromLocation;
            ToLocation = toLocation;
            Date = date;
            TravelCost = travelCost;
        }
        /// <summary>
        /// This constructor get travel details as string from csv file and assign its respective values to the properties by splitting.
        /// </summary>
        /// <param name="travel">contains the travel data as string</param>
        public TravelDetails(string travel)
        {
            string [] values = travel.Split(",");
            s_travelId = int.Parse(values[0].Remove(0,3));

            TravelID =values[0];
            CardNumber = values[1];
            FromLocation = values[2];
            ToLocation = values[3];
            Date = DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
            TravelCost = double.Parse(values[5]);
        }

        //Method
        /// <summary>
        /// This method is used to display travel details for the particular user.
        /// </summary>
        public void ShowTravelDetails()
        {
            Console.WriteLine($"|{TravelID}|\t|{CardNumber}|\t|{FromLocation}|\t|{ToLocation}|\t|{Date.ToShortDateString()}|\t|{TravelCost}|");
        }
    }
}