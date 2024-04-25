using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Polymorphism8
{
    public class Calculator
    {
        public double Subject1 { get; set; }
        public double Subject2 { get; set; }
        public double Subject3 { get; set; }
        public double Subject4 { get; set; }
        public double Subject5 { get; set; }
        public double Subject6 { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }

        public Calculator(double subject1, double subject2,double subject3,double subject4,double subject5,double subject6 )
        {
            Subject1 = subject1;
            Subject2 = subject2;
            Subject3 = subject3;
            Subject4 = subject4;
            Subject5 = subject5;
            Subject6 = subject6;
        }
        public double TotalMark()
        {
            Total=  Subject1+Subject2+Subject3+Subject4+Subject5+Subject6;
            return Total;
        }
        public double CalculatePercentage()
        {
            Percentage =  Total*100/2400;
            return Percentage;
        }
        public static Calculator Add(Calculator sem1, Calculator sem2, Calculator sem3,Calculator sem4)
        {
            Calculator calculator = new Calculator(0,0,0,0,0,0);
            calculator.Subject1 = sem1.Subject1+sem2.Subject1+sem3.Subject1+sem4.Subject1;
            calculator.Subject2 = sem1.Subject2+sem2.Subject2+sem3.Subject2+sem4.Subject2;

            calculator.Subject3 = sem1.Subject3+sem2.Subject3+sem3.Subject3+sem4.Subject3;

            calculator.Subject4 = sem1.Subject4+sem2.Subject4+sem3.Subject4+sem4.Subject4;
            calculator.Subject5 = sem1.Subject5+sem2.Subject5+sem3.Subject5+sem4.Subject5;
            calculator.Subject6 = sem1.Subject6+sem2.Subject6+sem3.Subject6+sem4.Subject6;

            return calculator;
        }
    }
}