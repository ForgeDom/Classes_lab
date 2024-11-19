using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Multiplier multiplier = new Multiplier(lowerBound: 1, upperBound: 6);
            Console.WriteLine(multiplier.ToString());
        }
    }
}