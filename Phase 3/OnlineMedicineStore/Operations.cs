using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicineStore
{
    /// <summary>
    /// This Operation class performs the required functionalities for medicine store.
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// this property is used to store current user data.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static UserDetails CurrentLoggedInUser;
        /// <summary>
        /// This list is used to store user objects in the list 
        /// </summary>
        /// <typeparam name="UserDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<UserDetails> userList = new CustomList<UserDetails>();
        /// <summary>
        /// This list is used to store medicine objects in the list
        /// </summary>
        /// <typeparam name="MedicineDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<MedicineDetails> medicineList = new CustomList<MedicineDetails>();
        /// <summary>
        /// This list is used to store order objects in the list
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <typeparam name="OrderDetails"></typeparam>
        /// <returns></returns>
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        /// <summary>
        /// MainMenu method is used to initiate the application and its functionalities, where user can choose options.
        /// </summary>
        public static void MainMenu()
        {
            int mainMenuOption;
           
            do
            {
                 Console.WriteLine($"*************Medicine Store*************");
                Console.WriteLine($"1.Regsitration\n2.userLogin\n3.Exit");
                mainMenuOption = int.Parse(Console.ReadLine());
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
                        Console.WriteLine($"*************user LOGIN*************");
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
        /// <summary>
        /// Registration method is used to get details from the user and create an object.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void Registration()
        {
            Console.Write($"Enter your name");
            string name = Console.ReadLine();
            
            Console.Write("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.Write($"Enter your city");
            string city = Console.ReadLine();
            Console.Write($"Enter your Mobile");
            string mobile = Console.ReadLine();
            
            
            Console.Write("Enter your balance:");
            int balance = int.Parse(Console.ReadLine());
            UserDetails user = new UserDetails(name,age,city,mobile,balance);
            userList.Add(user);
        }//Registration
        /// <summary>
         /// User login method is used to validate user login Id and perform specific task.
        /// </summary>
        public static void UserLogin()
        {
            Console.Write($"Enter user loginID:");
            string userLogin = Console.ReadLine();
            bool flag = true;
            foreach(UserDetails user in userList)
            {
                if(userLogin.Equals(user.UserID))
                {
                    flag = false;
                    CurrentLoggedInUser = user;
                    Console.WriteLine($"Login Successful");
                    SubMenu();
                    break;
                }
            }
            if(flag) 
            {
                Console.WriteLine($"Invalid user ID");
            }
        }//UserLogin
        /// <summary>
        /// this method is used to get option from the user and perform specific functions.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void SubMenu()
        {
            
            char subMenuOption;
            do
            {
            Console.WriteLine($"a)	Show medicine list");
            Console.WriteLine($"b)	Purchase Medicine");
            Console.WriteLine($"c)	Modify Purchase");
            Console.WriteLine($"d)	Cancel Purchase");
            Console.WriteLine($"e)	Show Purchase History");
            Console.WriteLine($"f)	RechargeWallet");
            Console.WriteLine($"g)	 Show Balance");
            Console.WriteLine($"h)	Exit");
            Console.WriteLine($"Choose an option");
                 subMenuOption = char.Parse(Console.ReadLine());
                switch(subMenuOption)
                {
                    case 'a':
                    {
                        ShowMedicineList();
                        break;
                    }
                    case 'b':
                    {
                        PurchaseMedicine();
                        break;
                    }
                    case 'c':
                    {
                        ModifyPurchase();
                        break;
                    }
                    case 'd':
                    {
                        CancelPurchase();
                        break;
                    }
                    case 'e':
                    {
                        ShowPurchaseHistory();
                        break;
                    }
                    case 'f':
                    {
                        RechargeWallet();
                        break;
                    }
                    case 'g':
                    {
                        ShowWalletBalance();
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
        /// <summary>
        /// This method is used to display medicine details.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void ShowMedicineList()
        {
            foreach(MedicineDetails medicine in medicineList)
            {
                Console.WriteLine($"{medicine.MedicineID} {medicine.MedicineName} {medicine.AvailableCount} {medicine.Price} {medicine.DateOfExpiry}");
            }
        }//ShowMedicineList
        /// <summary>
        /// This method is used to purchase medicine.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void PurchaseMedicine()
        {
            ShowMedicineList();
            Console.Write($"Choose Medicine ID:");
            string choosemedicine = Console.ReadLine();
            Console.Write($"count of the medicine");
            int count = int.Parse(Console.ReadLine());
            bool flag = false;
            foreach(MedicineDetails medicine in medicineList)
            {
                if(medicine.MedicineID.Equals(choosemedicine))
                {
                    flag = true;
                    if(count<=medicine.AvailableCount)
                    {
                        if(medicine.DateOfExpiry>=DateTime.Today)
                        {
                            double totalPrice = medicine.Price*count;
                            if(CurrentLoggedInUser.WalletBalance>=totalPrice)
                            {
                                medicine.AvailableCount -= count;
                                CurrentLoggedInUser.DetuctBalance(totalPrice);
                                OrderDetails order = new OrderDetails(CurrentLoggedInUser.UserID,medicine.MedicineID,count,totalPrice,DateTime.Now,OrderStatus.Purchased);
                                orderList.Add(order);
                                Console.WriteLine($"Medicine purchased");
                                
                            }
                        }
                        else Console.WriteLine($"Medicine not available");
                        
                    }
                    else{
                        Console.WriteLine($"Out of stock");
                        
                    }
                }
            }
            if(flag == false)
            {
                Console.WriteLine($"Invalid medicine ID");
                
            }
            
            
        }//PurchaseMedicine
        /// <summary>
        /// This method is used to modify the purchase.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void ModifyPurchase()
        {
            bool flag = false;
            foreach(OrderDetails order in orderList)
            {
                if(CurrentLoggedInUser.UserID.Equals(order.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    flag = true;
                Console.WriteLine($"{order.OrderID} {order.MedicineID} {order.MedicineCount} {order.TotalPrice} {order.OrderDate} {order.OrderStatus}");
                }
            }
            if(flag ==true)
            {
                Console.WriteLine($"Enter order ID");
                string selectOrder = (Console.ReadLine());
                foreach(OrderDetails order in orderList)
                {
                    if(order.OrderID.Equals(selectOrder))
                    {
                        Console.WriteLine($"Enter Quantity");
                        int quantity = int.Parse(Console.ReadLine());
                        double pricePerQuantity = order.TotalPrice/order.MedicineCount;
                        double totalPrice = quantity*pricePerQuantity;
                        foreach(MedicineDetails medicine in medicineList)
                        {
                            if(medicine.AvailableCount>quantity)
                            {
                                if(medicine.MedicineID.Equals(order.MedicineID))
                                {
                                    
                                    if(quantity>order.MedicineCount)
                                    {
                                    medicine.AvailableCount = medicine.AvailableCount - Math.Abs(quantity - order.MedicineCount);
                                    order.MedicineCount = quantity;
                                    order.TotalPrice = totalPrice;
                                    Console.WriteLine($"Modified Successfully");
                                    }
                                    else if(quantity<order.MedicineCount)
                                    {
                                    medicine.AvailableCount = medicine.AvailableCount + Math.Abs(quantity - order.MedicineCount);   
                                    order.MedicineCount = quantity;
                                    order.TotalPrice = totalPrice;
                                    Console.WriteLine($"Modified Successfully");                                
                                    }
                                }
                            }
                            
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"No data found");
            }
        }//ModifyPurchase
        /// <summary>
        /// This method is used to cancle purchase.
        /// </summary>
        public static void CancelPurchase()
        {
            foreach(OrderDetails order in orderList)
            {
                if(order.UserID.Equals(CurrentLoggedInUser.UserID) && order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    Console.WriteLine($"{order.OrderID}  {order.UserID}  {order.MedicineID}   {order.TotalPrice}  {order.OrderDate}   {order.OrderStatus}");
                }
            }
            Console.WriteLine($"enter order ID");
            string selectOrder = Console.ReadLine();
            bool checkOrderID = false;
            foreach(OrderDetails order in orderList)
            {
                if(order.OrderID.Equals(selectOrder) && order.OrderStatus.Equals(OrderStatus.Purchased))
                {
                    checkOrderID = true;
                    foreach(MedicineDetails medicine in medicineList)
                    {
                        if(order.MedicineID.Equals(medicine.MedicineID))
                        {
                            medicine.AvailableCount+=order.MedicineCount;
                            CurrentLoggedInUser.WalletRecharge(order.TotalPrice);
                            order.OrderStatus = OrderStatus.Cancelled;
                            Console.WriteLine($"{order.OrderID} was cancelled successfully.");
                            
                        }
                    }
                }
            }
            if(checkOrderID ==false)
            {
                Console.WriteLine($"Invalid OrderID!");
                
            }
            
        }//CancelPurchase
        /// <summary>
        /// This method is used show purchase history.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void ShowPurchaseHistory()
        {
            foreach(OrderDetails order in orderList)
            {
                Console.WriteLine($"{order.OrderID} {order.UserID} {order.MedicineID} {order.MedicineCount} {order.TotalPrice} {order.OrderDate} {order.OrderStatus}");
            }
        }//ShowPurchaseHistory
        /// <summary>
        /// This method is used to recharge wallet
        /// </summary>
        public static void RechargeWallet()
        {
            Console.WriteLine($"Enter amount to recharge.");
            double amount = double.Parse(Console.ReadLine());
            CurrentLoggedInUser.WalletRecharge(amount);
            
        }//RechargeWallet
        /// <summary>
        /// This methos is used to show wallet balance
        /// </summary>
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"Wallet Balance: {CurrentLoggedInUser.WalletBalance}");
            
        }//ShowWalletBalance
        /// <summary>
        /// This method is used to add default data to the list.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void AddDefaultData()
        {
            UserDetails user = new UserDetails("Ravi",	33	,"Theni"	,"9877774440",	400);
            userList.Add(user);
            MedicineDetails medicine1 = new MedicineDetails("Paracitamol",	40,	5	,new DateTime(2024,06,20));
            MedicineDetails medicine2 = new MedicineDetails("Calpol",	10,	5	,new DateTime(2024,06,20));
            MedicineDetails medicine3 = new MedicineDetails("Gelucil",	4,	40	,new DateTime(2024,06,20));
            MedicineDetails medicine4 = new MedicineDetails("Metrogel",	5,	50	,new DateTime(2024,06,20));
            MedicineDetails medicine5 = new MedicineDetails("Povidin Iodin",	10,	50	,new DateTime(2024,06,20));
            medicineList.Add(medicine1);
            medicineList.Add(medicine2);
            medicineList.Add(medicine3);
            medicineList.Add(medicine4);
            medicineList.Add(medicine5);

            OrderDetails order1 = new OrderDetails("UID1001","MD101",	3	,15	,new DateTime(2022,11,13)	,OrderStatus.Purchased);
            OrderDetails order2 = new OrderDetails("UID1001","MD102"	,2,	10,	new DateTime(2022,11,13),	OrderStatus.Cancelled);
            OrderDetails order3 = new OrderDetails("UID1001","MD104",	2	,100	,new DateTime(2022,11,13)	,OrderStatus.Purchased);
            OrderDetails order4 = new OrderDetails("UID1002","MD103"	,3	,120,new DateTime(2022,11,13)	,OrderStatus.Purchased);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);
        }
    }
}