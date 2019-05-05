using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Customer
    {
        public string Name
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
    }

    class Business
    {
        public string BusName
        {
            get;
            set;
        }
    }

    class TestCustomer
    {
        static void Main()
        {
            Customer c1 = new Customer { Name = "Raja Kondla", City = "Vizag" };
            Customer c2 = new Customer { Name = "Raja Kondla", City = "Visakhapatnam" };
            Business b1 = new Business { BusName = "Kiran Terapalli" };
            Business b2 = new Business { BusName = "Mahesh Yenda" };
            c1.Print(c2);

            if (c1.CompareTo(c2))
                Console.WriteLine("same");
            else
                Console.WriteLine("not same");
        }
    }

    static class Extensions
    {
        public static bool CompareTo(this Customer c1, Customer c2)
        {
            if (c1.Name == c2.Name && c1.City == c2.City)
                return true;
            else
                return false;
        }
        public static void Print(this Customer c,Customer c1)
        {
            Console.WriteLine("Name is {0} and city is {1}", c.Name, c.City);
            Console.WriteLine("Name is {0} and city is {1}", c1.Name, c1.City);
        }

        public static bool BusExtension(this Business b1, Customer b2)
        {
            if (b1.BusName == b2.City)
                return true;
            else
                return false;
        }
        //public static void Print1(this Customer c)
        //{
        //    Console.WriteLine("Name is {0} and city is {1}", c.Name, c.City);
        //}
    }
                
}
