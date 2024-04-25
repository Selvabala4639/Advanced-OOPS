using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial1
{
    public partial class EmployeeInfo
    {
        //EmployeeID,Name,Gender,DOB, Mobile
        private static int s_employeeID = 1000;
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string  Gender { get; set; }
        public DateTime  DOB { get; set; }
        public string  Mobile { get; set; }
    }
}