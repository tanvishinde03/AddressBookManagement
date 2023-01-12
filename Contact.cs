using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookManagement
{
    internal class Contact
    {
        internal string first_Name;
        internal string last_Name;
        internal string present_Address;
        internal string city;
        internal string email_Id;
        internal string state;
        internal string zip;
        internal string phone_Number;

        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Present_Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email_Id { get; set; }
        public string Phone_Number { get; set; }
        public string Zip { get; set; }
        public override string ToString()
        {
            return "FirstName: " + this.First_Name + " \nLastName: " + this.Last_Name
                                    + " \nPresent Address: " + this.Present_Address + " \nCity: " + this.City + " \nState: "
                                    + this.State + " \nZipcode: " + this.Zip + " \nPhoneNumber: "
                                    + this.Phone_Number + " \nEmail: " + this.Email_Id;






        }
    }
}
