using AddressBookSystemday9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemday9
{
    internal class AddressBook
    {
        List<Contact> data = new List<Contact>();
        public void CreateContact()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter Firstname");
            contact.Firstname = Console.ReadLine();

            Console.WriteLine("Enter Lastname");
            contact.Lastname = Console.ReadLine();

            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            contact.Zip = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Phonenumber");
            contact.PhoneNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();
            data.Add(contact);
        }
        public void DisplayContact()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********Contact********");
            Console.ResetColor();
            foreach (Contact records in data)
            {
                Console.WriteLine("Firstname - " + records.Firstname);
                Console.WriteLine("Lastname - " + records.Lastname);
                Console.WriteLine("Address - " + records.Address);
                Console.WriteLine("City - " + records.City);
                Console.WriteLine("State - " + records.State);
                Console.WriteLine("Zip - " + records.Zip);

                Console.WriteLine("Phonenumber - " + records.PhoneNumber);
                Console.WriteLine("Email - " + records.Email);
            }
        }

    }
}