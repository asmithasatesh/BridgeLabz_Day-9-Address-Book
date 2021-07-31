using System;
using System.Collections.Generic;
using System.Linq;

namespace Address_Book
{

    public class AddressBookSystem
    {

        public List<AddressBookSystem> stateList { get; set; }
        public List<AddressBookSystem> cityList { get; set; }

        //instance variables 
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string key { get; set; }
        public List<AddressBookSystem> ContactArray { get; set; }

        //Default Contructor
        public AddressBookSystem()
        {
            this.ContactArray = new List<AddressBookSystem>();
        }
        public override string ToString()
        {
            return ("Name: " + this.firstName +" "+ this.lastName + " \t Address: " +this.Address+" \t City: " +this.city+" \t State: "+this.state+" \t Pincode: " +this.zip+" \t Phone Number: "+this.phoneNumber+" \t Email Id: "+this.email);
        }
        //To add Contact to Address Book
        public void CreateContact(string addrBookName,string firstName, string lastName, string Address, string city, string state, string zip, string phoneNumber, string email)
        {
            AddressBookSystem bookSystem=new AddressBookSystem() ;
            bookSystem.firstName = firstName;
            bookSystem.lastName = lastName;
            bookSystem.Address = Address;
            bookSystem.city = city;
            bookSystem.state = state;
            bookSystem.zip = zip;
            bookSystem.phoneNumber = phoneNumber;
            bookSystem.email = email;
            bookSystem.key = addrBookName;


            //Newly add element to List
            if (ContactArray.Count== 0)
            {
                
                ContactArray.Add(bookSystem);
                if (ContactPerson.State.ContainsKey(state))
                {
                    List<AddressBookSystem> existing = ContactPerson.State[state];
                    existing.Add(bookSystem);

                }
                else
                {
                    stateList = new List<AddressBookSystem>();
                    stateList.Add(bookSystem);
                    ContactPerson.State.Add(state, stateList);

                }
                if (ContactPerson.City.ContainsKey(city))
                {
                    List<AddressBookSystem> existing = ContactPerson.City[city];
                    existing.Add(bookSystem);

                }
                else
                {
                    cityList = new List<AddressBookSystem>();
                    cityList.Add(bookSystem);
                    ContactPerson.City.Add(city, cityList);

                }

                ContactPerson obj = new ContactPerson();
                obj.Display(ContactArray, ContactArray.Count);

            }
            else if (ContactArray.Count != 0)
            {
                //Check if element already present in List
                AddressBookSystem addressBookSystems = ContactArray.Find(x => x.firstName.Equals(firstName));
                if(addressBookSystems == null)
                {

                    ContactArray.Add(bookSystem);
                    if (ContactPerson.State.ContainsKey(state))
                    {
                        List<AddressBookSystem> existing = ContactPerson.State[state];
                        existing.Add(bookSystem);

                    }
                    else
                    {
                        stateList = new List<AddressBookSystem>();
                        stateList.Add(bookSystem);
                        ContactPerson.State.Add(state, stateList);
    
                    }
                    if (ContactPerson.City.ContainsKey(city))
                    {
                        List<AddressBookSystem> existing = ContactPerson.City[city];
                        existing.Add(bookSystem);

                    }
                    else
                    {
                        cityList = new List<AddressBookSystem>();
                        cityList.Add(bookSystem);
                        ContactPerson.City.Add(city, cityList);

                    }

                    ContactPerson obj = new ContactPerson();
                    obj.Display(ContactArray, ContactArray.Count);
                }
                else
                {
                    Console.WriteLine("This person already exists in your AddressBook!");
                }

            }
        }
        //Function call To modify
        public void Modify() 
        {
            //User enters field to Modify
            int i=0;
            Console.WriteLine("-------To Modify-------\nEnter first name of user that needs modification");
            string name = Console.ReadLine();

            //Traverse till the desired index
            while( ContactArray[i].firstName!= name)
            {
                i++;
            }

            Console.WriteLine("Enter field to be modified 1.firstName 2.lastName 3.Address 4.city 5.state 6.zip 7.phoneNumber 8.email 9.Delete a contact");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the modified value");
                    string fn = Console.ReadLine();
                    ContactArray[i].firstName = fn;
                    break;
                case 2:
                    Console.WriteLine("Enter the modified value");
                    string ls = Console.ReadLine();
                    ContactArray[i].lastName = ls;
                    break;
                case 3:
                    Console.WriteLine("Ente the modified value");
                    string add = Console.ReadLine();
                    ContactArray[i].Address = add;
                    break;
                case 4:
                    Console.WriteLine("Enter the modified value");
                    string cities = Console.ReadLine();
                    ContactArray[i].city = cities;
                    break;
                case 5:
                    Console.WriteLine("Enter the modified value");
                    string states = Console.ReadLine();
                    ContactArray[i].state=states;
                    break;
                case 6:
                    Console.WriteLine("Enter the modified value");
                    string temp =(Console.ReadLine());
                    ContactArray[i].zip = temp;
                    break;
                case 7:
                    Console.WriteLine("Ente the modified value");
                    string phn = Console.ReadLine();
                    ContactArray[i].phoneNumber = phn;
                    break;
                case 8:
                    Console.WriteLine("Ente the modified value");
                    string emails = Console.ReadLine();
                    ContactArray[i].email = emails;
                    break;
                    //Delete a user
                case 9:
                    ContactArray = ContactArray.Take(i).Concat(ContactArray.Skip(i + 1)).ToList();
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
            //Display Function
            ContactPerson obj = new ContactPerson();
            obj.Display(ContactArray, ContactArray.Count);
        }
    }
}
