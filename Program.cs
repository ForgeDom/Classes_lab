using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine("Magazine", "2020-01-01", "Description", "1234567890", "myemail@gmail.com");

            Console.WriteLine("Magazine 1 info:");
            magazine.DisplayInfo();

            Console.WriteLine("\nCreating new magazine:");
            Magazine newMagazine = Magazine.CreateNew();
            Console.WriteLine("\nNew magazine info:");
            newMagazine.DisplayInfo();
        }
    }
}