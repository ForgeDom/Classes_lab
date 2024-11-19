using Classes_lab.Classes;

namespace Classes_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter the range for random numbers:");
            Console.Write("Lower bound: ");
            int lowerBound = Convert.ToInt32(Console.ReadLine());
            Console.Write("Upper bound: ");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(lowerBound, upperBound + 1); 
            }

            Console.WriteLine("Generated array:");
            Console.WriteLine(string.Join(" ", arr));

            Console.WriteLine("Choose sorting order: 1 for Ascending, 2 for Descending:");
            int choice = Convert.ToInt32(Console.ReadLine());
            bool ascending = choice == 1;

            Sort sorter = new Sort(arr);

            Console.WriteLine("Array before sorting:");
            sorter.PrintArray();

            sorter.SortArray(ascending);

            Console.WriteLine("Array after sorting:");
            sorter.PrintArray();
        }
    }
}