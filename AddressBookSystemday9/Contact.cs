﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystemday9
{
    internal class Contact
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public int Zip { get; set; }

        public int PhoneNumber { get; set; }

        public string Email { get; set; }
    }
}
