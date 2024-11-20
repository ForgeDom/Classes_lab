using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes_lab.Classes
{
    internal class Airplane
    {
        private string _name;
        private string _manufacturer;
        private int _year;
        private string _type;

        public Airplane()
        {
            _name = "None";
            _manufacturer = "None";
            _year = 0;
            _type = "None";
        }

        public Airplane(string name, string manufacturer, int year, string type)
        {
            _name = name;
            _manufacturer = manufacturer;
            _year = year;
            _type = type;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public void Input()
        {
            Console.WriteLine("Enter the airplane name:");
            _name = Console.ReadLine();

            Console.WriteLine("Enter the manufacturer name:");
            _manufacturer = Console.ReadLine();

            Console.WriteLine("Enter the year of manufacture:");
            _year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the type of airplane:");
            _type = Console.ReadLine();
        }

        public void Input(string name, string manufacturer, int year, string type)
        {
            _name = name;
            _manufacturer = manufacturer;
            _year = year;
            _type = type;
        }

        public void Display()
        {
            Console.WriteLine("Airplane Details:");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Manufacturer: {_manufacturer}");
            Console.WriteLine($"Year of Manufacture: {_year}");
            Console.WriteLine($"Type: {_type}");
        }

        public void Display(bool singleLine)
        {
            if (singleLine)
            {
                Console.WriteLine($"Name: {_name}, Manufacturer: {_manufacturer}, Year: {_year}, Type: {_type}");
            }
            else
            {
                Display();
            }
        }
    }
}

