using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class PassingValByVal
    {
        static void SquareIt(int x)
        // The parameter x is passed by value.
        // Changes to x will not affect the original value of myInt.
        {
            x *= x;
            Console.WriteLine("The value inside the method: {0}", x);
        }
        public static void Main()
        {
            int myInt = 5;
            Console.WriteLine("The value before calling the method: {0}",
               myInt);
            SquareIt(myInt);   // Passing myInt by value.
            Console.WriteLine("The value after calling the method: {0}",
               myInt);

/* Read it with cool mind. Very easy to understand
    -----------------------------------------------
The variable myInt, being a value type, contains its data (the value 5). 
When SquareIt is invoked, the contents of myInt are copied into the parameter x, 
which is squared inside the method. 
In Main, however, the value of myInt is the same, before and after calling the SquareIt method. 
In fact, the change that takes place inside the method only affects the local variable x.

    *  output:  5
               25
                5
*/
        }
    }

    class PassingValByRef
    {
        static void SquareIt(ref int x)
        // The parameter x is passed by reference.
        // Changes to x will affect the original value of myInt.
        {
            x *= x;
            Console.WriteLine("The value inside the method: {0}", x);
        }
        public static void Main()
        {
            int myInt = 5;
            Console.WriteLine("The value before calling the method: {0}",
               myInt);
            SquareIt(ref myInt);   // Passing myInt by reference.
            Console.WriteLine("The value after calling the method: {0}",
               myInt);

/* Read it with cool mind. Very easy to understand
  -----------------------------------------------
In this example, it is not the value of myInt that is passed; 
rather, a reference to myInt is passed. 
The parameter x is not an int; it is a reference to an int (in this case, a reference to myInt).
Therefore, when x is squared inside the method,
what actually gets squared is what (parameter) x refers to: myInt.
 
 output: 5
         25
         25
*/
        }
    }

    /// Passing Reference Types by Value (Passing reference type like array, classes, Interface, Delegate)
    /// --------------------------------
    /// Here array is already a reference type
    class PassingRefByVal
    {
        static void Change(int[] arr)
        {
            arr[0] = 888;   // This change affects the original element.
            // Here parameter [arr] is used. so arr[0] is assigned with 888
            
            arr = new int[5] { -3, -1, -2, -3, -4 };   // This change is local.
            // Here new object of array is used. So, there is no link between parameter
            // arr and [arr = new int[5] { -3, -1, -2, -3, -4 };]
            Console.WriteLine("Inside the method, the first element is: {0}", arr[0]);
        }

        public static void Main()
        {
            int[] myArray = { 1, 4, 5 };
            Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", myArray[0]);
            Change(myArray);
            Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", myArray[0]);
        }
/* Read it with cool mind. Very easy to understand
--------------------------------------------------
1)Here In first output simple fetching
2)In Second myArray[0] is replaced with 888,but new object is created, so myArray is 
  not effected. The result is from new object.(New memory allocation is done)
3)In Third as myArray[0] is replaced with 888, and array is a reference type code works as 
  it is of type ref keyword.

output:   1
         -3
        888
*/
    }

    /// Passing Reference Types by Reference
    /// --------------------------------
    /// Here array is already a reference type
    class PassingRefByRef
    {
        static void Change(ref int[] arr)
        {
            // Both of the following changes will affect the original variables:
            arr[0] = 888;
            arr = new int[5] { -3, -1, -2, -3, -4 };
            Console.WriteLine("Inside the method, the first element is: {0}", arr[0]);
        }

        public static void Main()
        {
            int[] myArray = { 1, 4, 5 };
            Console.WriteLine("Inside Main, before calling the method, the first element is: {0}", myArray[0]);
            Change(ref myArray);
            Console.WriteLine("Inside Main, after calling the method, the first element is: {0}", myArray[0]);
        }
        /* Read it with cool mind. Very easy to understand
    --------------------------------------------------
    1)Here In first output simple fetching
    2)In Second myArray[0] is replaced with 888. 
    3)In Third as ref keyword is used in Change method, reallocation is done
      means a new memory allocation is not done. So here array is having 5 elements in Main
      method.

    output:  1
            -3
            -3
    */
    }
    /// <summary>
    /// Swapping of two strings.
    /// </summary>
    class SwappinStrings
    {
        static void SwapStrings(string s1, string s2)
        // The string parameter x is passed by reference.
        // Any changes on parameters will affect the original variables.
        {
            //string temp = s1;
            //s1 = s2;
            //s2 = temp;
            //Console.WriteLine("Inside the method: {0}, {1}", s1, s2);
            Console.WriteLine("asd:{0}",s1.Replace('h','R'));
        }
        public static void Main()
        {
            string str1 = "John";
            string str2 = "Smith";
            Console.WriteLine("Inside Main, before swapping: {0} {1}",
               str1, str2);
            SwapStrings(str1, str2);   // Passing strings by reference
            Console.WriteLine("Inside Main, after swapping: {0}, {1}",
               str1, str2);
        }
    }
}
