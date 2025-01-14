using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Website website = new Website();
            Console.WriteLine("Введіть назву сайту:");
            website.Name = Console.ReadLine();
            Console.WriteLine("Введіть URL сайту:");
            website.Url = Console.ReadLine();
            Console.WriteLine("Введіть опис сайту:");
            website.Description = Console.ReadLine();
            Console.WriteLine("Введіть IP-адресу сайту:");
            website.IpAddress = Console.ReadLine();
            website.DisplayData();

        }
    }
}