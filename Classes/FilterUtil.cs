using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes_lab.Classes
{
    internal class FilterUtil
    {
        public static int[] FilterArray(int[] originalArray, int[] filterArray)
        {
            // Масив для зберігання результату
            int[] tempArray = new int[originalArray.Length];
            int index = 0;

            // Перебір елементів оригінального масиву
            for (int i = 0; i < originalArray.Length; i++)
            {
                bool toFilter = false;

                // Перевірка, чи є елемент у масиві для фільтрації
                for (int j = 0; j < filterArray.Length; j++)
                {
                    if (originalArray[i] == filterArray[j])
                    {
                        toFilter = true;
                        break;
                    }
                }

                // Якщо елемент не знайдено в масиві для фільтрації, додаємо його до результату
                if (!toFilter)
                {
                    tempArray[index++] = originalArray[i];
                }
            }

            // Створюємо масив потрібного розміру
            int[] resultArray = new int[index];
            Array.Copy(tempArray, resultArray, index);

            return resultArray;
        }
    }
}
