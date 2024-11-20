using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix();
            Console.WriteLine("Manual Input:");
            matrix1.Input();
            matrix1.Display();
            Console.WriteLine($"Maximum: {matrix1.GetMaximum()}, Minimum: {matrix1.GetMinimum()}");

            Matrix matrix2 = new Matrix();
            matrix2.Input(3, 4, 0, 100); 
            Console.WriteLine("\nGenerated Matrix:");
            matrix2.Display();
            Console.WriteLine($"Maximum: {matrix2.GetMaximum()}, Minimum: {matrix2.GetMinimum()}");
        }
    }
}