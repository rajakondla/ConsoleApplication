using System;
using System.Collections;

namespace ConsoleApplication1
{
    public class Person
    {
        public string firstname;
        public string secondname;
        public Person(string firstname,string secondname)
        {
            this.firstname=firstname;
            this.secondname=secondname;
        }
    }

   // need of implementing IEnumerable interface helps us to obtain the elements by a foreach(.........) loop.

    public class People //: IEnumerable
    {
        Person[] people;
        public People(Person[] personarr)
        {
            people = new Person[personarr.Length];
            for (int i = 0; i < personarr.Length; i++)
            {
                people[i] = personarr[i];
            }
        }

        // IEnumerable.GetEnumerator returns the enumerator for the collection.
        // all elements are collected here.

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return (IEnumerator)GetEnumerator();
        //}

        // we are not creating PeopleEnum object in App class . As PeopleEnum is implementing IEnumerator 
        // we are creating here with GetEnumerator().
        // all the elements entered in App class comes here.

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(people);
        }
    }

    public class PeopleEnum//:IEnumerator
    {
        Person[] people;
        int position = -1;
        public PeopleEnum(Person[] list)
        {
            people = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < people.Length);
        }
        public void Reset()
        {
            position = -1;
        }
        public Person Current
        {
            get
            {
                try
                {
                return people[position];
                }
                catch (Exception ex)
                {
                    throw new InvalidOperationException("no elements:"+ex);
                }
            }
        }
        //object IEnumerator.Current
        //{
        //    get
        //    {
        //        return Current;
        //    }
        //}
    
    }
    class App
    {
        static void Main()
        {
            Person[] personarray = new Person[4]{new Person("Raja","Kondla"),
                                          new Person("Arun","Garikenna"),
                                          new Person("Praveen","NagaSuri"),
                                          new Person("Srinu","Guddla")
                                         };
            People peoplearray = new People(personarray);
           
            foreach (Person p in peoplearray)
            {
                Console.WriteLine(p.firstname + " " + p.secondname);
            }
            Console.ReadLine();
        }
    }
}
