using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Single_inheritence
{
    public class StudentDetail : PersonalDetail
    {
        // studentid
        //std
        //doj
        private static int s_studentID = 2000;
        public string StudentID { get;  }
        public int Standard { get; set; }
        public int JoiningYear { get; set; }

        public StudentDetail(string userID, string userName,string fatherName,Gender gender,string phoneNumber, int standard, int joiningYear): base( userID, userName,  fatherName,  gender,  phoneNumber)
        {
            StudentID = "SID" + (++s_studentID);
            Standard = standard;
            JoiningYear = joiningYear;
        }
        public StudentDetail(string studentID,string userID, string userName,string fatherName,Gender gender,string phoneNumber, int standard, int joiningYear): base( userID, userName,  fatherName,  gender,  phoneNumber)
        {
            StudentID = studentID;
            Standard = standard;
            JoiningYear = joiningYear;
        }
        
    }
}