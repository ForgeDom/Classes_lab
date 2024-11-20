using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes_lab.Classes
{
    internal class Subhelper
    {
        private string _fullName;
        private string _birthDate;
        private string _phoneNumber;
        private string _email;
        private string _position;
        private string _duty;
    
        public Subhelper()
        {
            _fullName = "None";
            _birthDate = "None";
            _phoneNumber = "None";
            _email = "None";
            _position = "None";
            _duty = "None";
        }

        public Subhelper(string fullName, string birthDate, string phoneNumber, string email, string position, string duty)
        {
            _fullName = fullName;
            _birthDate = birthDate;
            _phoneNumber = phoneNumber;
            _email = email;
            _position = position;
            _duty = duty;
        }

        public string FullName
        {
            get { return _fullName; }
            set { _fullName = value; }
        }
        public string BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public string Duty
        {
            get { return _duty; }
            set { _duty = value; }
        }

        public void Input()
        {
            Console.WriteLine("Enter Full Name:");
            FullName = Console.ReadLine();

            Console.WriteLine("Enter Birth Date (yyyy-mm-dd):");
            BirthDate = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email:");
            Email = Console.ReadLine();

            Console.WriteLine("Enter Position:");
            Position = Console.ReadLine();

            Console.WriteLine("Enter Duty Description:");
            Duty = Console.ReadLine();
        }
        public void Display()
        {
            Console.WriteLine("Employee Information:");
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Birth Date: {BirthDate}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Duty Description: {Duty}");
        }
    }
}
