using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Time
    {
        public int Hours
        {
            get;
            set;
        }
        public int Mins
        {
            get;
            set;
        }
        public int Seconds
        {
            get;
            set;
        }
        public int TotalSeconds
        {
            get
            {
                return Hours * 3600 + Mins * 60 + Seconds;
            }
        }

        public override bool Equals(object obj) // passing t2 object here
        {
            Time t = obj as Time;
            return t.TotalSeconds == this.TotalSeconds;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}", Hours, Mins, Seconds);
        }
        public int CompareTo(object obj)
        {
            Time t = obj as Time;
            return t.TotalSeconds - this.TotalSeconds;
        }
    }
    class TestTime
    {
        static void Main()
        {
            int resulthour;
            Time t1 = new Time { Hours = 3, Mins = 25, Seconds = 45 };
            Time t2 = new Time { Hours = 7, Mins = 56,Seconds = 45 };
            Console.WriteLine("Times are {0}", (t1.Equals(t2)) ? "same" : "different");
            int timediff=t1.CompareTo(t2);
            Console.WriteLine("first time object is {0}, second time object is {1}", t1.ToString(), t2.ToString());
            Console.WriteLine("Time difference is {0}", timediff);
                    
                //if (t1.Equals(t2))
            //    Console.WriteLine("both time is equal");
            //else
            //    Console.WriteLine("times are different");
        }
    }
}



