using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes_lab.Classes
{
    internal class Matrix
    {
        private int[,] _matrix;
        private int _rows;
        private int _columns;

        public Matrix()
        {
            _rows = 0;
            _columns = 0;
            _matrix = new int[0, 0];
        }
        public Matrix(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            _matrix = new int[rows, columns];
        }
        public void Input()
        {
            Console.WriteLine("Enter the number of rows:");
            _rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number of columns:");
            _columns = Convert.ToInt32(Console.ReadLine());

            _matrix = new int[_rows, _columns];

            Console.WriteLine("Enter the elements of the matrix:");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write($"Element [{i},{j}]: ");
                    _matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Input(int rows, int columns, int minValue, int maxValue)
        {
            _rows = rows;
            _columns = columns;
            _matrix = new int[rows, columns];
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    _matrix[i, j] = random.Next(minValue, maxValue + 1);
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write($"{_matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }
        public int GetMaximum()
        {
            int max = _matrix[0, 0];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (_matrix[i, j] > max)
                        max = _matrix[i, j];
                }
            }
            return max;
        }
        public int GetMinimum()
        {
            int min = _matrix[0, 0];
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    if (_matrix[i, j] < min)
                        min = _matrix[i, j];
                }
            }
            return min;
        }
    }
}