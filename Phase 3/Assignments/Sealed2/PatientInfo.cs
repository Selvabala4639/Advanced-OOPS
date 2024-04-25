using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed2
{
    public sealed class PatientInfo
    {
        // /PatientID, Name, FatherName, BedNo, NativePlace, AdmittedFor

        public string PatientID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public int BedNo { get; set; }
        public string NativePlace { get; set; }
        public string AdmittedFor { get; set; }

        public PatientInfo(string patientID, string name, string fatherName, int bedNo, string nativePlace,string admittedfor)
        {
            PatientID = patientID;
            Name = name;
            FatherName = fatherName;
            BedNo= bedNo;
            NativePlace =nativePlace;
            AdmittedFor = admittedfor;
        }
        public void Display()
        {
            Console.WriteLine($"PatientId: {PatientID}\nName: {Name}\nFather name: {FatherName}\nBedNo :{BedNo}\nNative place: {NativePlace}\nAdmittedFor: {AdmittedFor}");

        }
    }
}