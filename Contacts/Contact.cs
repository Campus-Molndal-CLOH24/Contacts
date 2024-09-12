using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Contacts
{
    internal class Contact
    {
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }

        public Contact(string name, int phonenumber, int age)
        {
            Name = name;
            PhoneNumber = phonenumber;
            Age = age;
        }
        public string PrintInfo()
        {
            return $"Namn:{Name}\nTelefonnummer: {PhoneNumber}\nAge: {Age}\n";
        }
        public string GetName()
        {
            return Name ;
        }

    }
}
