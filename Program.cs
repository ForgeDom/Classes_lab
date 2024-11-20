using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check if it's a palindrome:");
            int number = Convert.ToInt32(Console.ReadLine());

            bool result = PalindromeChecker.IsPalindrome(number);

            if (result)
            {
                Console.WriteLine($"{number} is a palindrome.");
            }
            else
            {
                Console.WriteLine($"{number} is not a palindrome.");
            }
        }   
    }
}