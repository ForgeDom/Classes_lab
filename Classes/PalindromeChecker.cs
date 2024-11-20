using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes_lab.Classes
{
    internal class PalindromeChecker
    {
        public static bool IsPalindrome(int number)
        {
            string numberStr = number.ToString();             
            string reversedStr = new string(numberStr.Reverse().ToArray()); 
            return numberStr == reversedStr;                   
        }
    }
}
