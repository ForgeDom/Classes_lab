using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes_lab.Classes
{
    internal class Multiplier
    {
        private int _lowerBound { get; set; }
        private int _upperBound { get; set; }

        public Multiplier()
        {
            _lowerBound = 0;
            _upperBound = 0;
        }
        public Multiplier(int lowerBound, int upperBound)
        {
            _lowerBound = lowerBound;
            _upperBound = upperBound;
        }

        public int Operation(int lowerBound, int upperBound)
        {
            int result = 1;
            if (lowerBound > upperBound)
            {
                throw new Exception("Lower bound must be less than upper!");
            }
            for (int i = lowerBound; i <= upperBound; i++)
            {
                result *= i;
            }
            return result;
        }

        public override string ToString()
        {
            return $"The result between numbers {_lowerBound} and {_upperBound} is {Operation(_lowerBound, _upperBound)}";
        }
    }
}
