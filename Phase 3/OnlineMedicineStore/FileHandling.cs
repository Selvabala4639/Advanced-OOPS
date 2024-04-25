using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicineStore
{
    public class FileHandling
    {
        /// <summary>
        /// Create method is used to create necessary folder and files for storing data as csv files.
        /// </summary>
        public static void Create()
        {
            if(!Directory.Exists("DataFolder"))
            {
                Directory.CreateDirectory("DataFolder");
            }
            if(!File.Exists("DataFolder/UserDetails.csv"))
            {
                File.Create("DataFolder/UserDetails.csv").Close();
            }
            if(!File.Exists("DataFolder/MedicineDetails.csv"))
            {
                File.Create("DataFolder/MedicineDetails.csv").Close();
            }
            if(!File.Exists("DataFolder/OrderDetails.csv"))
            {
                File.Create("DataFolder/OrderDetails.csv").Close();
            }
        }
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
                users[i] = Operations.userList[i].UserID+","+Operations.userList[i].Name+","+Operations.userList[i].Age+","+Operations.userList[i].City+","+Operations.userList[i].PhoneNumber+","+Operations.userList[i].WalletBalance;
            }
            File.WriteAllLines("DataFolder/UserDetails.csv",users);

            string [] orders = new string[Operations.orderList.Count];
            for(int i =0; i<Operations.orderList.Count; i++)
            {
                orders[i] = Operations.orderList[i].OrderID+","+Operations.orderList[i].UserID+","+Operations.orderList[i].MedicineID+","+Operations.orderList[i].MedicineCount+","+Operations.orderList[i].TotalPrice+","+Operations.orderList[i].OrderDate.ToString("dd/MM/yyyy")+","+Operations.orderList[i].OrderStatus;
            }
            File.WriteAllLines("DataFolder/OrderDetails.csv",orders);


            string [] medinices = new string[Operations.medicineList.Count];
            for(int i =0; i<Operations.medicineList.Count; i++)
            {
                medinices[i] = Operations.medicineList[i].MedicineID+","+Operations.medicineList[i].MedicineName+","+Operations.medicineList[i].AvailableCount+","+Operations.medicineList[i].Price+","+Operations.medicineList[i].DateOfExpiry.ToString("dd/MM/yyyy");
            }
            File.WriteAllLines("DataFolder/MedicineDetails.csv",medinices);
        }
        /// <summary>
        /// ReadFromCSV method is used to get data from the csv file and store it in its respective lists.
        /// </summary> <summary>
        /// 
        /// </summary>
        public static void ReadFromCSV()
        {
            string [] users = File.ReadAllLines("DataFolder/UserDetails.csv");
            {
                foreach(string user in users)
                {
                    UserDetails user1 = new UserDetails(user);
                    Operations.userList.Add(user1);
                }
            }
            string [] orders = File.ReadAllLines("DataFolder/OrderDetails.csv");
            {
                foreach(String order in orders)
                {
                    OrderDetails order1 = new OrderDetails(order);
                    Operations.orderList.Add(order1);
                }
            }
            string [] medicines = File.ReadAllLines("DataFolder/MedicineDetails.csv");
            {
                foreach(string medicine in medicines)
                {
                    MedicineDetails medicine1 = new MedicineDetails(medicine);
                    Operations.medicineList.Add(medicine1);
                }
            }
        }
    }
}