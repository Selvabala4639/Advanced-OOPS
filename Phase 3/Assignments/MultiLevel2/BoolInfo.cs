using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiLevel2
{
    public class BookInfo: RackInfo
    {
        // BookID, BookName, AuthorName, Price

        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }

        public BookInfo(string departmentName, string degree, int rackNumber, int columnNumber, string bookID, string bookName, string authorName, int price): base( departmentName,  degree,  rackNumber,  columnNumber)
        {
            BookID = bookID;
            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Department Name: {DepartmentName}\nDegree: {Degree}");
            Console.WriteLine($"Rack Number: {RackNumber}\nCoulumn Number: {ColumnNumber}");
            Console.WriteLine($"Book ID: {BookID}\nBook Name: {BookName}");
            Console.WriteLine($"Author Name: {AuthorName}\nPrice: {Price}");
        }
    }
}