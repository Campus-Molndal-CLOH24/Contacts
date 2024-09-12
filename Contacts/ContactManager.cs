using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class ContactManager
    {
        List<Contact> contacts;
        public ContactManager()
        {
            contacts = new List<Contact>();
            contacts.Add(new Contact("Ali Ahmadi", 2222222, 25));
            contacts.Add(new Contact("Amin Jafari", 35353535, 22));
            contacts.Add(new Contact("Maryam Amini", 888888, 24));
            contacts.Add(new Contact("Maria Olofsson", 44444444, 21));
            contacts.Add(new Contact("Anna Lindberg", 555555555, 24));
        }

        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine("Kontakt har lagts till:\n" + contact.PrintInfo());

        }
        public void RemoveContact(Contact contact)
        {
            if (contacts.Contains(contact))
            {
                contacts.Remove(contact);
                Console.WriteLine($"Kontakt {contact.Name} har tagits bort.");
            }
            else
            {
                Console.WriteLine("Kontakten kunde inte hittas och tas bort.");
            }
        }

        public void ListContacts()
        {
            Console.WriteLine("Kontakter i kontatktlistan: ");
            foreach (Contact contact in contacts)
            {
                Console.WriteLine(contact.PrintInfo());
            }
        }
        public Contact SearchContact(string name)
        {
            foreach (Contact contact in contacts)
            {
                if (contact.GetName() == name)
                {
                    Console.WriteLine("Kontakt hittad \n" + contact.PrintInfo());
                    return contact;
                }
            

            }
            Console.WriteLine("Kontakt hittades inte.");
            return null;
        }
        public void UpdateContact(Contact oldContact, Contact newContact)
        {
            int index = contacts.IndexOf(oldContact);
            if (index >= 0)
            {
                contacts[index] = newContact;
                Console.WriteLine("Kontakten har uppdaterats " + newContact.PrintInfo());
            }
            else
            {
                Console.WriteLine("Kontakten hittades inte för uppdatering");
            }
        }
        public void ClearContact()
        {
            contacts.Clear();
            Console.WriteLine("Alla kontakter har tagits bort");
        }
        public int GetContactCount()
        {
            return contacts.Count;
        }
        public void SortContactsByName()
        {
            contacts = contacts.OrderBy(c => c.GetName()).ToList();
            
        }
    }
}
