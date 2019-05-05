using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels.Http;
using System.Reflection;
using System.Runtime.Serialization;

namespace ConsoleApplication1
{
    public interface IRemoteInterface
    {
        void WriteName(string str);
        string ReadWelcome();
        string Get { get; }
    }

    [Serializable]
    public class EmployeeSerial //: ISerializable
    {
        private int _salary;

        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    }

    [Serializable]
    public class RemoteClass ://MarshalByRefObject,
        IRemoteInterface
    {
        private static string strWelcomeClient;
        public string Get
        {
            get { return "Get"; }
        }

        public RemoteClass()
        {
            Console.WriteLine("Object created");
        }

        public string ReadWelcome()
        {
            return strWelcomeClient;
        }

        //public void Print()
        //{
        //    Console.WriteLine(strWelcomeClient);
        //}

        public void WriteName(string strNameFromClient)
        {
            strWelcomeClient += "HI " + strNameFromClient +
    ". Welcome to Remoting World!!";
        }
    }

    public interface IFactorySerial
    {
        IRemoteInterface GetObj();
    }

    public class FactorySerial : MarshalByRefObject,
        IFactorySerial
    {
        public IRemoteInterface GetObj()
        {
            return new RemoteClass();
        }
    }

    public class ServerSerial
    {
        public static void Main(string[] args)
        {
            TcpChannel channel = new TcpChannel(8888);
            ChannelServices.RegisterChannel(channel);

            RemotingConfiguration.RegisterWellKnownServiceType(
                     typeof(FactorySerial), "cincom",
          WellKnownObjectMode.SingleCall);

            System.Console.WriteLine("The Server is ready .... Press the enter key to exit...");
            System.Console.ReadLine();
        }
    }

    public class ClientSerial
    {
        public static void Main(string[] args)
        {
            //TcpChannel channel = new TcpChannel(8889);
            //ChannelServices.RegisterChannel(channel);

            IFactorySerial factoryIstance = (IFactorySerial)Activator.GetObject(typeof(IFactorySerial), "tcp://localhost:8888/cincom");
            // instance.WriteName("empty");
            IRemoteInterface remoteInstance = factoryIstance.GetObj();
            Console.WriteLine(remoteInstance.ReadWelcome());
            remoteInstance.WriteName("Raja");

            Console.WriteLine(remoteInstance.ReadWelcome());

            string line = Console.ReadLine();
            remoteInstance.WriteName($"->{line}");

            Console.WriteLine(remoteInstance.ReadWelcome());
            System.Console.ReadLine();
        }
    }




    public interface IFactory
    {

        ITrade GetTrade(int customerId);

    }

    public interface ITrade
    {

        double NumberOfShares { get; set; }
        string EquityName { get; set; }
        double EquityPrice { get; set; }
        double Cost { get; }
        double Commission { get; set; }

        string RepId { get; set; }
    }

    //public class Form1 : System.Windows.Forms.Form
    //{

    //    private Generator Generator;

    //    private Trade trade;

    //    private void Form1_Load(System.Object sender, System.EventArgs e)
    //    {
    //        HttpChannel channel = new HttpChannel();
    //        ChannelServices.RegisterChannel(channel);

    //        object Instance = Activator.GetObject(typeof(IFactory), "http://localhost:8080/Factory.soap");

    //        IFactory Factory = (IFactory)Instance;
    //        trade = Factory.GetTrade(1234);

    //        trade.EquityName = "MSFT";
    //        Debug.WriteLine(trade.Cost.ToString());
    //        Generator = new Generator(this, typeof(Trade), trade);
    //        Generator.AddControls();

    //    }
    //    public Form1()
    //    {
    //        Load += Form1_Load;
    //    }
    //}


    //[Serializable()]
    //public class Trade
    //{

    //    private int FCustomerId;
    //    private double FNumberOfShares;
    //    private string FEquityName;
    //    private double FEquityPrice;
    //    private double FCommission;

    //    private string FRepId;
    //    public int CustomerId
    //    {
    //        get { return FCustomerId; }
    //        set { FCustomerId = value; }
    //    }

    //    public double NumberOfShares
    //    {
    //        get { return FNumberOfShares; }
    //        set { FNumberOfShares = value; }
    //    }

    //    public string EquityName
    //    {
    //        get { return FEquityName; }
    //        set
    //        {
    //            Console.WriteLine("EquityName was {0}", FEquityName);
    //            FEquityName = value;
    //            Console.WriteLine("EquityName is {0}", FEquityName);
    //            Console.WriteLine(Assembly.GetExecutingAssembly().FullName);

    //        }
    //    }

    //    public double EquityPrice
    //    {
    //        get { return FEquityPrice; }
    //        set { FEquityPrice = value; }
    //    }

    //    public double Cost
    //    {
    //        get { return FEquityPrice * FNumberOfShares + FCommission; }
    //    }

    //    public double Commission
    //    {
    //        get { return FCommission; }
    //        set { FCommission = value; }
    //    }

    //    public string RepId
    //    {
    //        get { return FRepId; }
    //        set { FRepId = value; }
    //    }

    //}


    public class Factory : MarshalByRefObject, IFactory
    {

