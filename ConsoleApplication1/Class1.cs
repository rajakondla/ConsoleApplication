using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Web;
using System.Web.Hosting;

namespace ConsoleApplication1
{
    public class Class1:MarshalByRefObject
    {
        static void Main()
        {          
         //  Class1 classObj= LoggingProxy<Class1>.Create(new Class1());
           //classObj.CheckDefaultException();
            var actor = (Action<string>)((mySpeech) => Console.WriteLine(mySpeech));

            dynamic dyn1 = InMyImage("Moar", actor);
            dynamic dyn2 = InMyImage("Moar", actor);

            Speak(dyn1, "Rise, my fellow ducks!");
            Speak(dyn2, "To Canada or bust!");
            Console.ReadLine();
        }

        internal void CheckDefaultException()
        {
            int i = int.MaxValue;
            int j = unchecked(i + 1);
            Console.WriteLine(j);
            Console.ReadLine();
        }

        static void Speak(dynamic d, string outWithIt)
        {
            d.Moar(outWithIt);
        }

        static dynamic InMyImage(string method, Action<string> action)
        {
            dynamic dyn = new ExpandoObject();
            ((IDictionary<String, Object>)dyn)[method] = action;
            return dyn;
        } 
    }

    public class LoggingProxy<T> : RealProxy
    {
        private readonly T _instance;

        private LoggingProxy(T instance)
            : base(typeof(T))
        {
            _instance = instance;
        }

        public static T Create(T instance)
        {
            return (T)new LoggingProxy<T>(instance).GetTransparentProxy();
        }

        public override IMessage Invoke(IMessage msg)
        {
            var methodCall = (IMethodCallMessage)msg;
            var method = (MethodInfo)methodCall.MethodBase;
            try
            {
                Console.WriteLine("Before invoke: " + method.Name);
                var result = method.Invoke(_instance, methodCall.InArgs);
                Console.WriteLine("After invoke: " + method.Name);
                return new ReturnMessage(result, null, 0, methodCall.LogicalCallContext, methodCall);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);
                if (e is TargetInvocationException && e.InnerException != null)
                {
                    return new ReturnMessage(e.InnerException, msg as IMethodCallMessage);
                }

                return new ReturnMessage(e, msg as IMethodCallMessage);
            }
        }
    }

}
