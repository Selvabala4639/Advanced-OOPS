using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
namespace MetroCardManagement
{
    public class FileHandling
    {
        /// <summary>
        /// Create method is used to create necessary folder and files for storing data as csv files.
        /// </summary>
        public static  void Create()
        {
            if(!Directory.Exists("DataFolder"))
            {
                Directory.CreateDirectory("DataFolder");
                Console.WriteLine($"Folder Created");
            }
            if(!File.Exists("DataFolder/UserDetails.csv"))
            {
                File.Create("DataFolder/UserDetails.csv").Close();
                Console.WriteLine($"UserDetails.csv created.");
            }
            if(!File.Exists("DataFolder/TravelDetails.csv"))
            {
                File.Create("DataFolder/TravelDetails.csv").Close();
                Console.WriteLine($"TravelDetails.csv created.");
            }
            if(!File.Exists("DataFolder/TicketFairDetails.csv"))
            {
                File.Create("DataFolder/TicketFairDetails.csv").Close();
                Console.WriteLine($"TicketFairDetails.csv created.");
            }
        }//Create ends here
        /// <summary>
        /// This method is used to write each object in the list to csv file as strings. 
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void WriteToCSV()
        {
            string [] users = new string[Operations.userList.Count];
            for(int i =0; i<Operations.userList.Count; i++)
            {
                users[i] = Operations.userList[i].CardNumber+","+Operations.userList[i].UserName+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].Balance;
             }
            File.WriteAllLines("DataFolder/UserDetails.csv",users);

            string [] travels = new string[Operations.travelList.Count];
            for(int i =0; i<Operations.travelList.Count ; i++)
            {
                travels[i] = Operations.travelList[i].TravelID+","+Operations.travelList[i].CardNumber+","+Operations.travelList[i].FromLocation+","+Operations.travelList[i].ToLocation+","+Operations.travelList[i].Date.ToShortDateString()+","+Operations.travelList[i].TravelCost;
            }
            File.WriteAllLines("DataFolder/TravelDetails.csv",travels);

            string [] tickets = new string[Operations.ticketFairList.Count];
            for(int i =0; i<Operations.ticketFairList.Count; i++)
            {
                tickets[i] = Operations.ticketFairList[i].TicketID+","+Operations.ticketFairList[i].FromLocation+","+Operations.ticketFairList[i].ToLocation+","+Operations.ticketFairList[i].TicketPrice;
            }
            File.WriteAllLines("DataFolder/TicketFairDetails.csv",tickets);
        }//WriteToCSV ends here
        /// <summary>
        /// ReadFromCSV method is used to get data from the csv file and store it in its respective lists.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void ReadFromCSV()
        {
            string[] users = File.ReadAllLines("DataFolder/UserDetails.csv");
            foreach(string user in users)
            {
                UserDetails user1 = new UserDetails(user);
                Operations.userList.Add(user1);
            }

            string [] travels = File.ReadAllLines("DataFolder/TravelDetails.csv");
            foreach(string travel in travels)
            {
                TravelDetails travel1 = new TravelDetails(travel);
                Operations.travelList.Add(travel1);
            }

            string [] tickets = File.ReadAllLines("DataFolder/TicketFairDetails.csv");
            foreach(string ticket in tickets)
            {
                TicketFairDetails ticket1 = new TicketFairDetails(ticket);
                Operations.ticketFairList.Add(ticket1);
            }
        }
        
    }

}