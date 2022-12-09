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
        public void EditContact()
        {
            Console.WriteLine("To edit contact details enter contact firstname");
            string name = Console.ReadLine();
            foreach (var record in data)
            {
                if (record.Firstname == name)
                {
                    Console.WriteLine(name + " is exists");
                    Console.WriteLine("To edit details Enter\n1Lastname\n2.Address\n3.City\n4.State\n5.Zip\n6.Phonenumber\n7.Email");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter new Lastname");
                            string newLastname = Console.ReadLine();
                            record.Lastname = newLastname;
                            break;
                        case 2:
                            Console.WriteLine("Enter new Address");
                            string newAddress = Console.ReadLine();
                            record.Address = newAddress;
                            break;
                        case 3:
                            Console.WriteLine("Enter new City");
                            string newCity = Console.ReadLine();
                            record.City = newCity;
                            break;
                        case 4:
                            Console.WriteLine("Enter new State");
                            string newState = Console.ReadLine();
                            record.State = newState;
                            break;
                        case 5:
                            Console.WriteLine("Enter new Zip");
                            int newZip = Convert.ToInt32(Console.ReadLine());

                            record.Zip = newZip;
                            break;
                        case 6:
                            Console.WriteLine("Enter new Phonenumber");
                            int newPhonenumber = Convert.ToInt16(Console.ReadLine());
                            record.PhoneNumber = newPhonenumber;
                            break;
                        case 7:
                            Console.WriteLine("Enter new Email");
                            string newEmail = Console.ReadLine();
                            record.Email = newEmail;
                            break;
                    }
                    return;
                }
                else
                {
                    Console.WriteLine("Name does not exists");
                }
            }
        }

    }
}

    
