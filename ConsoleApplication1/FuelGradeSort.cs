using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public enum FuelGradeSort { Unl=0, Reg=1, Dsl=2, Mid=3 }
    public enum SortDirection {Asc=0,Dsc=1 }

    class FuelGrade
    {
        static void Main()
        {
            string[] fuelGrades = { "Dsl", "Unl", "Mid", "Reg" };
            List<string> data=fuelGrades.ToList();
            data.Sort(Compare);
            foreach (string get in data)
                Console.WriteLine(get);        

            Console.ReadKey();
        }

        static int Compare(string x, string y)
        {
            return (((int)((FuelGradeSort)Enum.Parse(typeof(FuelGradeSort), x, true))).CompareTo(((int)((FuelGradeSort)Enum.Parse(typeof(FuelGradeSort), y, true)))));
        }
    }

}
