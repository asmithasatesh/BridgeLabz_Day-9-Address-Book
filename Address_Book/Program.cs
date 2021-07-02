using System;

namespace Address_Book
{
    public class AddressBookSystem
    {
        //instance variables 
        public string firstName;
        public string lastName;
        public string Address;
        public string city;
        public string state;
        public int zip;
        public long phoneNumber;
        public string email;
        public AddressBookSystem[] ContactArray;
        int contact = 0;

        //Parameterised Constructor
        public AddressBookSystem(string firstName, string lastName, string Address, string city, string state, int zip, long phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Address = Address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;

        }
        //Default Contructor
        public AddressBookSystem()
        {
            this.ContactArray = new AddressBookSystem[10];
        }

        //To add Contact to Address Book
        public void CreateContact(string firstName, string lastName, string Address, string city, string state, int zip, long phoneNumber, string email)
        {

            ContactArray[this.contact] = new AddressBookSystem(firstName, lastName, Address, city, state, zip, phoneNumber, email);
            contact++;
            ContactPerson obj = new ContactPerson();
            obj.Display(ContactArray, contact);
        }


    }


    class ContactPerson
    {
        static void Main(string[] args)
        {
            //Calls Default constructor
            AddressBookSystem addressBookSystem = new AddressBookSystem();
            //Call Method
            addressBookSystem.CreateContact("Ash", "sat", "Chennai thirumulaivoyal", "chennai", "TN", 243001, 9842905050, "asmithasatesh");
            addressBookSystem.CreateContact("abcd", "lastabcd", "Chennai thirumulaivoyal", "chennai", "TN", 243001, 9842905050, "asmithasatesh@gmail.com");

        }
        //Display Details
        public void Display(AddressBookSystem[] ContactArray, int N)
        {
            Console.WriteLine("---------Address Book Contains---------");
            int i;
            for (i = 0; i < N; i++)
            {
                Console.WriteLine("First name: {0}\n Last name: {1}\n Address: {2}\n City: {3}\n Zip: {4}\n State: {5}\n Phone Number: {6}\n Email: {7} \n", ContactArray[i].firstName, ContactArray[i].lastName, ContactArray[i].Address, ContactArray[i].city, ContactArray[i].zip, ContactArray[i].state, ContactArray[i].phoneNumber, ContactArray[i].email);
            }
        }
    }
}
