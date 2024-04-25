using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ListDS;

namespace CafeteriaCardManagement
{
    public class Operations
    {
        public static UserDetails CurrentLoggedInUser;
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        public static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        public static CustomList<CartItem> cartList = new CustomList<CartItem>();

        public void MainMenu()
        {
            int mainMenuOption;
            Console.WriteLine($"*************CAFETERIA*************");
            Console.WriteLine($"1.Regsitration\n2.UserLogin\n3.Exit");
            mainMenuOption = int.Parse(Console.ReadLine());
            do
            {
                switch(mainMenuOption)
                {
                    case 1:
                    {
                        Console.WriteLine($"*************REGISTRATION*************");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine($"*************USER LOGIN*************");
                        UserLogin();
                        break;
                    }
                    case 3:
                    {
                        break;
                    }
                    default:
                    {
                        Console.WriteLine($"*************INVALID OPTION*************");
                        
                        break;
                    }
                }
            }while(mainMenuOption!=3);
            
        }//MainMenu ends here

        public void Registration()
        {

        }//Registration ends here
        public void UserLogin()
        {
            Console.Write($"Enter user l0ginID:");
            string userLogin = Console.ReadLine();
            bool flag = false;
            foreach(UserDetails user in userList)
            {
                if(userLogin.Equals(user.UserID))
                {
                    flag = true;
                    CurrentLoggedInUser = user;
                    Console.WriteLine($"Login Successful");
                    SubMenu();
                }
            }
            if(!flag) Console.WriteLine($"Invalid User ID");
            
        }//UserLogin ends here

        public void SubMenu()
        {
            Console.WriteLine($"a)	Show Customer Details");
            Console.WriteLine($"b)	Show Product Details");
            Console.WriteLine($"c)	Wallet Recharge");
            Console.WriteLine($"d)	Take Order");
            Console.WriteLine($"e)	Modify Order Quantity");
            Console.WriteLine($"f)	Cancel Order");
            Console.WriteLine($"g)	 Show Balance");
            Console.WriteLine($"h)	Exit");
            Console.WriteLine($"Choose an option");
            char subMenuOption = char.Parse(Console.ReadLine());
            do
            {
                switch(subMenuOption)
                {
                    case 'a':
                    {
                        ShowCustomerDetails();
                        break;
                    }
                    case 'b':
                    {
                        ShowProductDetails();
                        break;
                    }
                    case 'c':
                    {
                        WalletRecharge();
                        break;
                    }
                    case 'd':
                    {
                        TakeOrder();
                        break;
                    }
                    case 'e':
                    {
                        ModifyOrderQuantity();
                        break;
                    }
                    case 'f':
                    {
                        CancelOrder();
                        break;
                    }
                    case 'g':
                    {
                        ShowBalance();
                        break;
                    }
                    case 'h':
                    {
                        Console.WriteLine($"Returning to main menu.");
                        
                        break;
                    }
                }
            }while(subMenuOption!='h');
            
        }

        static void ShowCustomerDetails()
        {
            
        }//ShowCustomerDetails

        static void ShowProductDetails()
        {

        }//ShowProductDetails

        static void WalletRecharge()
        {

        }//WalletRecharge

        static void TakeOrder()
        {

        }//TakeOrder

        static void ModifyOrderQuantity()
        {

        }//ModifyOrderQuantity

        static void CancelOrder()
        {

        }//CancelOrder

        static void ShowBalance()
        {

        }//ShowBalance

        public void AddDefaultData()
        {
            UserDetails user1 = new UserDetails("WS101",400,"Ravichandran", "Ettapparajan",Gender.Male	,"8857777575"	,"ravi@gmail.com1");
            UserDetails user2 = new UserDetails("WS105",500,"Baskaran", "Sethurajan",Gender.Male	,"9577747744"	,"baskaran@gmail.com");

            userList.Add(user1);
            userList.Add(user2);

            FoodDetails food1 = new FoodDetails("Coffee",	20	,100);
            FoodDetails food2 = new FoodDetails("Tea",	15	,100);
            FoodDetails food3 = new FoodDetails("Biscuit",	10,	100);
            FoodDetails food4 = new FoodDetails("Juice",	50,	100);
            FoodDetails food5 = new FoodDetails("Puff"	,40	,100);
            FoodDetails food6 = new FoodDetails("Milk",	10,	100);
            FoodDetails food7 = new FoodDetails("Popcorn"	,20	,20);

            foodList.AddRange(new CustomList<FoodDetails>{food1,food2,food3,food4,food5,food6,food7});

            OrderDetails order1 = new OrderDetails(user1.UserID,new DateTime(2022,06,15),70,OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails(user2.UserID, new DateTime(2022,06,15),100,OrderStatus.Ordered);

            orderList.Add(order1);
            orderList.Add(order2);

            CartItem cart1 = new CartItem("OID1001",	"FID101",	20,	1);
            CartItem cart2 = new CartItem("OID1001"	,"FID103"	,10	,1);
            CartItem cart3 = new CartItem("OID1001",	"FID105"	,40	,1);
            CartItem cart4 = new CartItem("OID1002",	"FID103"	,10,	1);
            CartItem cart5 = new CartItem("OID1002",	"FID104"	,50,	1);
            CartItem cart6 = new CartItem("OID1002"	,"FID105",	40,	1);

            cartList.AddRange(new CustomList<CartItem>{cart1, cart2,cart3,cart4,cart5,cart6});
        }
    }
}