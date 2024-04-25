using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed3
{
    public class EmployeeInfo : FamilyInfo
    {
        public string EmployeeID { get; set; }
        public int DateOfJoining { get; set; }
        public EmployeeInfo()
        {

        }

        public override void Update()  //Sealed method can't be overridden
        {

        }
        public override void DisplayInfo()   //Sealed method can't be overridden
        {
            base.DisplayInfo();
        }
    }
}