using System;
using System.Collections.Generic;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApplication1
{
    class BinarySerializationArrayListItems
    {
        public static void Main()
        {
            ArrayList itemserialize = new ArrayList();
            itemserialize.Add("Raja");
            itemserialize.Add("Kondla");

            // Serialization

            BinaryFormatter binaryobject = new BinaryFormatter();
            FileStream fwrite = new FileStream("MyNameBinary.dat", FileMode.Create);
            binaryobject.Serialize(fwrite, itemserialize);
            fwrite.Close();

            // Deserialization

            fwrite = new FileStream("MyNameBinary.dat", FileMode.Open);
            ArrayList listitema = (ArrayList)binaryobject.Deserialize(fwrite);
            foreach (string items in listitema)
                Console.WriteLine(items);
            fwrite.Close();
            File.Delete("MyNameBinary.dat");
        }
    }
}
