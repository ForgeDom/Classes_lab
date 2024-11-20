using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            City city = new City();
            city.Input();
            Console.WriteLine("\nCity informatio:");
            city.DisplayData();
        }
    }
}