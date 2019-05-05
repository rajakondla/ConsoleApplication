using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Beverage
    {
        protected abstract string Description
        {
            get;
        }

        protected abstract double Cost
        {
            get;
        }

        public string GetBeverageDesctription
        {
            get => Description;
        }

        public double GetCost
        {
            get => Math.Round(Cost + (Cost * 0.07),2);
        }
    }

    public class HouseBlend : Beverage
    {
        protected override string Description
        {
            get => "House Blend";
        }

        protected override double Cost
        {
            get => 0.1;
        }
    }

    public abstract class Condiment:Beverage
    {

    }

    public class Mocha:Condiment
    {
        Beverage _beverage;

        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        protected override string Description
        {
            get => _beverage.GetBeverageDesctription+" with Mocha";
        }

        protected override double Cost
        {
            get => _beverage.GetCost + 0.2; 
        }
    }

    public class Milk : Condiment
    {
        Beverage _beverage;

        public Milk(Beverage beverage)
        {
            _beverage = beverage;
        }

        protected override string Description
        {
            get => _beverage.GetBeverageDesctription + " with Milk";
        }

        protected override double Cost
        {
            get => _beverage.GetCost + 0.2;
        }
    }

    public class TestDecorator
    {
        static void Main()
        {
            HouseBlend houseBlendObj = new HouseBlend();
            Mocha mochaObj = new Mocha(houseBlendObj);
            Milk milkObj = new Milk(mochaObj);

            Console.WriteLine(milkObj.GetBeverageDesctription);
            Console.WriteLine("Total order cost = {0} ¢",milkObj.GetCost);

            Console.ReadLine();
        }
    }
}
