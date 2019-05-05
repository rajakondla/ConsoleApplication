using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    public class Pizza
    {
        protected string name = string.Empty;
        public virtual string Prepare 
        { 
            get 
            {
                return name; 
            } 
        }
        public string Cut { get { return "Cut"; } }
        public string Bake { get { return "Bake"; } }
        public string Box { get { return "Box"; } }
    }

    public class NYCheesPizza : Pizza
    {
        public override string Prepare
        {
            get
            {
                return base.Prepare + " with NY chees";
            }
        }
    }

    public abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza = CreatePizza(type);

            Console.WriteLine(pizza.Prepare);
            Console.WriteLine(pizza.Prepare);
            Console.WriteLine(pizza.Prepare);
            Console.WriteLine(pizza.Prepare);
        }

        public abstract Pizza CreatePizza(string type);
    }

    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "chees": return new NYCheesPizza();
                default: return null;
            }
        }
    }

    public class TestPizzaStore
    {
        public static void Main()
        {
          //  PizzaStore pizzaStore = new 
        }
    }

    public class RefClass
    {
        public string Name = "Raja";
    }

    public class TestRefClass
    {
        public static void Main()
        {
            TestRefClass testRefObj = new TestRefClass();
            RefClass refObj = new RefClass();
            testRefObj.ChangeRef(refObj);
            List<int> list = new List<int>();
            Console.WriteLine(refObj.Name);
            Console.ReadKey();
        }

        public void ChangeRef(RefClass refObj)
        {
            refObj = new RefClass();
            refObj.Name = "Kondla";
        }
    }

    class SingletonTest
    {
        //public String abc;
      //  private static SingletonTest _obj = new SingletonTest();
        //public static string xyz="abc";
        //public static string xyz1 = "xyz";
        public static string xyz2 = Print("print 1");
        public int i;
        static SingletonTest()
        {
            //   _obj.abc = "test test";

              Console.WriteLine("static constructor called");
        }

        //public SingletonTest()
        //{
        //    ////_obj.abc = "test test";
        //    if (i != 0)
        //    {

        //    }
        //    Console.WriteLine("private constructor called");
        //}

        //public static SingletonTest Instance
        //{
        //    get { return _obj; }
        //}

        public static string Print(string str)
        {
            return str;
        }
    }
   
    class TestSingleton
    {
        public static void Main()
        {
            Console.WriteLine("Main First Call");
           // SingletonTest obj = new SingletonTest();
            //Thread.Sleep(10000);
            Console.WriteLine(SingletonTest.Print("Main print"));
          //  Console.WriteLine(SingletonTest.xyz1);
         //   Console.WriteLine(SingletonTest.Instance.abc);
          //  Console.WriteLine(SingletonTest.xyz);
            Console.ReadLine();
            //CCC c = new CCC();
            //Console.ReadLine();
            /*
               1) first Main First Call is printed
             * 2) then public SingletonTest() is called so SingletonTest parent object is created then _obj object is created and xyz is intialized
             * 3) static  SingletonTest() is called then static constructor called is printed then _obj.abc is instalized
             * 4) test test is printed
             */
        }
    }
 
   
}
