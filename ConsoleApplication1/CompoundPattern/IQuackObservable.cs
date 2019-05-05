using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1.CompoundPattern
{
    //struct Demo
    //{
    //    internal Demo(int x)
    //    {
    //        List<int> list = new List<int>();
    //        list.ForEach(l => { Name = ""; });

    //    }

    //    internal string Name { get; set; }


    //struct Mutable
    //{
    //    private int x;
    //    public int Mutate()
    //    {
    //        this.x = this.x + 1;
    //        return this.x;
    //    }
    //}

    //class TestStruct
    //{
    //    public Mutable m = new Mutable();
    //    static void Main(string[] args)
    //    {
    //        TestStruct t = new TestStruct();
    //        System.Console.WriteLine(t.m.Mutate());
    //        System.Console.WriteLine(t.m.Mutate());
    //        System.Console.WriteLine(t.m.Mutate());
    //        Console.ReadLine();
    //    }
    //}

    public interface IObserver
    {
        void update(IQuackObservable observable);
    }

    class Quackologist : IObserver
    {
        IQuackObservable _observable;

        public Quackologist(IQuackObservable observable)
        {
            _observable = observable;
            _observable.RegisterObserver(this);
        }

        public void update(IQuackObservable duck)
        {
            Console.WriteLine("Quackologist: " + duck.GetType().Name + " just quacked.");
        }
    }

    class TestQuack
    {
        static void Main()
        {
            IQuackable duck = new QuackDecorator(new MallardDuck());
            IQuackable rubberDuck = new QuackDecorator(new RubberDuck());
            Flock flock = new Flock();
            flock.Add(duck);
            flock.Add(rubberDuck);
            Quackologist quack = new Quackologist(flock);
            flock.Quack();
            Console.WriteLine("Number of quacks: {0}",QuackDecorator._numberOfQuacks);
            Console.ReadKey();
        }
    }

    public interface IQuackObservable
    {
        void RegisterObserver(IObserver observer);
        void NotifyObeservers();
    }

    public interface IQuackable : IQuackObservable
    {
        void Quack();
    }

    public class Observable : IQuackObservable
    {
        ArrayList _arrayObserver = new ArrayList();
        IQuackObservable _duck;

        public Observable(IQuackObservable duck)
        {
            _duck = duck;
        }

        public void RegisterObserver(IObserver observer)
        {
            _arrayObserver.Add(observer);
        }

        public void NotifyObeservers()
        {
            foreach (IObserver observer in _arrayObserver)
            {
                observer.update(_duck);
            }
        }
    }

    public class MallardDuck : IQuackable
    {
        Observable _observable;

        public MallardDuck()
        {
            _observable = new Observable(this);
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObeservers()
        {
            _observable.NotifyObeservers();
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObeservers();
        }
    }

    public class RubberDuck : IQuackable
    {
        Observable _observable;

        public RubberDuck()
        {
            _observable = new Observable(this);
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObeservers()
        {
            _observable.NotifyObeservers();
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
            NotifyObeservers();
        }
    }

    public class QuackDecorator : IQuackable
    {
        IQuackable _observable;
        public static int _numberOfQuacks = 0;

        public QuackDecorator(IQuackable observable)
        {
            _observable = observable;
        }

        public void RegisterObserver(IObserver observer)
        {
            _observable.RegisterObserver(observer);
        }

        public void NotifyObeservers()
        {
            _observable.NotifyObeservers();
        }

        public void Quack()
        {
            _numberOfQuacks++;
            _observable.NotifyObeservers();
        }
    }

    public class Flock:IQuackable
    {
        List<IQuackable> listQuackable = new List<IQuackable>();

        public void Add(IQuackable quackable)
        {
            listQuackable.Add(quackable);
        }

        public void RegisterObserver(IObserver observer)
        {
             foreach(IQuackable getQuack in listQuackable)
             {
                 getQuack.RegisterObserver(observer);
             }
        }

        public void NotifyObeservers()
        {
            foreach (IQuackable getQuack in listQuackable)
            {
                getQuack.NotifyObeservers();
            }
        }

        public void Quack()
        {
            foreach (IQuackable getQuack in listQuackable)
            {
                getQuack.Quack();
            }
        }
    }


}

