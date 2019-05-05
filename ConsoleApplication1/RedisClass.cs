using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class RedisClass
    {
        static void Main()
        {
            using (RedisClient rdsClient=new RedisClient("localhost"))
            {
                rdsClient.Set<string>("Name","Raja Kondla");
            }

            using (RedisClient rdsClient = new RedisClient("localhost"))
            {
                Console.WriteLine(rdsClient.Get<string>("Name"));
                Console.ReadLine();
            }

            RedisClass clsObj = new RedisClass();
            clsObj.Adapt(new RedisB());
        }

        public void Adapt(RedisA obj)
        {

        }
    }

    class RedisA
    {

    }

    class RedisB : RedisA
    {

    }
}
