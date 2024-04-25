using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Single_inheritence
{
    public class EmployeeDetail : StudentDetail
    {
        private static int s_employeeID= 3000;
        public string EmployeeID { get; }
        public string Designation { get; set; }

        public EmployeeDetail(string studentID,string userID, string userName,string fatherName,Gender gender,string phoneNumber, int standard, int joiningYear, string designation) : base( studentID, userID,  userName, fatherName, gender, phoneNumber,  standard,  joiningYear)
        {
            EmployeeID= "EID"+(++s_employeeID);
            Designation = designation;
        }

    }
}