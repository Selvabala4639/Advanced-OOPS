using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClassesAndMethods
{
    //Property
    public partial class PersonalDetails
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public string Gender { get; set; }
        public DateTime DOB { get; set; }
    }
}