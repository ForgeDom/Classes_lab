using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side length of the square:");
            int sideLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the symbol to draw the square:");
            char symbol = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("\nSquare:");
            DrawSquare.Draw(sideLength, symbol);
        }
    }
}