using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    /// <summary>
    /// This Operation class performs the required functionalities for Metro Card Management application.
    /// </summary> <summary>
    /// 
    /// </summary>
    public class Operations
    {
        
        public static UserDetails currentLoggedInUser;
        /// <summary>
        /// userList is used to store UserDetails object.
        /// </summary>
        
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        /// <summary>
        /// travelList is used to store TravelDetails object.
        /// </summary> <summary>
        /// 
        /// </summary>
        
        public static CustomList<TravelDetails> travelList = new CustomList<TravelDetails>();
        /// <summary>
        /// ticketFairList is used to store TicketFairDetails objects.
        /// </summary>
        
        public static CustomList<TicketFairDetails> ticketFairList = new CustomList<TicketFairDetails>();
        /// <summary>
        /// MainMenu method is used to initiate the application and its functionalities, where user can choose options.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void MainMenu()
        {
            /// <summary>
            /// mainMenuOption variable is used to store the main menu option.
            /// </summary>
            int mainMenuOption;
            do
            {
                Console.WriteLine($"********************Welcome to CMRL********************");
                Console.WriteLine($"1.New User Registration\n2.User Login\n3.Exit");
                Console.Write($"Choose one Option: ");
                mainMenuOption = int.Parse(Console.ReadLine());
                switch(mainMenuOption)
                {
                    case 1:
                    {
                        Console.WriteLine($"********************New User Registration********************");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine($"********************User Login********************");
                        UserLogin();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine($"********************Application Ended********************");

                        break;
                    }
                    default:
                    {
                        Console.WriteLine($"Invalid option!");
                        break;
                    }
                }
                
            }while(mainMenuOption!=3);
            
        }//mainMenu ends here

        /// <summary>
        /// Registration method is used to get user details and store it in userList.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void Registration()
        {
            Console.Write($"Enter your Name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter your Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write($"Enter your Balance: ");
            double balance = double.Parse(Console.ReadLine());
            UserDetails user = new UserDetails(name, phoneNumber, balance);
            userList.Add(user); 
        }//Registration ends here
        /// <summary>
        /// UserLogin method is used to get user credentials and performs login functionalities.
        /// </summary>
        public static void UserLogin()
        {
            Console.Write($"Enter your Card Number:");
            string cardNumber = Console.ReadLine();
            bool flag = false;
            foreach(UserDetails user in userList)
            {
                if(user.CardNumber.Equals(cardNumber))
                {
                    flag = true;
                    currentLoggedInUser = user;
                    Console.WriteLine($"Login Successful");
                    Console.WriteLine($"Hi {currentLoggedInUser.UserName}:-)");
                    
                    SubMenu();
                    break;
                }
            }
            if(!flag)
            {
                Console.WriteLine($"Invalid Card Number!");
            }
            
        }//UserLogin ends here
        /// <summary>
        /// SubMenu method is used to get user option and performs its respective functions.
        /// </summary>
        public static void SubMenu()
        {
            
            char subMenuOption;
            do
            {
                Console.WriteLine($"a. Check Balance\nb. Recharge\nc. View Travel History\nd. Travel\ne. Exit");
                Console.Write($"Choose an option: ");
                subMenuOption = char.Parse(Console.ReadLine());   
                switch(subMenuOption)
                {
                    case 'a':
                    {
                        CheckBalance();

                        break;
                    }
                    case 'b':
                    {
                        Recharge();
                        break;
                    }
                    case 'c':
                    {
                        ViewTravelHistory();
                        break;
                    }
                    case 'd':
                    {
                        Travel();
                        break;
                    }
                    case 'e':
                    {
                        Console.WriteLine($"Returning to Main menu!");
                        
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }while(subMenuOption!='e');
            
        }//SubMenu ends here

        /// <summary>
        /// CheckBalance method is used to check current balance of the user.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void CheckBalance()
        {
            Console.WriteLine($"*************************************************\n");
            
            Console.WriteLine($"Your Balance is {currentLoggedInUser.Balance}");
            Console.WriteLine($"\n*************************************************");
            
        }//CheckBalance ends here
        /// <summary>
        /// Recharge method is used to get amount from the user and add that amount to user's balance.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void Recharge()
        {
            Console.Write($"Enter amount to recharge:");
            double amount = double.Parse(Console.ReadLine());
            currentLoggedInUser.WalletRecharge(amount);
        }//Recharge ends here
        /// <summary>
        /// ViewTravelHistory method is used to display travel history of that particular user.
        /// </summary>
        public static void ViewTravelHistory()
        {
            bool flag = false;
            int count =0;
            foreach(TravelDetails travel in travelList)
            {
                if(currentLoggedInUser.CardNumber.Equals(travel.CardNumber))
                {
                    flag = true;
                    count++;
                    if(count==1)
                    {
                        Console.WriteLine($"|{"Travel ID"}|\t|{"CardNumber"}|\t|{"From Location",-15}|\t|{"To Location"}\t|{"Date",-15}|\t|{"Travel Cost",-15}|");
                        
                    }
                    travel.ShowTravelDetails();
                }
            }
            if(flag == false)
            {
                Console.WriteLine($"Still you didn't travel in CMRL!");
                
            }
        }//ViewTravelHistory ends here
        /// <summary>
        /// Travel method performs validating travel Id and generating a new travel details with its respective ricket ID.
        /// </summary>
        public static void Travel()
        {
            //Show Ticket fair details
            
            int count =0;
            foreach(TicketFairDetails ticket in ticketFairList)
            {
                count++;
                if(count==1)
                {
                    Console.WriteLine($"|{"Ticket ID",-15}|\t|From Location|\t|To Locatio|\t|Ticket Price|");
                }
                ticket.ShowTicketFairDetails();
            }
            //Get ticket id and validate
            
            Console.Write($"Enter Ticket ID to travel:");
            string ticketID = Console.ReadLine();
            bool validTicketID = false;
            foreach(TicketFairDetails ticket in ticketFairList )
            {
                if(ticket.TicketID.Equals(ticketID))
                {
                    validTicketID = true;
                    //Check sufficient balance to travel
                    
                    if(currentLoggedInUser.Balance>=ticket.TicketPrice)
                    {
                        //Detuct amount and add travel details
                        currentLoggedInUser.DeductBalance(ticket.TicketPrice);
                        TravelDetails newTravel = new TravelDetails(currentLoggedInUser.CardNumber,ticket.FromLocation,ticket.ToLocation,DateTime.Today,ticket.TicketPrice);
                        travelList.Add(newTravel);
                        Console.WriteLine($"Travel Completed");
                    }
                    else
                    {
                        Console.WriteLine($"Insufficient balance");
                    }
                }
            }
            if(validTicketID==false)
            {
                Console.WriteLine($"Invalid Ticket ID!");
            }
            
        }//Travel ends here
        /// <summary>
        /// AddDefaultData is used to add default datas to its respective Lists.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void AddDefaultData()
        {
            UserDetails user1 = new UserDetails("Ravi",	"9848812345",	1000);
            userList.Add(user1);
            UserDetails user2 = new UserDetails("Baskaran",	"9948854321"	,1000);
            userList.Add(user2);

            TravelDetails travel1 = new TravelDetails("CMRL1001",	"Airport"	,"Egmore"	,new DateTime(2023,10,10) ,55);
            TravelDetails travel2 = new TravelDetails("CMRL1001",	"Egmore",	"Koyambedu",new DateTime(2023,10,10),	32);
            TravelDetails travel3 = new TravelDetails("CMRL1002",	"Alandur"	,"Koyambedu"	,new DateTime(2023,11,10),	25);
            TravelDetails travel4 = new TravelDetails("CMRL1002",	"Egmore"	,"Thirumangalam"	,new DateTime(2023,11,10),	25);
            travelList.Add(travel1);
            travelList.Add(travel2);
            travelList.Add(travel3);
            travelList.Add(travel4);

            TicketFairDetails ticketfair1 = new TicketFairDetails("Airport",	"Egmore",	55);
            TicketFairDetails ticketfair2 = new TicketFairDetails("Airport",	"Koyambedu",	25);
            TicketFairDetails ticketfair3 = new TicketFairDetails("Alandur",	"Koyambedu",	25);
            TicketFairDetails ticketfair4 = new TicketFairDetails("Koyambedu"	,"Egmore",	32);
            TicketFairDetails ticketfair5 = new TicketFairDetails("Vadapalani",	"Egmore",	45);
            TicketFairDetails ticketfair6 = new TicketFairDetails("Arumbakkam",	"Egmore",	25);
            TicketFairDetails ticketfair7 = new TicketFairDetails("Vadapalani"	,"Koyambedu"	,25);
            TicketFairDetails ticketfair8 = new TicketFairDetails("Arumbakkam",	"Koyambedu",	16);
            ticketFairList.Add(ticketfair1);
            ticketFairList.Add(ticketfair2);
            ticketFairList.Add(ticketfair3);
            ticketFairList.Add(ticketfair4);
            ticketFairList.Add(ticketfair5);
            ticketFairList.Add(ticketfair6);
            ticketFairList.Add(ticketfair7);
            ticketFairList.Add(ticketfair8);
        }
    }
}