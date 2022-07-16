using Calculator;
int choice;
do
{
    Console.WriteLine("What type of operation you want to perform ?");
    Console.WriteLine("1. Calculator");
    Console.WriteLine("2. String Manipulation");
    Console.WriteLine("0. EXIT");
    choice = Convert.ToInt32(Console.ReadLine());
    
    switch (choice)
    {
        case 1:
            Console.Clear();
            CalculatorManager.DisplayMenuForCalculator();
            break;
        case 2:
            Console.Clear();
            Console.WriteLine("String Manipulation is selected");
            break;
        case 0:
            Console.Clear();
            Console.WriteLine("Thank you for using this application");
            break;
        default:
            Console.Clear();
            Console.WriteLine("Wrong choice selected");
            break;
    }
} while (choice != 0);