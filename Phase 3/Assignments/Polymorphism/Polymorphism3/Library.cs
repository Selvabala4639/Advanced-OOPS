using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism3
{
    public abstract class Library
    {
        private static int s_serialNumber = 1000;
        public string SerialNumber { get; set; }
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract int Year { get; set; }

        public  abstract void SetBookInfo(string authorName, string bookName, string publisher, int year);
        public  abstract void DisplayInfo();
    }
}