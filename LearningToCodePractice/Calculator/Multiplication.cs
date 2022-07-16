using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Multiplication
    {
        public static void Multiply()
        {
            int num1, num2, result;
            Console.WriteLine("Enter first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 * num2;
            Console.WriteLine($"Multiplication of {num1} and {num2} is : {result}");
        }
    }
}
