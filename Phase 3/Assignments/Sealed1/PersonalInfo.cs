using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed1
{
    public class PersonalInfo
    {
         public string  Name { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        
        public void UpdateInfo()
        {
            Console.Write($"Enter name: ");
            Name = Console.ReadLine();
            Console.Write($"Enter phone: ");
            Phone = Console.ReadLine();
            Console.Write($"Enter mail: ");
            Mail = Console.ReadLine();
            Console.Write($"Enter dob: ");
            DOB = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            Console.Write($"Enter gender: ");
            Gender = Console.ReadLine();
            
        }
    }
}