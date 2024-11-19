using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (NumberChecker.IsFibonacci(number))
            {
                Console.WriteLine($"{number} is a Fibonacci number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a Fibonacci number.");
            }
        }
    }
}