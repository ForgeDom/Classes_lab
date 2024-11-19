using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes_lab.Classes
{
    internal class NumberChecker
    {
        public static bool IsFibonacci(int number)
        {
            if (number < 0)
            {
                return false;
            }

            int a = 0;
            int b = 1;

            if (number == a || number == b)
                return true;

            int nextFib = a + b;

            while (nextFib <= number)
            {
                if (nextFib == number)
                    return true;

                a = b;
                b = nextFib;
                nextFib = a + b;
            }

            return false;
        }
    }
}