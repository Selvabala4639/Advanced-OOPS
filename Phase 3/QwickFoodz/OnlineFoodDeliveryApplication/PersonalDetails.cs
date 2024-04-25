using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineFoodDeliveryApplication
{
    public enum Gender{Select, Male, Female, Transgender}
    public class PersonalDetails
    {
        //Properties: Name, FatherName, Gender- {Select, Male, Female, Transgender}, Mobile, DOB, MailID, Location
        /// <summary>
        /// Name property is used to store name of the user.
        /// </summary>
       
        public string Name  { get; set; }
        /// <summary>
        /// This property is used to store father name of the customer.
        /// </summary> 
        public string FatherName  { get; set; }
        /// <summary>
        /// This property is used to store gender of the customer.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public Gender Gender  { get; set;}
        /// <summary>
        /// This property is used to store Mobile number of the customer.
        /// </summary> <summary>
        /// 
        /// </summary>
        /// <value></value>
        public string Mobile  { get; set; }
        /// <summary>
        /// This property is used to store DOB of the customer.
        /// </summary>
        /// <value></value>
        public DateTime DOB  { get; set; }
        /// <summary>
        /// This property is used to store Mail ID of the customer.
        /// </summary>
        /// <value></value>
        public string MailID  { get; set; }
        /// <summary>
        /// This property is used to store Location of the customer.
        /// </summary>
        /// <value></value>
        public string Location  { get; set; }

    }
}