using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ContactNames
    {
        public string name
        {
            get;
            private set;
        }
        public string address
        {
            get;
            private set;
        }
            
        public ContactNames(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
    class ContactNames1
    {
        public string name
        {
            get;
            private set;
        }
        public string address
        {
            get;
            private set;
        }
        private ContactNames1(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public static ContactNames1 CreateContact(string name, string address)
        {
            return new ContactNames1(name, address);// one way to create an object
        }
    }
    class TestContact
    {
        static void Main()
        {
            string[] name = { "Raja K", "Arun G.V", "Praveen N", "Srinu G" };
            string[] address ={"Door No:21-22-3, sunnapu veedhi, ear town kotha road",
                              "Door No:22-22-3, sunnapu veedhi, near town kotha road",
                              "Door No:23-22-3, sunnapu veedhi, near town kotha road",
                              "Door No:24-22-3, sunnapu veedhi, near town kotha road"};

            // creation of object from a select clause
            var GetName = from nameadd in Enumerable.Range(0, 4)
                          select new ContactNames(name[nameadd], address[nameadd]);
            var list = GetName.ToList();
            foreach (var na in list)
                Console.WriteLine("{0},'{1}'",na.name,na.address);
            Console.WriteLine("====================================================================");
            var GetName1 = from nameadd in Enumerable.Range(0, 4)
                           select ContactNames1.CreateContact(name[nameadd], address[nameadd]);
            var list1 = GetName1.ToList();
            foreach (var na in GetName1)
                Console.WriteLine("{0},'{1}'", na.name, na.address);            
        }
    }
}
