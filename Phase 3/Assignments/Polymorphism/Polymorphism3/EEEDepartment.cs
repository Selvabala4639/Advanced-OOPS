using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism3
{
    public class EEEDepartment:Library
    {
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override int Year { get; set; }

        public EEEDepartment()
        {
            
        }
        public override void SetBookInfo(string authorName, string bookName, string publisher, int year)
        {  
            AuthorName = authorName;
            BookName = bookName;
            PublisherName = publisher;
            Year = year;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"AuthorName: {AuthorName}");
             Console.WriteLine($"BookName: {BookName}");
              Console.WriteLine($"PublisherName: {PublisherName}");
               Console.WriteLine($"Year: {Year}");
            
        }
    }
}