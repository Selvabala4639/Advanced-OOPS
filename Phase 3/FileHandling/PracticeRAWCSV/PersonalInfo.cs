using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeRAW
{
    public class PersonalInfo
    {
        public string Name { get; set; }
        public string FatherName { get; set; }
        public PersonalInfo(string name, string fatherName)
        {
            Name = name;
            FatherName = fatherName;
        }
    }
}