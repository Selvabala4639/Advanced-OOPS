using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicineStore
{
    public class MedicineDetails
    {
        /// <summary>
        /// this private field autoincrement the medcine id.
        /// </summary> <summary>
        /// 
        /// </summary>
        private static int s_medicineID = 100;
        /// <summary>
        /// Used to store medicineID data.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string MedicineID { get; }
        /// <summary>
        ///  Used to store medicine name data.
        /// </summary>
        /// <value></value>
        public string MedicineName { get; set; }
        /// <summary>
        ///  Used to store available count of medicine.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int AvailableCount { get;  set; }

        /// <summary>
        ///  Used to store price data.
        /// </summary>
        /// <value></value>
        public double Price { get; set; }
        /// <summary>
        ///  Used to store date of expiry data.
        /// </summary>
        /// <value></value>
        public DateTime DateOfExpiry { get; set; }
        /// <summary>
        /// This constructor is used to create object for medicine details.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="count"></param>
        /// <param name="price"></param>
        /// <param name="doe"></param>
        public MedicineDetails(string name, int count, double price, DateTime doe)
        {
            MedicineID = "MD"+(++s_medicineID);
            MedicineName =name;
            AvailableCount = count;
            Price = price;
            DateOfExpiry = doe;
        }
        /// <summary>
        /// Gets the data as string and split those strings and store it in respective properties.
        /// </summary>
        /// <param name="medicine"></param> <summary>
        /// 
        /// </summary>
        /// <param name="medicine"></param>
        public MedicineDetails(string medicine)
        {
            string[] values = medicine.Split(",");
            s_medicineID = int.Parse(values[0].Remove(0,2));
            MedicineID = values[0];
            MedicineName =values[1];
            AvailableCount = int.Parse(values[2]);
            Price = double.Parse(values[3]);
            DateOfExpiry = DateTime.ParseExact(values[4],"dd/MM/yyyy",null);
        }
        
    }
}