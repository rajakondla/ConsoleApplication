using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    enum Numbers
    {
        one,
        two,
        three
    };
    class EnumStringToInt
    {
        static void Main()
        {
            Numbers num = Numbers.one; // converting enum to string
            string str = num.ToString();
            //Console.WriteLine(str);
            string str1 = "three";
            //string[] getnames = (string[])Enum.GetNames(typeof(Numbers));
            //int[] getnum = (int[])Enum.GetValues(typeof(Numbers));
            //try
            //{
            //    for (int i = 0; i <= getnum.Length; i++)
            //    {
            //        if (str1.Equals(getnames[i]))
            //        {
            //            Numbers num1 = (Numbers)Enum.Parse(typeof(Numbers), str1);
            //            Console.WriteLine("string found:{0}", num1);
            //        }
            //    }
            //}
            //string[] getNames=(string[])Enum.GetNames(typeof(Numbers));
            //int [] getValues=(int[])Enum.GetValues(typeof(Numbers));
            //for(int i=0;i<getValues.Length;i++)
            //{
            //    if(str.Equals(getNames[i]))
            //    {
            //       Numbers num1=(Numbers)Enum.Parse(typeof(Numbers),str1);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Value not found!", ex);
            //}
            Numbers num1 = (Numbers)Enum.Parse(typeof(Numbers), "Raja");
            int[] getValues = (int[])Enum.GetValues(typeof(Numbers));
            for (int i = 0; i < getValues.Length; i++)
            {

            }
        }
    }
}
