using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane1 = new Airplane();
            Console.WriteLine("Enter details for airplane1:");
            airplane1.Input();
            Console.WriteLine("\nDetails of airplane1:");
            airplane1.Display();

            Airplane airplane2 = new Airplane("Boeing 737", "Boeing", 1997, "Passenger");
            Console.WriteLine("\nDetails of airplane2 (single-line display):");
            airplane2.Display(singleLine: true);

            airplane2.Input("Airbus A320", "Airbus", 2015, "Passenger");
            Console.WriteLine("\nUpdated details of airplane2:");
            airplane2.Display();
        }
    }
}