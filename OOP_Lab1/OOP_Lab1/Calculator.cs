using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1
{
    public class Calculator
    {
        public static double Plus(string a, string b)
        {
            return (Convert.ToDouble(a) + Convert.ToDouble(b));
        }
        public static double Minus(string a, string b)
        {
            return (Convert.ToDouble(a) - Convert.ToDouble(b));
        }
        public static double Mult(string a, string b)
        {
            return (Convert.ToDouble(a) * Convert.ToDouble(b));
        }
        public static double Div(string a, string b)
        {
            return (Convert.ToDouble(a) / Convert.ToDouble(b));
        }
        public static double Sin(string a)
        {
            return Math.Sin(Convert.ToDouble(a));
        }
        public static double Cos(string a)
        {
            return Math.Cos(Convert.ToDouble(a));
        }
        public static double Sqrt(string a)
        {
            return Math.Sqrt(Convert.ToDouble(a));
        }
    }
}
