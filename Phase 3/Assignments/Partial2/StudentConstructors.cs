using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial2
{
    public partial class StudentInfo
    {
        public StudentInfo(string name, string gender, DateTime dob, string mobile, int phy, int chem, int mat)
        {
            StudentID = "SID"+(++s_studentID);
            Name = name;
            Gender = gender;
            DOB =dob;
            Mobile =mobile;
            Physics= phy;
            Chemistry = chem;
            Maths = mat;
        }
    }
}