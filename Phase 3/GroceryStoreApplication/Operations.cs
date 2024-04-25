using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryStoreApplication
{
    public class Operations
    {
        public static CustomerDetails CurrentLoggedIncustomer;
        public static CustomList<CustomerDetails> customerList = new CustomList<CustomerDetails>();
        public static CustomList<ProductDetails> productList = new CustomList<ProductDetails>();
        public static CustomList<BookingDetails> bookingList = new CustomList<BookingDetails>();
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();
        
        public static void MainMenu()
        {
            int mainMenuOption;
            do
            {
                 Console.WriteLine($"*************Grocery*************");
                Console.WriteLine($"1.Regsitration\n2.customerLogin\n3.Exit");
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
                        Console.WriteLine($"*************customer LOGIN*************");
                        customerLogin();
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
        public static  void Registration()
        {
            Console.Write($"Enter name: ");
            string name = Console.ReadLine();
            Console.Write($"Enter fatherName: ");
            string fatherName = Console.ReadLine();
            Console.Write($"Enter Gender: ");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine());
            Console.Write($"Enter Mobile number: ");
            string mobile = Console.ReadLine();
            Console.Write($"Enter DOB: ");
            DateTime dob  = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy",null);
            Console.Write($"Enter MailID: ");
            string mailID = Console.ReadLine();
            Console.Write($"Enter Balance: ");
            double balance = double.Parse(Console.ReadLine());

            CustomerDetails customer = new CustomerDetails(name,fatherName,gender,mobile,dob,mailID,balance);
            customerList.Add(customer);
        }//Registration ends here
        public static void customerLogin()
        {
            Console.Write($"Enter customer loginID:");
            string customerLogin = Console.ReadLine();
            bool flag = true;
            foreach(CustomerDetails customer in customerList)
            {
                if(customerLogin.Equals(customer.CustomerID))
                {
                    flag = false;
                    CurrentLoggedIncustomer = customer;
                    Console.WriteLine($"Login Successful");
                    SubMenu();
                    break;
                }
            }
            if(flag) 
            {
                Console.WriteLine($"Invalid customer ID");
            }
        }//customerLogin ends here
        public static void SubMenu()
        {
            
            char subMenuOption;
            do
            {
            Console.WriteLine($"a)	Show Customer Details");
            Console.WriteLine($"b)	Show Product Details");
            Console.WriteLine($"c)	Wallet Recharge");
            Console.WriteLine($"d)	Take Order");
            Console.WriteLine($"e)	Modify Order Quantity");
            Console.WriteLine($"f)	Cancel Order");
            Console.WriteLine($"g)	Show Balance");
            Console.WriteLine($"h)	Exit");
            Console.WriteLine($"Choose an option");
                 subMenuOption = char.Parse(Console.ReadLine());
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
            Console.WriteLine($"Customer Id :{CurrentLoggedIncustomer.CustomerID}");
            Console.WriteLine($"Father Name: {CurrentLoggedIncustomer.FatherName}");
            Console.WriteLine($"Gender: {CurrentLoggedIncustomer.Gender}");
            Console.WriteLine($"Mobile: {CurrentLoggedIncustomer.Mobile}");
            Console.WriteLine($"DOB: {CurrentLoggedIncustomer.DOB}");
            Console.WriteLine($"MailID: {CurrentLoggedIncustomer.MailID}");
            
        }//ShowCustomerDetails

        static void ShowProductDetails()
        {
            foreach(ProductDetails product in productList)
            {
                product.ShowProductDetail();
            }
        }//ShowProductDetails

        static void WalletRecharge()
        {
            Console.Write($"enter amount to recharge: ");
            double amount = double.Parse(Console.ReadLine());
            CurrentLoggedIncustomer.WalletRecharge(amount);
        }//WalletRecharge

        static void TakeOrder()
        {
            double totalPurchaseAmount=0.0;
            Console.Write($"Do you want to purchase: (Yes/No):");
            string purchaseChoice = Console.ReadLine();
            if(purchaseChoice == "yes")
            {
                BookingDetails booking = new BookingDetails(CurrentLoggedIncustomer.CustomerID,0, DateTime.Now,BookingStatus.Initiated);
                CustomList<OrderDetails> tempOrderList = new CustomList<OrderDetails>();
                string anotherProduct;
                do{
                ShowProductDetails();
                Console.Write($"Enter ProductID:");
                string selectProduct = Console.ReadLine();
                bool flag = false;
                foreach(ProductDetails product in productList)
                {
                    if(product.ProductID.Equals(selectProduct))
                    {
                        flag= true;
                        if(product.QuantityAvailable>0)
                        {
                            Console.Write($"Enter quantity");
                            int purchaseCount = int.Parse(Console.ReadLine());
                            OrderDetails order = new OrderDetails(booking.BookingID,product.ProductID,purchaseCount,product.PricePerQuantity);
                            tempOrderList.Add(order);
                            product.QuantityAvailable-=purchaseCount;
                            totalPurchaseAmount = purchaseCount*product.PricePerQuantity;
                            Console.WriteLine($"Product Successfully added to cart.");
                            
                        }   
                        else Console.WriteLine($"Stock Unavailable");
                    }
                }
                if(!flag) Console.WriteLine($"Invalid ProductID");
                Console.WriteLine($"Do you want to book another product: (yes/no)");
                anotherProduct = Console.ReadLine();
                }while(anotherProduct=="yes");
                Console.Write($"Do you want to confirm the order: (yes/no)");
                string orderconfirmation = Console.ReadLine();
                if(orderconfirmation=="yes")
                {
                    if(CurrentLoggedIncustomer.WalletBalance>totalPurchaseAmount)
                    {
                            CurrentLoggedIncustomer.WalletBalance-=totalPurchaseAmount;
                            booking.BookingStatus = BookingStatus.Booked;
                            booking.TotalPrice = totalPurchaseAmount;
                            BookingDetails booked = new BookingDetails(CurrentLoggedIncustomer.CustomerID,totalPurchaseAmount,DateTime.Now,BookingStatus.Booked);
                            bookingList.Add(booked);
                            orderList= tempOrderList;
                            Console.WriteLine($"Booked Successfully");
                            
                    }
                    else Console.WriteLine($"Recharge your wallet.");
                    
                }
                
            }
            
            
        }//TakeOrder

        static void ModifyOrderQuantity()
        {
            foreach(BookingDetails booking in bookingList)
            {
                if(CurrentLoggedIncustomer.CustomerID.Equals(booking.CustomerID)&& booking.BookingStatus == BookingStatus.Booked)
                {
                    booking.ShowBookingDetails();
                }
            }
            foreach(OrderDetails order in orderList)
            {
                Console.WriteLine($"Order ID: {order.OrderID}| BookingID: {order.BookingID}| Product ID: {order.ProductID}| Purchase Count: {order.PurchaseCount}| Price :{order.PriceOfOrder}");
            }
            Console.Write($"Enter the Booking ID: ");
            string selectBookingID = Console.ReadLine();
            bool checkBookingID = false;
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.BookingID.Equals(selectBookingID))
                {
                    checkBookingID=true;
                    foreach(OrderDetails order in orderList)
                    {
                        if(order.BookingID.Equals(selectBookingID))
                        {
                            Console.WriteLine($"{order.OrderID}  {order.BookingID}   {order.ProductID}    {order.PurchaseCount}   {order.PriceOfOrder}");
                        }
                    }
                }
            }
            if(checkBookingID==false)
            {
                Console.WriteLine($"Invalid Booking ID");
            }
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.BookingID.Equals(selectBookingID))
                {
                    Console.Write($"Enter order id:");
                    string selectOrderID = Console.ReadLine();
                    bool checkOrderID = false;
                    foreach(OrderDetails order in orderList)
                    {
                        if(order.OrderID.Equals(selectOrderID))
                        {
                            checkOrderID = true;
                            Console.Write($"Enter new Quantity:");
                            int newQuantity = int.Parse(Console.ReadLine());
                            foreach(ProductDetails product in productList)
                            {
                                if(order.ProductID.Equals(product.ProductID))
                                {
                                    double orderPrice = newQuantity*product.PricePerQuantity;
                                    if(newQuantity<product.QuantityAvailable)
                                    {
                                        if(newQuantity<order.PurchaseCount)
                                        {
                                            product.QuantityAvailable += newQuantity;
                                            CurrentLoggedIncustomer.WalletRecharge(orderPrice);
                                        }
                                        else if(newQuantity>order.PurchaseCount)
                                        {
                                            product.QuantityAvailable -= newQuantity;
                                            CurrentLoggedIncustomer.WalletBalance -= orderPrice;
                                        }
                                        else 
                                        {
                                            Console.WriteLine($"New Quantity is same as old.");
                                            break;
                                        }
                                        booking.TotalPrice = booking.TotalPrice - order.PriceOfOrder + orderPrice;
                                        order.PriceOfOrder = orderPrice;
                                        Console.WriteLine($"Order Modified");
                                        
                                    }
                                }
                            }
                        }
                    }
                    if(checkOrderID==false)
                    {
                        Console.WriteLine($"Invalid Order ID!");
                    }
                }
            }
        }//ModifyOrderQuantity

        public static void CancelOrder()
        {
            foreach(BookingDetails booking in bookingList)
            {
                if(CurrentLoggedIncustomer.CustomerID.Equals(booking.CustomerID)&& booking.BookingStatus == BookingStatus.Booked)
                {
                    booking.ShowBookingDetails();
                }
            }
            Console.Write($"Enter booking ID:");
            string selectBookingID = Console.ReadLine();
            bool checkBookingID = false;
            foreach(BookingDetails booking in bookingList)
            {
                if(booking.BookingID.Equals(selectBookingID))
                {
                    checkBookingID = true;
                    booking.BookingStatus=BookingStatus.Cancelled;
                    CurrentLoggedIncustomer.WalletRecharge(booking.TotalPrice);
                    foreach(OrderDetails order in orderList)
                    {
                        if(booking.BookingID.Equals(order.BookingID))
                        {
                            foreach(ProductDetails product in productList)
                            {
                                if(product.ProductID.Equals(order.ProductID))
                                {
                                    product.QuantityAvailable += order.PurchaseCount;
                                }
                            }
                        }
                    }
                    Console.WriteLine($"Booking Cancelled Sucessfully.");
                }
            }
            if(checkBookingID==false)
            {
                Console.WriteLine($"Invalid Booking ID");
            }
            
        }//CancelOrder

        static void ShowBalance()
        {
            Console.WriteLine($"Balance : {CurrentLoggedIncustomer.WalletBalance}");
            
        }//ShowBalance

        public static void AddingDefaultData()
        {
            CustomerDetails customer1 = new CustomerDetails("Ravi"	,"Ettapparajan"	,Gender.Male	,"974774646"	,new DateTime(1999,11,11),	"ravi@gmail.com",10000);
            customerList.Add(customer1);

            ProductDetails product1 = new ProductDetails("Sugar",	20	,40);
            ProductDetails product2 = new ProductDetails("Rice"	,100,	50);
            ProductDetails product3 = new ProductDetails("Milk"	,10	,40);
            ProductDetails product4 = new ProductDetails("Coffee",	10,	10);
            ProductDetails product5 = new ProductDetails("Tea",	10	,10);
            ProductDetails product6 = new ProductDetails("Masala Powder",	10,	20);

            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);

            BookingDetails booking1  = new BookingDetails("CID1001",	220,new DateTime(2022,07,26),BookingStatus.Booked);
            BookingDetails booking2  = new BookingDetails("CID1002",	400,	new DateTime(2022,07,26) ,BookingStatus.Booked);
            BookingDetails booking3  = new BookingDetails("CID1001"	,280	,new DateTime(2022,07,26),	BookingStatus.Cancelled);
            BookingDetails booking4  = new BookingDetails("CID1002"	,0,new DateTime(2022,07,26)	,BookingStatus.Initiated);

            bookingList.Add(booking1);
            bookingList.Add(booking2);
            bookingList.Add(booking3);
            bookingList.Add(booking4);

            OrderDetails order1 = new OrderDetails("BID3001",	"PID2001",	2,	80);
            OrderDetails order2 = new OrderDetails("BID3001"	,"PID2002"	,2,	100);
            OrderDetails order3 = new OrderDetails("BID3001"	,"PID2003"	,1,	40);
            OrderDetails order4 = new OrderDetails("BID3002",	"PID2001",	1,	40);
            OrderDetails order5 = new OrderDetails("BID3002",	"PID2002",	4,	200);
            OrderDetails order6 = new OrderDetails("BID3002"	,"PID2010",	1,	140);
            OrderDetails order7 = new OrderDetails("BID3002",	"PID2009"	,1,	20);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
            orderList.Add(order4);
            orderList.Add(order5);
            orderList.Add(order6);
            orderList.Add(order7);
        }
    }
}