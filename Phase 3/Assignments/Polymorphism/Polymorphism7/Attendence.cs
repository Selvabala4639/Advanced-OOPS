using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism7
{
    public class Attendence
    {
        public int TotalWorkingDays { get; set; }
        public int Leavetaken { get; set; }
        public int PermissionsTaken { get; set; }

        public Attendence(int workingDays, int leaveTaken, int permissionTaken )
        {
            TotalWorkingDays = workingDays;
            Leavetaken = leaveTaken;;
            PermissionsTaken = permissionTaken;
        }
        public double TotalSalary()
        {
            return (TotalWorkingDays - PermissionsTaken - Leavetaken)*500;
        }
        public static Attendence Add(Attendence month1,Attendence month2,Attendence month3)
        {
            Attendence attendence = new Attendence(0,0,0);
            attendence.TotalWorkingDays = month1.TotalWorkingDays+month2.TotalWorkingDays+month3.TotalWorkingDays;
            attendence.Leavetaken = month1.Leavetaken+month2.Leavetaken+month3.Leavetaken;
            attendence.PermissionsTaken = month1.PermissionsTaken+month2.PermissionsTaken+month3.PermissionsTaken;
            return attendence;
        }
    }
}