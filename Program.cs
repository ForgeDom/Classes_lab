using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the original array elements separated by space:");
            string[] originalInput = Console.ReadLine().Split(' ');
            int[] originalArray = Array.ConvertAll(originalInput, int.Parse);

            // Введення масиву для фільтрації
            Console.WriteLine("Enter the filter array elements separated by space:");
            string[] filterInput = Console.ReadLine().Split(' ');
            int[] filterArray = Array.ConvertAll(filterInput, int.Parse);

            // Виклик методу
            int[] filteredArray = FilterUtil.FilterArray(originalArray, filterArray);

            // Виведення результату
            Console.WriteLine("Filtered array:");
            foreach (int item in filteredArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}