        public ITrade GetTrade(int customerId)
        {
            Console.WriteLine("Factory.GetTrade called");

            Trade trade = new Trade();
            trade.Commission = 25;
            trade.EquityName = "DYN";
            trade.EquityPrice = 2.22;
            trade.NumberOfShares = 1000;
            trade.RepId = "999";

            return trade;
        }

    }

    public class Trade : MarshalByRefObject, ITrade
    {

        private int FCustomerId;
        private double FNumberOfShares;
        private string FEquityName;
        private double FEquityPrice;
        private double FCommission;

        private string FRepId;
        public double NumberOfShares
        {
            get { return FNumberOfShares; }
            set { FNumberOfShares = value; }
        }

        public string EquityName
        {
            get { return FEquityName; }
            set
            {
                Console.WriteLine("EquityName was {0}", FEquityName);
                FEquityName = value;
                Console.WriteLine("EquityName is {0}", FEquityName);
                Console.WriteLine(Assembly.GetExecutingAssembly().FullName);

            }
        }

        public double EquityPrice
        {
            get { return FEquityPrice; }
            set { FEquityPrice = value; }
        }

        public double Cost
        {
            get { return FEquityPrice * FNumberOfShares + FCommission; }
        }

        public double Commission
        {
            get { return FCommission; }
            set { FCommission = value; }
        }

        public string RepId
        {
            get { return FRepId; }
            set { FRepId = value; }
        }

    }


    //public class Form1 : System.Windows.Forms.Form
    //{

    //    private Generator Generator;

    //    private Trade trade;

    //    private void Form1_Load(System.Object sender, System.EventArgs e)
    //    {
    //        HttpChannel channel = new HttpChannel();
    //        ChannelServices.RegisterChannel(channel);

    //        object Instance = Activator.GetObject(typeof(IFactory), "http://localhost:8080/Factory.soap");

    //        IFactory Factory = (IFactory)Instance;
    //        trade = Factory.GetTrade(1234);

    //        trade.EquityName = "MSFT";
    //        Debug.WriteLine(trade.Cost.ToString());
    //        Generator = new Generator(this, typeof(Trade), trade);
    //        Generator.AddControls();

    //    }
    //    public Form1()
    //    {
    //        Load += Form1_Load;
    //    }

    //}


    //[Serializable()]
    //public class Trade : ISerializable
    //{

    //    private int FCustomerId;
    //    private double FNumberOfShares;
    //    private string FEquityName;
    //    private double FEquityPrice;
    //    private double FCommission;

    //    private string FRepId;
    //    public Trade()
    //    {
    //    }


    //    public Trade(SerializationInfo info, StreamingContext context)
    //    {
    //        Debug.WriteLine("Started deserializing Trade");
    //        FCustomerId = Convert.ToInt32(info.GetValue("CustomerId", typeof(int)));
    //        FNumberOfShares = Convert.ToDouble(info.GetValue("NumberOfShares", typeof(double)));

    //        FEquityName = Convert.ToString(info.GetValue("EquityName", typeof(string)));

    //        FEquityPrice = Convert.ToDouble(info.GetValue("EquityPrice", typeof(double)));

    //        FCommission = Convert.ToDouble(info.GetValue("Commission", typeof(double)));

    //        FRepId = Convert.ToString(info.GetValue("RepId", typeof(string)));

    //        DateTime SerializedAt = (DateTime)info.GetValue("SerializedAt", typeof(DateTime));

    //        Debug.WriteLine(string.Format("{0} was serialized at {1}", this.GetType.Name(), SerializedAt));

    //        Debug.WriteLine("Finished deserializing Trade");
    //    }


    //    protected void GetObjectData(SerializationInfo info, StreamingContext context)
    //    {
    //        Console.WriteLine("Started serializing Trade");

    //        info.AddValue("CustomerId", FCustomerId);
    //        info.AddValue("NumberOfShares", FNumberOfShares);
    //        info.AddValue("EquityName", FEquityName);
    //        info.AddValue("EquityPrice", FEquityPrice);
    //        info.AddValue("Commission", FCommission);
    //        info.AddValue("RepId", FRepId);
    //        info.AddValue("SerializedAt", DateTime.Now);

    //        Console.WriteLine("Finished serializing Trade");
    //    }


    //    public int CustomerId
    //    {
    //        get { return FCustomerId; }
    //        set { FCustomerId = value; }
    //    }

    //    public double NumberOfShares
    //    {
    //        get { return FNumberOfShares; }
    //        set { FNumberOfShares = value; }
    //    }

    //    public string EquityName
    //    {
    //        get { return FEquityName; }
    //        set
    //        {
    //            Console.WriteLine("EquityName was {0}", FEquityName);
    //            FEquityName = value;
    //            Console.WriteLine("EquityName is {0}", FEquityName);
    //            Console.WriteLine(Assembly.GetExecutingAssembly().FullName);
    //        }
    //    }

    //    public double EquityPrice
    //    {
    //        get { return FEquityPrice; }
    //        set { FEquityPrice = value; }
    //    }

    //    public double Cost
    //    {
    //        get { return FEquityPrice * FNumberOfShares + FCommission; }
    //    }

    //    public double Commission
    //    {
    //        get { return FCommission; }
    //        set { FCommission = value; }
    //    }

    //    public string RepId
    //    {
    //        get { return FRepId; }
    //        set { FRepId = value; }
    //    }

    //}


}
