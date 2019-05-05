using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;

namespace ConsoleApplication1
{
    class Client
    {
        public static void Main(string[] args)
        {
            TcpChannel chan = new TcpChannel();
            ChannelServices.RegisterChannel(chan);

            // Create an instance of the remote object
            IRemoteInterface obj = (IRemoteInterface)Activator.GetObject(
                     typeof(IRemoteInterface), "tcp://localhost:8888/cincom");
            // localhost  OR your server name
            if (obj.Equals(null))
            {
                System.Console.WriteLine("Error: unable to locate server");
            }
            else
            {
                String strArgs;
                if (args.Length == 0)
                {
                    strArgs = "Client";
                }
                else
                {
                    strArgs = args[0];
                }
                obj.WriteName(strArgs);
                System.Console.WriteLine(obj.ReadWelcome());
                Console.ReadKey();
            }
        }
    }
}
