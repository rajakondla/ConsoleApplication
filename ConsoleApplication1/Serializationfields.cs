using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace ConsoleApplication1
{
    [Serializable]
    class Persons:IDeserializationCallback
    {
        private string name;
        private string email;
        [NonSerialized]
        private string emailserver;
        [OptionalField]
        private string phone;
        public Persons(string name, string email, string phone)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            emailserver = email.Substring(email.IndexOf("@") + 1);
        }
        public void Print()
        {
            Console.WriteLine("{0}, {1}, {2}, {3} ", name, email, phone, emailserver);
        }
        public void OnDeserialization(object sender) //  It is called after Deserialization is completed
        {
            emailserver = email.Substring(email.IndexOf("@") + 1);
        }
    }
    class TestPerson
    {
        static void Main()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(@"D:\PersonDetails.dat", FileMode.Create);
            Persons ps = new Persons("Raja", "rajakondla@gmail.com", "9030153121");
            bf.Serialize(fs, ps);
            fs.Close();
            fs = new FileStream("PersonDetails.dat", FileMode.Open);
            Persons p = (Persons)bf.Deserialize(fs);

            // here OnDeserialization is called 

            p.Print();
            fs.Close();
        }
    }
}
