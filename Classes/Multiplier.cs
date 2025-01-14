using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes_lab.Classes
{
    internal class Website
    {
        private string _name;
        private string _url;
        private string _description;
        private string _ipAddress;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Url
        {
            get { return _url; }
            set { _url = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string IpAddress
        {
            get { return _ipAddress; }
            set { _ipAddress = value; }
        }
        public void DisplayData()
        {
            Console.WriteLine("\nІнформація про сайт:");
            Console.WriteLine($"Назва: {_name}");
            Console.WriteLine($"URL: {_url}");
            Console.WriteLine($"Опис: {_description}");
            Console.WriteLine($"IP-адреса: {_ipAddress}");
        }
    }
}