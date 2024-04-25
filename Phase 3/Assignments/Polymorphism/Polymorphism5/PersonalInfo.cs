using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism5
{
    public abstract class PersonalInfo
    {
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string FatherName { get; set; }
        public string Gender { get; set; }

        public abstract void Display();
    }
}