using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    [AttributeUsage(AttributeTargets.All)]
    class AuthorAttribute : Attribute
    {
        string author;
        string email;
        public string AuthorName
        {
            get
            {
                return author;
            }
        }
        public string EmailAddress
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public AuthorAttribute(string author)
        {
            this.author = author;
        }
    }

    [Author("Raja Kondla")]
    class Player
    {
    }

    [Author("Raja Kondla", EmailAddress = "rajakondla@gmail.com")]
    //class Tm
    //{
    //    [Author("Kiran Terapalli")]
    //    public void Print()
    //    {
    //    }
    //}
    class TestAuthorAttribute
    {
        static void Main()
        {
            //AuthorAttribute at = new AuthorAttribute();
            //Type pt = Type.GetType(at);
            //Object[] ca = pt.GetCustomAttributes(true);
            //foreach (object a in ca)
            //    Console.WriteLine(a);
            //AuthorAttribute aa = (AuthorAttribute)Attribute.GetCustomAttribute(typeof(Tm), typeof(AuthorAttribute));
            //Console.WriteLine(aa.AuthorName);
            //Console.WriteLine(aa.EmailAddress); 
        }
    }
}
