using AddressBookSystemday9;


internal class Program
{


    static void Main(string[] args)
    {
        AddressBook book = new AddressBook();
        book.CreateContact();
        while (true)
        {
            Console.WriteLine("1.Create Contact\n2.Display Contact");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    book.CreateContact();
                    break;
                case 2:
                    book.DisplayContact();
                    break;
            }
        }



    }
}