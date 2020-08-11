using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    
    public class CalcClass
    {
        public double num1 { get; set; }
        public double num2 { get; set; }


        public double Add()
        {
            return num1 + num2;
        }
        public double Sub()
        {
            return num1 - num2;
        }
        public double Mul()
        {
            return num1 * num2;
        }
        public double Div()
        {
            return num1 / num2;
        }
    }
}
