using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClassesAndMethods
{
    public abstract class Employee //abstract class
    {
        //Abstract class - partial abstraction.
        //It has fields, property,  method, constructor, destructor, indexers, events
        //can have both abstract declaration and normal definitions
        //can only used with an inherited class
        //Not support multiple inheritance.
        //It cannot be static class
        
        protected string _name; //Normal field
        public abstract string Name { get; set; }//Abstract property

        public double Amount { get; set; } //Normal Property

        public string Display()  //Normal Method
        {
            return _name;
        }
        public abstract double Salary(int dates);  //Abstract method - Only Declaration
        
    }
}