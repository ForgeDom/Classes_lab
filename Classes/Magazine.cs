using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes_lab.Classes
{
    internal class Magazine
    {
        private string _name;
        private string _date;
        private string _description;
        private string _contactnumber;
        private string _email;

        public Magazine(string name, string date, string description, string contactnumber, string email)
        {
            _name = name;
            _date = date;
            _description = description;
            _contactnumber = contactnumber;
            _email = email;
        }
        public string Name { get { return _name; } }
        public string Date { get { return _date; } }
        public string Description { get { return _description; } }
        public string ContactNumber { get { return _contactnumber; } }
        public string Email { get { return _email; } }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Description: {_description}");
            Console.WriteLine($"Contact Number: {_contactnumber}");
            Console.WriteLine($"Email: {_email}");
        }

        public static Magazine CreateNew()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Date: ");
            string date = Console.ReadLine();

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Contact Number: ");
            string contactNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            return new Magazine(name, date, description, contactNumber, email);
        }
    }
}
