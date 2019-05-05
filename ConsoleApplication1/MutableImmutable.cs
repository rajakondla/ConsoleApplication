using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class MutableImmutable 
    {
        private readonly string Name = string.Empty;

        static void Main()
        {
            //MutableImmutable obj = new MutableImmutable("Raja");
            //int i=1;
            //obj.Loop(ref i);
            //StringBuilder first = new StringBuilder();
            //first.Append("hello");
            //StringBuilder second = first;
            //first.Append(" world");
            //Console.WriteLine(second); // Prints hello world
            //Console.ReadKey();

            StringBuilder name =new StringBuilder("Raja");
            ReplaceString(name);
            Console.WriteLine(name);
            Console.ReadKey();
        }

        internal MutableImmutable(string Name)
        {
            this.Name = Name;
        }

        internal static void ReplaceString(StringBuilder str)
        {
            Console.WriteLine(str.Replace("Raja","Kondla"));
        }

        internal void Loop(ref int var)
        {
            int[] arr = {1,2,3};
            foreach (int get in arr)
            {
                int k = 0;
                Loop(ref k);
            }
        }
    }

    class CompareA
    {
        int i = 0;
    }

    class CompareB
    {
        int i = 0;
    }

    struct ImmutableStruct
    {
        internal int i;
        static void Main()
        {
            //int[] arr = { 1, 2, 3 };
            //ImmutableStruct obj = this;
            //arr.Where(g => g > obj.i).ToArray();

            int j = new int();
            int k = j;
            //Console.WriteLine();
            //Console.ReadKey();


            //CompareA a = new CompareA();
            //CompareB b = new CompareB();
            //Console.WriteLine(a.Equals(b));
            //Console.ReadKey();

            MyCustomInt64 myObj1 = 24;
            myObj1 = 25;

           Console.WriteLine(myObj1);
        }
    }

    public class MyCustomInt64 : CustomValueType<MyCustomInt64, Int64>
    {
        private MyCustomInt64(long value) : base(value) 
        { 

        }

        public static implicit operator MyCustomInt64(long value) 
        { 
            return new MyCustomInt64(value); 
        }

        public static implicit operator long(MyCustomInt64 custom) 
        { 
            return custom._value; 
        }
    }

    public class CustomValueType<TCustom, TValue>
    {
        protected readonly TValue _value;

        public CustomValueType(TValue value)
        {
            _value = value;
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public static bool operator <(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
        {
            return Comparer<TValue>.Default.Compare(a._value, b._value) < 0;
        }

        public static bool operator >(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
        {
            return !(a < b);
        }

        public static bool operator <=(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
        {
            return (a < b) || (a == b);
        }

        public static bool operator >=(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
        {
            return (a > b) || (a == b);
        }

        public static bool operator ==(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
        {
            return a.Equals((object)b);
        }

        public static bool operator !=(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
        {
            return !(a == b);
        }

        public static TCustom operator +(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
        {
            return (dynamic)a._value + b._value;
        }

        public static TCustom operator -(CustomValueType<TCustom, TValue> a, CustomValueType<TCustom, TValue> b)
        {
            return ((dynamic)a._value - b._value);
        }

        protected bool Equals(CustomValueType<TCustom, TValue> other)
        {
            return EqualityComparer<TValue>.Default.Equals(_value, other._value);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CustomValueType<TCustom, TValue>)obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<TValue>.Default.GetHashCode(_value);
        }
    }
}
