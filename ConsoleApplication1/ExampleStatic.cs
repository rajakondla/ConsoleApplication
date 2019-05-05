using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    static class CompanyInfo
    {
        public static string GetCompanyName()
        {
            return "CompanyName";
        }
        public static string GetCompanyAddress()
        {
            return "CompanyAddress";
        }
    }

    class TestCompanyInfo
    {
        static void Main()
        {
            Console.WriteLine(CompanyInfo.GetCompanyName());
            Console.WriteLine(CompanyInfo.GetCompanyAddress());
        }
    }
}

