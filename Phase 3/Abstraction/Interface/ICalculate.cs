using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface
{
    public interface ICalculate
    {
        //No fields and constructor
        //Property
         int Number { get; set; } //declaration
         int Calculate(); // Method - declaration

         //Fully abstraction - no definition
    }
}