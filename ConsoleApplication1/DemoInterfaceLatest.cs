using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public interface IBase
    {
        void AddData();
        void DeleteData();
    }

    public abstract class AbstractBase : IBase
    {
        string ErrorMessage;
        public abstract void AddData();
        public abstract void DeleteData();
    }

    public class AClass : AbstractBase
    {
        public override void AddData()
        {
        }
        public override void DeleteData()
        {
        }
    }
}
