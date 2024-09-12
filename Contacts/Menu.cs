using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    internal class Menu
    {
        private ContactManager contactManager;

        public Menu()
        {
            contactManager = new ContactManager();
        }

        public void ShowMenu()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Lägg till kontakt");
                Console.WriteLine("2. Ta bort kontakt");
                Console.WriteLine("3. Lista kontakter");
                Console.WriteLine("4. Sortera kontakter");
                Console.WriteLine("5. Sök kontakt");
                Console.WriteLine("6. Uppdatera kontakt");
                Console.WriteLine("7. Rensa alla kontakter");
                Console.WriteLine("0. Avsluta");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        RemoveContact();
                        break;
                    case "3":
                        ListContacts();
                        break;
                    case "4":
                        SortContacts();
                        break;
                    case "5":
                        SearchContact();
                        break;
                    case "6":
                        UpdateContact();
                        break;
                    case "7":
                        ClearContacts();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltigt val, försök igen.");
                        break;
                }
            }
        }

        private void AddContact()
        {
            Console.WriteLine("Ange namn:");
            string name = Console.ReadLine();

            Console.WriteLine("Ange telefonnummer:");
            int phoneNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange ålder:");
            int age = int.Parse(Console.ReadLine());

            Contact contact = new Contact(name, phoneNumber, age);
            contactManager.AddContact(contact);
        }

        private void RemoveContact()
        {
            Console.WriteLine("Ange namn på kontakten du vill ta bort:");
            string name = Console.ReadLine();

            Contact contact = contactManager.SearchContact(name);
            if (contact != null)
            {
                contactManager.RemoveContact(contact);
            }
        }
        private void ListContacts()
        {
            contactManager.ListContacts();
        }

        private void SortContacts()
        {
            contactManager.SortContactsByName();
            Console.WriteLine("Kontakter sorterade.");
        }
        private void SearchContact()
        {
            Console.WriteLine("Ange namn på kontakten du vill söka:");
            string name = Console.ReadLine();
            contactManager.SearchContact(name);
        }
        private void UpdateContact()
        {
            Console.WriteLine("Ange namn på kontakten du vill uppdatera:");
            string oldName = Console.ReadLine();

            Contact oldContact = contactManager.SearchContact(oldName);
            if (oldContact != null)
            {
                Console.WriteLine("Ange nytt namn:");
                string newName = Console.ReadLine();

                Console.WriteLine("Ange nytt telefonnummer:");
                int newPhoneNumber = int.Parse(Console.ReadLine());

                Console.WriteLine("Ange ny ålder:");
                int newAge = int.Parse(Console.ReadLine());

                Contact newContact = new Contact(newName, newPhoneNumber, newAge);
                contactManager.UpdateContact(oldContact, newContact);
            }
        }
        private void ClearContacts()
        {
            contactManager.ClearContact();
            Console.WriteLine("Alla kontakter har rensats.");
        }
    }


}
