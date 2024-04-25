using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed3
{
    public class PersonalInfo
    {
        public string  Name { get; set; }
        public string  FatherName { get; set; }

        public PersonalInfo()
        {
            
        }

        public virtual void Update(string name, string fathername)
        {
            Name = name;
            FatherName = fathername;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"FatherName : {FatherName}");
        }
    }
}