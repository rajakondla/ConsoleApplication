using System;
using System.Collections;

namespace ConsoleApplication1
{
    class SimpleList:IList
    {
        object[] content = new object[8];
        static int count;
        static SimpleList()
        {
            count = 0;
        }
        public int Add(object value)
        {
            if (count < content.Length)
            {
                content[count] = value;
                count++;
                return (count - 1);
            }
            else
                return -1;
        }
        public void Clear()
        {
            count = 0;
        }
        public bool Contains(object value)
        {
            bool fvalue = false;
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] == value)
                {
                    fvalue = true;
                    break;
                }
            }
            return fvalue;
        }
        public int IndexOf(object value)
        {
            int ivalue = -1;
            for (int i = 0; i < content.Length; i++)
            {
                if (content[i] == value)
                {
                    ivalue = i;
                    break;
                }
            }
            return ivalue;
        }
        public void Insert(int position, object value)
        {
            if ((count+1 < content.Length) && (position < count) && (position >= 0))
            {
                count++;
                for (int i = count-1; i >=position; i--)
                {
                    content[i] = content[i - 1];
                }
                content[position] = value;
            }
        }
        public void Remove(object value)
        {
        }
        public void RemoveAt(int position)
        {
        }
        public object this[int position]
        {
            get
            {
                return this[position];
            }
            set
            {
                this[position] = value;
            }
        }
        public bool IsReadOnly
        {
            get
            {
                return true;
            }
        }
        public bool IsFixedSize
        {
            get
            {
                return false;
            }
        }
        public void CopyTo(Array array, int index)
        {
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }
        public object SyncRoot
        {
            get
            {
                return this;
            }
        }
        public IEnumerator GetEnumerator()
        {
            // Refer to the IEnumerator documentation for an example of
            // implementing an enumerator.
            throw new Exception("The method or operation is not implemented.");
        }
        public void PrintContent()
        {
            Console.WriteLine("list has capacity of {0} and currently has {1} elements", content.Length, count);
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine(content[i]);
            }
        }
    }
    class TestSimpleList
    {
        static void Main()
        {
            SimpleList sl = new SimpleList();
            sl.Add("Raja");
            sl.Add("Srinu");
            sl.Add("Praveen");
            sl.Add("Arun");
            sl.Add("Kiran");
            sl.PrintContent();
            sl.Insert(3, "surya");
            sl.PrintContent();
        }
    }
}
