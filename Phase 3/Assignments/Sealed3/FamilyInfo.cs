using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sealed3
{
    public class FamilyInfo : PersonalInfo
    {
        public string MotherName { get; set; }
        public int NoOfSiblings { get; set; }
        public string Native { get; set; }

        public sealed override void Update(string name, string fathername)
        {
            base.Update(name, fathername);
            Name = name;
            FatherName = fathername;
            MotherName = MotherName;
        }
        public sealed override void DisplayInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"FatherName : {FatherName}");
        }
    }
}