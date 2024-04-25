using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial2
{
    public partial class StudentInfo
    {
        //StudentID,Name,Gender,DOB, Mobile, Physics, Chemistry, Maths Marks
        private static int s_studentID=1000;
        public string StudentID { get; set; }
        public string  Name { get; set; }
        public string Mobile { get; set; }
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public int Total { get;set; }
         public int Percentage { get;set; }
        
        
    }
}