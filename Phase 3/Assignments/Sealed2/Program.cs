using System;
namespace Sealed2;
class Program
{
    public static void Main(string[] args)
    {
        PatientInfo patient = new PatientInfo("PID101","Selva","Vel",22,"Theni","Fever");
        patient.Display();
        DoctorInfo doctor = new DoctorInfo("DID202","Bala","kannan");
        doctor.Display();
    }
}