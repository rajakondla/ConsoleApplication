using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Address
    {

        int _DoorNo;

        public int DoorNo
        {

            get { return _DoorNo; }

            set { _DoorNo = value; }

        }



        string _StreetName;

        public string StreetName
        {

            get { return _StreetName; }

            set { _StreetName = value; }

        }





        string _City;

        public string City
        {

            get { return _City; }

            set { _City = value; }

        }





        string _State;

        public string State
        {

            get { return _State; }

            set { _State = value; }

        }



        int _Phone;

        public int PhoneNo
        {

            get { return _Phone; }

            set { _Phone = value; }

        }



        public Address() { }



        public Address(int DoorNumber, string StreetName, string CityName)
        {

            this.DoorNo = DoorNumber;

            this.StreetName = StreetName;

            this.City = CityName;

            this.PhoneNo = 0;

        }



        public Address(int DoorNumber, string StreetName, string CityName, int PhoneNumber)
        {

            this.DoorNo = DoorNumber;

            this.StreetName = StreetName;

            this.City = CityName;

            this.PhoneNo = PhoneNumber;

        }

    }



    // Main class as follows:


    class Program1
    {
        static void Main(string[] args)
        {
            List<Address> myAddress = new List<Address>();
            myAddress.Add(new Address(1, "New Street", "Chennai"));
            myAddress.Add(new Address(2, "Second Main Road, TNHB", "Chennai", 866413553));
            myAddress.Add(new Address(3, "New Street", "Bangalore"));
            myAddress.Add(new Address(4, "Second Main Road, TNHB", "Bangalore", 885634367));
            myAddress.Add(new Address(5, "New Street", "Pune"));
            myAddress.Add(new Address(6, "Second Main Road, TNHB", "Pune", 433243664));
            myAddress.Add(new Address(7, "New Street", "Gurgaon"));
            myAddress.Add(new Address(8, "Second Main Road, TNHB", "Gurgaon", 564778634));


            foreach (Address a in myAddress)
            {
                Console.WriteLine("New Address Entry follows: \n");
                Console.WriteLine("Door Number : " + a.DoorNo);
                Console.WriteLine("Street Name :" + a.StreetName);
                Console.WriteLine("City :" + a.City);
                Console.WriteLine("Phone Number:" + a.PhoneNo + "\n\n");
            }
            Console.ReadLine();
        }
    }
}
