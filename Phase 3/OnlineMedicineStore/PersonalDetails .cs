using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMedicineStore
{
    public class PersonalDetails 
    {
        /// <summary>
        /// Used to store Name data.
        /// </summary>
        /// <value></value>
        public string Name { get; set; }
        /// <summary>
        /// Used to store age.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public int Age { get; set; }
        /// <summary>
        ///  Used to store city.
        /// </summary>
        /// <value></value>
        public string City { get; set; }
        /// <summary>
        ///  Used to store Phonr Number.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string PhoneNumber { get; set; }
        /// <summary>
        ///  This constructor is used to create object for user details.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="city"></param>
        /// <param name="phone"></param> <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="city"></param>
        /// <param name="phone"></param>
        public PersonalDetails(string name, int age, string city, string phone)
        {
            Name= name;
            Age = age;
            City  = city;
            PhoneNumber = phone;
        }
        public PersonalDetails()
        {
        }
    }
}