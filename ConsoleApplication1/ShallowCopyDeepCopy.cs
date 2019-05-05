using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class ShallowCopyDeepCopy
    {
        public static void Main()
        {
            MyEntity entityObj = new MyEntity();
            entityObj.Id = 1;
            entityObj.Name = "Raja";
            entityObj.Id1 = 1;
            entityObj.MyList = new List<int> { 1, 2, 3 };
            var anotherObj = entityObj.Clone();
            anotherObj.Id = 2;
            anotherObj.Name = "Kondla";
            entityObj.Id1 = 3;
            anotherObj.MyList.Add(10);
        }
    }

    class MyEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> MyList { get; set; }
        public int? Id1 { get; set; }
        public MyEntity Clone()
        {
            return (MyEntity)this.MemberwiseClone();
        }
    }
}
