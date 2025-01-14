using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.DisplayInfo();

            Console.WriteLine();
            
            Shop shop1 = new Shop("Shop1", "Address1", "Description1", "111-111-1111", "...");
            shop1.DisplayInfo();

            Console.WriteLine();

            shop.ChangeParametres();
            Console.WriteLine();
            shop.DisplayInfo();
        }
    }
}