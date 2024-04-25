using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed2
{
    public class DoctorInfo : PatientInfo
    {
        //DoctorID, Name, FatherName
        public string DoctorID { get; set; }
        public string Name { get; set; }
        public string Father { get; set; }
        public DoctorInfo(string doctorID, string name, string father)
        {
            DoctorID = doctorID;
            Name = name;
            Father=father;
        }
        public void Display()
        {
            Console.WriteLine($"Doctor ID: {DoctorID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Father: {Father}");
        }
    }
}