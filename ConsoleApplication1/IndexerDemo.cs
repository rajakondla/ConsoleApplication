using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Tm
    {
        public string name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null)
                    throw new ArgumentException("cannot be null");
                else
                    name = value;
            }
        }
        private string[] players = new string[10];
        public string this[int index]
        {
            get
            {
                return players[index];
            }
            set
            {
                players[index] = value;
            }
        }
    }
    class TestTeam
    {
        static void Main()
        {
            Tm t = new Tm();
            t.name = "Raj";
            Console.WriteLine("Team members are:");
            t[0] = "Dhoni";
            t[1] = "Yuvraj";
            t[2] = "Yusuf";
            t[3] = "Raina";
            t[4] = "Sachin";
            Console.WriteLine(t.name);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(t[i]);
            }
        }
    }
}
