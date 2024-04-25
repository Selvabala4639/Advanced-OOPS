using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace OnlineFoodDeliveryApplication
{
    public class Operations
    {
        public static CustomerDetails currentLoggedInCustomer;
        public static CustomList<CustomerDetails> customerList = new CustomList<CustomerDetails>();
        public static CustomList<FoodDetails> foodList = new CustomList<FoodDetails>();
        public static CustomList<ItemDetails> itemList = new CustomList<ItemDetails>();
        public static CustomList<OrderDetails> orderList = new CustomList<OrderDetails>();

        /// <summary>
        /// This method is used to initiate the appliication and gets option from the user to perform functions.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void MainMenu()
        {
            int mainMenuOption;
            do
            {
                Console.WriteLine($"*********************Welcome To Online Food Delivery Application*********************");
                Console.WriteLine($"1.Customer Registration\n2.Customer Login\n3.Exit");
                Console.WriteLine($"Choose an option");
                mainMenuOption = int.Parse(Console.ReadLine());
                switch (mainMenuOption)
                {
                    case 1:
                        {
                            Console.WriteLine($"*********************Registration*********************");
                            Registration();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine($"*********************Customer Login*********************");
                            UserLogin();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine($"Application Ended");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

            } while (mainMenuOption != 3);
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
            Console.Write($"Enter your Father name");
            string fatherName = Console.ReadLine();
            Console.Write($"Enter your Gender");
            Gender gender = Enum.Parse<Gender>(Console.ReadLine());
            Console.Write($"Enter your Mobile");
            string mobile = Console.ReadLine();
            Console.Write($"Enter your DOB");
            DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write($"Enter your MailID");
            string mailID = Console.ReadLine();
            Console.Write($"Enter your Location");
            string location = Console.ReadLine();
            Console.Write("Enter your balance:");
            int balance = int.Parse(Console.ReadLine());
            CustomerDetails customer = new CustomerDetails(balance, name, fatherName, gender, mobile, dob, mailID, location);
            customerList.Add(customer);
        }//Registration

        /// <summary>
        /// User login method is used to validate user login Id and perform specific task.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void UserLogin()
        {
            Console.Write($"Enter your loginID:");
            string loginId = Console.ReadLine();
            bool flag = false;
            foreach (CustomerDetails customer in customerList)
            {
                if (loginId.Equals(customer.CustomerID))
                {
                    flag = true;
                    currentLoggedInCustomer = customer;
                    Console.WriteLine($"Customer registration successful Your Customer ID:  {currentLoggedInCustomer.CustomerID}");
                    SubMenu();
                    break;
                }
            }
            if (flag == false)
            {
                Console.WriteLine($"Invalid User ID");
            }

        }//UserLogin
        
        /// <summary>
        /// this method is used to get option from the user and perform specific functions.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void SubMenu()
        {
            int subMenuOption;
            do
            {
                Console.WriteLine($"1. Show Profile\n2. Order food\n3. Cancel Order\n4. Modify order\n5. Order History\n6.Recharge Wallet\n7.Show Wallet Balance\n8.Exit");
                subMenuOption = int.Parse(Console.ReadLine());
                switch (subMenuOption)
                {
                    case 1:
                        {
                            ShowProfile();
                            break;
                        }
                    case 2:
                        {
                            OrderFood();
                            break;
                        }
                    case 3:
                        {
                            CancelFood();
                            break;
                        }
                    case 4:
                        {
                            ModifyFood();
                            break;
                        }
                    case 5:
                        {
                            OrderHistory();
                            break;
                        }
                    case 6:
                        {
                            RechargeWallet();
                            break;
                        }
                    case 7:
                        {
                            ShowWalletBalance();
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine($"Application Ended");

                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Inalid option");

                            break;
                        }
                }
            } while (subMenuOption != 8);
        }//SubMenu
        /// <summary>
        /// This method is used to display user information.
        /// </summary>
        public static void ShowProfile()
        {
            Console.WriteLine($"Customer Id: {currentLoggedInCustomer.CustomerID}");
            Console.WriteLine($"Customer Name: {currentLoggedInCustomer.Name}");
            Console.WriteLine($"Customer FatherName: {currentLoggedInCustomer.FatherName}");
            Console.WriteLine($"Customer Gender: {currentLoggedInCustomer.Gender}");
            Console.WriteLine($"Customer Mobile: {currentLoggedInCustomer.Mobile}");
            Console.WriteLine($"Customer DOB: {currentLoggedInCustomer.DOB}");
            Console.WriteLine($"Customer MailID: {currentLoggedInCustomer.MailID}");
            Console.WriteLine($"Customer Location: {currentLoggedInCustomer.Location}");
            Console.WriteLine($"Customer Balance: {currentLoggedInCustomer.WalletBalance}");
        }//ShowProfile
        /// <summary>
        /// This method is used to order food.
        /// </summary>
        public static void OrderFood()
        {
            //Create order object
            OrderDetails newOrder = new OrderDetails(currentLoggedInCustomer.CustomerID, 0, DateTime.Today, OrderStatus.Initiated);
            orderList.Add(newOrder);
            //create locallistitem for wishlist
            CustomList<ItemDetails> localItemList = new CustomList<ItemDetails>();
            //Shoe list of foods
            int foodCount = 0;
            foreach (FoodDetails food in foodList)
            {
                foodCount++;
                if (foodCount == 1)
                    Console.WriteLine($"FoodID  FoodName  Price per Quantity   Quantity available");
                Console.WriteLine($"{food.FoodId}  {food.FoodName}  {food.PricePerQuantity}  {food.QuantityAvailable}");
            }
            string addMoreFood = "";
            double totalPrice = 0;
            int checkfoodCount = 0;
            do
            {
                //Ask foodID and check
                Console.Write($"Enter food Id:");
                string selectFoodID = Console.ReadLine();
                bool validFoodID = false;

                foreach (FoodDetails food in foodList)
                {
                    if (food.FoodId.Equals(selectFoodID))
                    {
                        validFoodID = true;
                        //Ask quantity
                        Console.Write($"Enter quantity:");
                        int selectQuantity = int.Parse(Console.ReadLine());
                        if (selectQuantity < food.QuantityAvailable)
                        {
                            //create Itemdetails obj
                            double priceOfOrder = selectQuantity * food.PricePerQuantity;
                            ItemDetails newItem = new ItemDetails(newOrder.OrderID, food.FoodId, selectQuantity, priceOfOrder);
                            //Detuct avaliable quantity in food details
                            food.QuantityAvailable -= selectQuantity;
                            localItemList.Add(newItem);
                            totalPrice = totalPrice + priceOfOrder;
                            //ask user to add more
                            checkfoodCount++;
                            Console.WriteLine($"Do you want to add more food.");
                            addMoreFood = Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"Unavailable Quantity");
                            break;
                        }
                        break;
                    }
                }
                if (validFoodID == false)
                {
                    Console.WriteLine($"Invalid /food ID");
                    break;
                }
            } while (addMoreFood == "yes");
            //confirm purchase. If no return localitem list of item count to food details
            if (checkfoodCount > 0)
            {
                bool rechargeFlag = false;
                do
                {
                    Console.Write($"Do you want to confirm Purchase:");
                    string confirmPurchase = Console.ReadLine();
                    if (confirmPurchase == "yes")
                    {
                        if (currentLoggedInCustomer.WalletBalance >= totalPrice)
                        {
                            newOrder.TotalPrice = totalPrice;
                            newOrder.OrderStatus = OrderStatus.Ordered;
                            currentLoggedInCustomer.DeductBalance(totalPrice);
                            itemList.AddRange(localItemList);
                            Console.WriteLine($"Order Successful");
                            break;
                        }
                        else
                        {
                            Console.Write($"Insuffiecient Balance\nDo you wish to recharge:");
                            string wishToRecharge = Console.ReadLine();
                            if (wishToRecharge == "yes")
                            {
                                RechargeWallet();
                                Console.WriteLine($"After Recharge");
                                rechargeFlag = true;
                            }
                            else
                            {
                                foreach (ItemDetails localItem in localItemList)
                                {
                                    foreach (FoodDetails food in foodList)
                                    {
                                        if (food.FoodId.Equals(localItem.FoodID))
                                        {
                                            food.QuantityAvailable += localItem.PurchaseCount;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        foreach (ItemDetails localItem in localItemList)
                        {
                            foreach (FoodDetails food in foodList)
                            {
                                if (food.FoodId.Equals(localItem.FoodID))
                                {
                                    food.QuantityAvailable += localItem.PurchaseCount;
                                }
                            }
                        }
                    }
                } while (rechargeFlag == true);

            }
            else
            {
                Console.WriteLine($"No food in the cart.");

            }

        }//OrderFood
        /// <summary>
        /// This methos is used to cancel food.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void CancelFood()
        {
            int orderCount = 0;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoggedInCustomer.CustomerID.Equals(order.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    orderCount++;
                    if (orderCount == 1)
                    {
                        Console.WriteLine($"Order ID  Customer Id  Total Price  Date of Order  Order Status");
                    }
                    Console.WriteLine($"{order.OrderID}  {order.CustomerID}  {order.TotalPrice}  {order.DateOfOrder}  {order.OrderStatus}");
                }
            }
            Console.Write($"Pick an Order ID to cancel: ");
            string chooseOrder = Console.ReadLine();
            foreach (OrderDetails order in orderList)
            {
                if (order.OrderID.Equals(chooseOrder))
                {
                    order.OrderStatus = OrderStatus.Cancelled;
                    Console.WriteLine($"Order ({order.OrderID}) Cancelled");

                    currentLoggedInCustomer.WalletRecharge(order.TotalPrice);
                    foreach (ItemDetails item in itemList)
                    {
                        if (item.OrderID.Equals(order.OrderID))
                        {
                            foreach (FoodDetails food in foodList)
                            {
                                if (food.FoodId.Equals(item.FoodID))
                                {
                                    food.QuantityAvailable += item.PurchaseCount;
                                }
                            }
                        }
                    }
                }
            }

        }//CancelFood
        /// <summary>
        /// This method is used to modify food in order list.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void ModifyFood()
        {
            double totalPrice = 0;
            int orderCount = 0;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoggedInCustomer.CustomerID.Equals(order.CustomerID) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    orderCount++;
                    if (orderCount == 1)
                    {
                        Console.WriteLine($"Order ID  Customer Id  Total Price  Date of Order  Order Status");
                    }
                    Console.WriteLine($"{order.OrderID}  {order.CustomerID}  {order.TotalPrice}  {order.DateOfOrder}  {order.OrderStatus}");
                }
            }

            Console.Write($"Enter order id for modification:");
            string chooseOrder = Console.ReadLine();

            foreach (OrderDetails order in orderList)
            {
                if (order.CustomerID.Equals(currentLoggedInCustomer.CustomerID) && order.OrderID.Equals(chooseOrder) && order.OrderStatus.Equals(OrderStatus.Ordered))
                {
                    foreach (ItemDetails item in itemList)
                    {
                        if (item.OrderID.Equals(order.OrderID))
                        {
                            Console.WriteLine($"{item.ItemID}   {item.OrderID}    {item.FoodID}    {item.PurchaseCount}   {item.PriceOfOrder}");
                        }
                    }
                }
            }
            Console.Write($"Enter Item ID: ");
            string chooseItemID = Console.ReadLine();
            bool checkItemID = false;
            string chooseRecharge;
            foreach (OrderDetails order in orderList)
            {
                foreach (ItemDetails item in itemList)
                {
                    if (order.OrderID.Equals(item.OrderID))
                    {
                        if (item.ItemID.Equals(chooseItemID))
                        {
                            checkItemID = true;
                            Console.Write($"Enter new Quantiity");
                            int newQuantity = int.Parse(Console.ReadLine());
                            foreach (FoodDetails food in foodList)
                            {
                                double pricePerQuantity = 0;
                                if (item.FoodID.Equals(food.FoodId))
                                {
                                    if (food.QuantityAvailable >= newQuantity)
                                    {
                                        if (newQuantity > item.PurchaseCount)
                                        {
                                            pricePerQuantity = item.PriceOfOrder / item.PurchaseCount;
                                            if (pricePerQuantity * newQuantity <= currentLoggedInCustomer.WalletBalance)
                                            {
                                                double deductAmount = Math.Abs(item.PurchaseCount - newQuantity) * pricePerQuantity;
                                                currentLoggedInCustomer.DeductBalance(deductAmount);
                                                food.QuantityAvailable = food.QuantityAvailable - Math.Abs(item.PurchaseCount - newQuantity);
                                                item.PriceOfOrder = newQuantity * pricePerQuantity;
                                                item.PurchaseCount = newQuantity;
                                                totalPrice += item.PriceOfOrder;
                                                order.TotalPrice = totalPrice;
                                                Console.WriteLine($"Order ID {order.OrderID} modified successfully");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"Insufficient Balance");
                                                Console.WriteLine($"Do you want to recharge");
                                                chooseRecharge = Console.ReadLine();
                                                Console.WriteLine($"{pricePerQuantity * newQuantity} is required for purchasing.");
                                                if (chooseRecharge == "yes")
                                                {
                                                    Console.Write($"Enter amount:");
                                                    double amount = double.Parse(Console.ReadLine());
                                                    currentLoggedInCustomer.WalletRecharge(amount);
                                                    double deductAmount = Math.Abs(item.PurchaseCount - newQuantity) * pricePerQuantity;
                                                    currentLoggedInCustomer.DeductBalance(deductAmount);
                                                    food.QuantityAvailable = food.QuantityAvailable - Math.Abs(item.PurchaseCount - newQuantity);
                                                    item.PriceOfOrder = newQuantity * pricePerQuantity;
                                                    item.PurchaseCount = newQuantity;
                                                    totalPrice += item.PriceOfOrder;
                                                    order.TotalPrice = totalPrice;
                                                    Console.WriteLine($"Order ID {order.OrderID} modified successfully");
                                                }
                                            }
                                            //food.QuantityAvailable = food.QuantityAvailable -Math.Abs(item.PurchaseCount - newQuantity);
                                        }
                                    }
                                    else if (newQuantity < item.PurchaseCount)
                                    {
                                        pricePerQuantity = item.PriceOfOrder / item.PurchaseCount;
                                        double returnAmount = item.PriceOfOrder - (newQuantity * pricePerQuantity);
                                        item.PurchaseCount = newQuantity;
                                        item.PriceOfOrder = newQuantity * pricePerQuantity;
                                        order.TotalPrice = order.TotalPrice - returnAmount;
                                        food.QuantityAvailable = food.QuantityAvailable + Math.Abs(item.PurchaseCount - newQuantity);
                                        currentLoggedInCustomer.WalletRecharge(returnAmount);
                                        Console.WriteLine($"Order ID {order.OrderID} modified successfully");
                                    }
                                }
                            }
                        }
                    }

                }
                if (checkItemID == false)
                {
                    Console.WriteLine($"Invalid Item ID");
                }

            }



        }//ModifyFood
        /// <summary>
        /// This method is used to display order history.
        /// </summary>
        public static void OrderHistory()
        {
            int orderCount = 0;
            foreach (OrderDetails order in orderList)
            {
                if (currentLoggedInCustomer.CustomerID.Equals(order.CustomerID))
                {
                    orderCount++;
                    if (orderCount == 1)
                    {
                        Console.WriteLine($"|Order ID|  |Customer ID|  |Total Price|  |Date of order|  |Order Status|");
                    }
                    Console.WriteLine($"{order.OrderID}  {order.CustomerID}  {order.TotalPrice}  {order.DateOfOrder}  {order.OrderStatus}");
                }
            }
        }//OrderHistory
        /// <summary>
        /// This method is used to recharge the user wallet.
        /// </summary>
        public static void RechargeWallet()
        {
            Console.WriteLine($"Enter amount too recharge");
            double amount = double.Parse(Console.ReadLine());
            currentLoggedInCustomer.WalletRecharge(amount);

        }//RechargeWallet
        /// <summary>
        /// This method is used to display user valance.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void ShowWalletBalance()
        {
            Console.WriteLine($"Your balance: {currentLoggedInCustomer.WalletBalance}");

        }//ShowWalletBalance
        /// <summary>
        /// This method is used to add default data to the list.
        /// </summary>
        public static void AddDefaultData()
        {
            CustomerDetails customer1 = new CustomerDetails(10000, "Ravi", "Ettapparajan", Gender.Male, "974774646", new DateTime(1999, 11, 11), "ravi@gmail.com", "Chennai");
            CustomerDetails customer2 = new CustomerDetails(15000, "Baskaran", "Sethurajan", Gender.Male, "847575775", new DateTime(1999, 11, 11), "baskaran@gmail.com", "Chennai");
            customerList.Add(customer1);
            customerList.Add(customer2);
            FoodDetails food1 = new FoodDetails("Chicken Briyani 1Kg", 100, 12);
            FoodDetails food2 = new FoodDetails("Mutton Briyani 1Kg", 150, 10);
            FoodDetails food3 = new FoodDetails("Veg Full Meals", 80, 30);
            FoodDetails food4 = new FoodDetails("Noodles", 100, 40);
            FoodDetails food5 = new FoodDetails("Dosa", 40, 40);
            FoodDetails food6 = new FoodDetails("Idly (2 pieces)", 20, 50);
            FoodDetails food7 = new FoodDetails("Pongal", 40, 20);
            FoodDetails food8 = new FoodDetails("Vegetable Briyani", 80, 15);
            FoodDetails food9 = new FoodDetails("Lemon Rice", 50, 30);
            FoodDetails food10 = new FoodDetails("Veg Pulav", 120, 30);
            FoodDetails food11 = new FoodDetails("Chicken 65 (200 Grams)", 75, 30);
            foodList.Add(food1);
            foodList.Add(food2);
            foodList.Add(food3);
            foodList.Add(food4);
            foodList.Add(food5);
            foodList.Add(food6);
            foodList.Add(food7);
            foodList.Add(food8);
            foodList.Add(food9);
            foodList.Add(food10);
            foodList.Add(food11);

            ItemDetails item1 = new ItemDetails("OID3001", "FID2001", 2, 200);
            ItemDetails item2 = new ItemDetails("OID3001", "FID2002", 2, 300);
            ItemDetails item3 = new ItemDetails("OID3001", "FID2003", 1, 80);
            ItemDetails item4 = new ItemDetails("OID3002", "FID2001", 1, 100);
            ItemDetails item5 = new ItemDetails("OID3002", "FID2002", 4, 600);
            ItemDetails item6 = new ItemDetails("OID3002", "FID2010", 1, 120);
            ItemDetails item7 = new ItemDetails("OID3002", "FID2009", 1, 50);
            ItemDetails item8 = new ItemDetails("OID3003", "FID2002", 2, 300);
            ItemDetails item9 = new ItemDetails("OID3003", "FID2008", 4, 320);
            ItemDetails item10 = new ItemDetails("OID3003", "FID2001", 2, 200);

            itemList.Add(item1);
            itemList.Add(item2);
            itemList.Add(item3);
            itemList.Add(item4);
            itemList.Add(item5);
            itemList.Add(item6);
            itemList.Add(item7);
            itemList.Add(item8);
            itemList.Add(item9);
            itemList.Add(item10);

            OrderDetails order1 = new OrderDetails("CID1001", 580, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order2 = new OrderDetails("CID1002", 870, new DateTime(2022, 11, 26), OrderStatus.Ordered);
            OrderDetails order3 = new OrderDetails("CID1001", 820, new DateTime(2022, 11, 26), OrderStatus.Cancelled);
            orderList.Add(order1);
            orderList.Add(order2);
            orderList.Add(order3);
        }
    }
}