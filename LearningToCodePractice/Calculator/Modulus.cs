using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal static class Modulus
    {
        public static void mod()
        {
            int num1, num2, result;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 % num2;
            Console.WriteLine($"Modulus of {num1} and {num2} is : {result}");
        }
    }
}
