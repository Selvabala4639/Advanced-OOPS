using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial1
{
    public partial class EmployeeInfo
    {
        //EmployeeID,Name,Gender,DOB, Mobile
        public EmployeeInfo( )
        {
            EmployeeID= "EID" +(++s_employeeID);
            // EmployeeName = employeeName;
            // Gender = gender;
            // DOB  = dob;
            // Mobile = mobile;
        }
    }
}