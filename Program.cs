using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subhelper employee = new Subhelper();

            Console.WriteLine("Please enter employee details:");
            employee.Input();

            Console.WriteLine("\nEmployee details:");
            employee.Display();
        }
    }
}