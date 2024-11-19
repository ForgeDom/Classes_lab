using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes_lab.Classes
{
    internal class Sort
    {
        private int[] arr;
        
        public Sort(int[] inputArr)
        {
            arr = inputArr;
        }

        public void SortArray(bool ascending)
        {
            Array.Sort(arr);
            if (!ascending)
            {
                Array.Reverse(arr);
            }
        }

        // Метод для виведення масиву
        public void PrintArray()
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
