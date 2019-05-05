using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class GumballMachine
    {
        IState _soldOutState;
        IState _noQuarterState;
        IState _hasQuarterState;
        IState _soldState;
        IState _currentState;

        int _count = 0;

        public GumballMachine(int gumballNumber)
        {
            _soldOutState = new SoldOutState(this);
            _noQuarterState = new NoQuarterState(this);
            _hasQuarterState = new HasQuarterState(this);
            _soldState = new SoldState(this);
            if (gumballNumber > 0)
                _currentState = _noQuarterState;
        }

        public void SetState(IState state)
        {
            _currentState = state;
        }

        public IState GetHasQuarterState
        {
            get
            {
                return _hasQuarterState;
            }
        }

        public IState GetSoldOutState
        {
            get
            {
                return _soldOutState;
            }
        }

        public IState GetNoQuarterState
        {
            get
            {
                return _noQuarterState;
            }
        }

        public IState GetSoldState
        {
            get
            {
                return _soldState;
            }
        }

        public IState GetCurrentState
        {
            get
            {
                return _currentState;
            }
        }
    }

    interface IState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TrunkCrank();
        void Dispense();
    }

    class NoQuarterState : IState
    {
        GumballMachine _gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.SetState(_gumballMachine.GetHasQuarterState);
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Cannot eject quarter. No quarter inserted");
        }
        
        public void TrunkCrank()
        {
            Console.WriteLine("Cannot turn crank. No quarter inserted");
        }

        public void Dispense()
        {
            Console.WriteLine("Cannot dispanse quarter. No quarter inserted");
        }
    }

    class SoldOutState : IState
    {
        GumballMachine _gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
           
        }

        public void EjectQuarter()
        {

        }

        public void TrunkCrank()
        {

        }

        public void Dispense()
        {

        }
    }

    class HasQuarterState : IState
    {
        GumballMachine _gumballMachine;
        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Cannot insert quarter. Quarter already inserted");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter ejected");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState);
        }

        public void TrunkCrank()
        {

        }

        public void Dispense()
        {

        }
    }

    class SoldState : IState
    {
        public SoldState(GumballMachine gumballMachine)
        {

        }

        public void InsertQuarter()
        {

        }

        public void EjectQuarter()
        {

        }

        public void TrunkCrank()
        {

        }

        public void Dispense()
        {

        }
    }

}
