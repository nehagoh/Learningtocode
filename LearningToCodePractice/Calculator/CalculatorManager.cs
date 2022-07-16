namespace Calculator
{
    public class CalculatorManager
    {
        public static void DisplayMenuForCalculator()
        {
            int ch;
            do
            {
                Console.WriteLine("Enter the operation you want to perform");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtraction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Modulus");
                Console.WriteLine("0.EXIT");
                ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Addition is selected!");
                        Addition.Sum();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Subtraction is selected!");
                        Subtraction.Difference();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Multiplication is selected!");
                        Multiplication.Multiply();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Division is selected!");
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Modulus is selected");
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Thank you for using calculator!");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong option selected");
                        break;
                }
            } while (ch != 0);
        }
    }
}