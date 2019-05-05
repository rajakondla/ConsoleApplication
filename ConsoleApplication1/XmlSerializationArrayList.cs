using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConsoleApplication1
{
    class XmlSerializationArrayList
    {
        static void Main()
        {
            // Serialization

            ArrayList listtoserialize = new ArrayList();
            listtoserialize.Add("Raja");
            listtoserialize.Add("Kondla");
            /*In the constructor of XmlSerializer class, we have to specify what type of object 
              we want to serialize using this. Since we are going to serialize an ArrayList, 
              we are specifying 'typeof(ArrayList)'.*/

            XmlSerializer serial = new XmlSerializer(typeof(ArrayList));

            /* Next, we are going to do the real thing - saving the state of the ArrayList into an 
               XML file. We will create a TextWriter object and specify the xml file name to which 
               we will save the ArrayList.*/

            TextWriter write = new StreamWriter("MyName.xml");

            /* Now listtoserialize items are copied to MyName.xml and serialize with XmlSerialization object
               i.e., serial*/
            serial.Serialize(write, listtoserialize);
            write.Close();

            // Deserialization
            FileStream fs = new FileStream("MyName.xml", FileMode.Open);
            ArrayList listitem = (ArrayList)serial.Deserialize(fs);
            foreach (string item in listitem)
                Console.WriteLine(item);
            fs.Close();
        }
    }
}
