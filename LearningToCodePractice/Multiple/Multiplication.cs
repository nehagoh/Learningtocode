namespace Multiple
{
    public class Multiplication
    {
        int num1, num2;
        public void multiply()
        {
            int product;
            Console.WriteLine("Enter first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = Convert.ToInt32(Console.ReadLine());
            product = (num1 * num2);
            Console.WriteLine("Product is:{0}",product);
        }
    }
}