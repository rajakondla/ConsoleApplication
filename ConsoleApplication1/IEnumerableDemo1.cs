using System;
using System.Collections;

namespace ConsoleApplication1
{
    public class Tokens:IEnumerable
    {
        string[] elements;
        public string[] ProElements
        {
            get
            {
                return elements;
            }
            set
            {
                elements=value;
            }
        }
        public Tokens(string source, char[] splitting)
        {
            ProElements = source.Split(splitting);
        }
        public IEnumerator GetEnumerator()
        {
            return new TokenEnum(this);
        }
    }

    public class TokenEnum : IEnumerator
    {
        int position = -1;
        Tokens t;
        public TokenEnum(Tokens t)
        {
            this.t = t;
        }
        public bool MoveNext()
        {
            if (position < t.ProElements.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }
        public void Reset()
        {
            position = -1;
        }
        //public string[] Current
        //{
        //    get
        //    {
        //        try
        //        {
        //            return t.ProElements;
        //        }
        //        catch (Exception ex)
        //        {
        //            throw new ArgumentException("no elements found:" + ex.Message);
        //        }
        //    }
        //}
        public object Current
        {
            get
            {
                return t.ProElements[position];
            }
        }
    }

    class TestTokens
    {
        static void Main()
        {
            Tokens t = new Tokens("This is RAJA. Completed MCA", new char[] { ' ', '.', ',' });
            foreach (string de in t)
                Console.WriteLine(de);
        }
    }
}
