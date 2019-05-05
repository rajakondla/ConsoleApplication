using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
     class clsCopyArray
    {
        enum Software_life
        {
            Software_testing,
            Software_development,
            Project_management            
        };

        static void Main(string[] args)
        {
            Software_life my_var = Software_life.Software_development;
            Console.WriteLine(my_var);
            if (my_var == Software_life.Project_management)
            {
                Console.WriteLine("Not Same");
            }
            else if (my_var == Software_life.Software_development)
            {
                Console.WriteLine("Same");
            }          
            Console.ReadLine();
          }          
    }
}
