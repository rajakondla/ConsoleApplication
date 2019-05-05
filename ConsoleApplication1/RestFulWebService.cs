using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace ConsoleApplication1
{
    class RestFulWebService
    {
        static void Main()
        {
            RestFulWebService rs = new RestFulWebService();
            rs.GetRequest(1);
            Console.WriteLine("Post Method Begin....");
            rs.InsertEmployee();
            rs.GetRequest(104);
        }

        public void GetRequest(int empid)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost/RestWebService/employee?id=" + empid);
            request.Method = "Get";
           
            Console.WriteLine("Sending Get Request");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();  
            Stream streamData = response.GetResponseStream();
             MemoryStream ms = new MemoryStream();
             streamData.CopyTo(ms);
             byte[] byteStream = ms.ToArray();
        //    request.

            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            MemoryStream ms1 = new MemoryStream(byteStream);
            Employee emp=(Employee)xs.Deserialize(ms1);
        }

        public void InsertEmployee()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://localhost/RestWebService/employee");
            request.Method = "POST";
            request.ContentType = "text/xml";
            request.KeepAlive = false;
            request.Timeout = 5000;
           
            MemoryStream mStream = new MemoryStream();
            XmlTextWriter textWriter = new XmlTextWriter(mStream, Encoding.UTF8);
            textWriter.Formatting = Formatting.Indented;
            textWriter.WriteStartDocument();
            textWriter.WriteStartElement("Employee");
            textWriter.WriteStartElement("FirstName");
            textWriter.WriteString("Srinu");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("LastName");
            textWriter.WriteString("Gudula");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("EmpCode");
            textWriter.WriteString("104");
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Designation");
            textWriter.WriteString("BS");
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.Flush();
            textWriter.Close();

            byte[] dataStream=mStream.ToArray();
            request.ContentLength = dataStream.Length;
            Stream postStream = request.GetRequestStream();
            postStream.Write(dataStream, 0, dataStream.Length); 
            Console.WriteLine("Request successfully send......");
            HttpWebResponse webResponse = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(webResponse.GetResponseStream());
            Console.WriteLine("Response");
            Console.WriteLine(sr.ReadToEnd());
        }

    }
}
