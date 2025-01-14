using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Classes_lab.Classes
{
    internal class Shop
    {
        private string _name;
        private string _address;
        private string _accdescription;
        private string _phone;
        private string _email;

        public Shop()
        {
            _name = "Default Name";
            _address = "Default Address";
            _accdescription = "Default Description";
            _phone = "000-000-0000";
            _email = "default@email.com";
        }
        public Shop(string name, string address, string accdescription, string phone, string email)
        {
            _name = name;
            _address = address;
            _accdescription = accdescription;
            _phone = phone;
            _email = email;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        public string Accdescription
        {
            get { return _accdescription; }
            set { _accdescription = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public void ChangeParametres()
        {
            Console.Write("Renaming Shop - ");
            Console.WriteLine($"{ _name}");

            Console.WriteLine("Enter new name: ");
            _name = Console.ReadLine();
            Console.WriteLine("Enter new address: ");
            _address = Console.ReadLine();
            Console.WriteLine("Enter new description: ");
            _accdescription = Console.ReadLine();
            Console.WriteLine("Enter new phone: ");
            _phone = Console.ReadLine();
            Console.WriteLine("Enter new email: ");
            _email = Console.ReadLine();
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Shop name: {_name}");
            Console.WriteLine($"Shop address: {_address}");
            Console.WriteLine($"Shop description: {_accdescription}");
            Console.WriteLine($"Shop phone: {_phone}");
            Console.WriteLine($"Shop email: {_email}");
        }
        public override string ToString()
        {
            return $"Shop name: {_name}\nShop address: {_address}\nShop description: {_accdescription}\nShop phone: {_phone}\nShop email: {_email}";
        }
    }
}