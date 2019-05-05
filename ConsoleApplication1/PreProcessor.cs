#define vs2008
using System;

namespace ConsoleApplication1
{
    class PreProcessor
    {
        static void Main()
        {
#if vs2005
             Console.WriteLine("Visual Studio 2005");
#elif vs2008
            Console.WriteLine("Visual Studio 2008");
        
#else
            Console.WriteLine("Express Edition");
#endif
//                        #region Authored by Raja Kondla
//                        public void Print()
//                        {
//                            Console.WriteLine("This is Raja's region");
//                        }
//            #endregion
        }
    }
}

