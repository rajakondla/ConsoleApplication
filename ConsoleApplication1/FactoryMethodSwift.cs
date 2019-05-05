using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    // step 1 for car color and car type
    public enum CarColor { Red,Orange,Green};
    public enum SwiftCarType { Basic,Featured};
    // step 2 abstract class for creating data and function for fixing car price
    public abstract class SwiftCar
    {
        /// <summary>
        /// color of the Swift car
        /// </summary>
        public CarColor Color 
        { 
            get; 
            private set;
        }
       
        protected SwiftCar(CarColor color)
        {
            this.Color = color;
        }

        /// <summary>
        /// function that calculates the price
        ///  of the swift car
        /// </summary>
        /// <returns></returns>
        public abstract float CaliculatePrice();
    }
    // step 3 for calculating basic type car price
    /// <summary>
    /// the basic swift car
    /// </summary>
    public class SwiftCarBasic : SwiftCar
    {
        /// <summary>
        /// creates a basic swift car of defined color
        /// </summary>
        /// <param name="color">the color requested by the client</param>
        public SwiftCarBasic(CarColor color): base(color)
        {

        }
        /// <summary>
        /// customised calculation of price
        /// </summary>
        /// <returns> the price of the basic model of swift car</returns>
        public override float CaliculatePrice()
        {
            float BasicPrice = 400000F;
            return BasicPrice;
        }
    }
    // stpe 4 for calculating featured type car price
    /// <summary>
    /// The swift car with additional features
    /// </summary>
    public class SwiftCarFeatured : SwiftCar
    {
        /// <summary>
        /// Creates a Featured swift car with a color requested by the client
        /// </summary>
        /// <param name="Color">the color of the featured swift car</param>
        public SwiftCarFeatured(CarColor Color): base(Color)
        {

        }
        /// <summary>
        /// customised calculation of the car with additional features such as airbags,speakers power window etc
        /// </summary>
        /// <returns></returns>
        public override float CaliculatePrice()
        {
            float basicPrice = 400000F;
            float otherEquipmentCosts = 200000F;
            return basicPrice + otherEquipmentCosts;
        }
    }
    // step 5 is for creating factory method 
    /* Understand below class as a factory
     * In factory cars are to be manufactured with different color and type
     * Client or User need not have to know how cars are made
     * So this factory method used to hide the creation of cars and this method takes care of creating objects
     */
    public static class SwiftCarFactory
    {
        /// <summary>
        /// The method creates a swift car as desired by the consumer
        /// </summary>
        /// <param name="carType"> the car type specified by the Consumer</param>
        /// <param name="carColor"> the color  of the car specified by the consumer </param>
        /// <returns> the desired swift car</returns>
        public static SwiftCar CreateSwiftCar(SwiftCarType carType, CarColor carColor)
        {
            SwiftCar car = null;

            switch (carType)
            {
                case SwiftCarType.Basic: car = new SwiftCarBasic(carColor);
                    break;
                case SwiftCarType.Featured: car = new SwiftCarFeatured(carColor);
                    break;
            }
            return car;
        }
    }
    // step 5 is to call the factory method by passing enum [SwiftCarType] and enum [CarColor]
    // then corresponding car objects are created
    // then using those objects we can call car color and price
    /// <summary>
    /// Client to Consume a Swift Car from the Swift Car Factory
    /// </summary>
    class ClientClass
    {
        public static void Main(string[] args)
        {
            //the basic Swift car of Blue color -Creation
            // swift car is a base class and is used as reference to child class
            SwiftCar BlueBasicSwiftCar = SwiftCarFactory.CreateSwiftCar(SwiftCarType.Basic, CarColor.Green);

            // as child class object is refering to base class. we can call child class method using base class reference
            //Computation of Price
            float BlueBasicSwiftCarPrice = BlueBasicSwiftCar.CaliculatePrice();
            Console.WriteLine("price of {0} Basic Swift car: {1}",(int)BlueBasicSwiftCar.Color, BlueBasicSwiftCarPrice);

            //the Red Featured Swift car of Blue color -Creation
            SwiftCar RedFeaturedSwiftCar = SwiftCarFactory.CreateSwiftCar(SwiftCarType.Featured, CarColor.Red);

            // Computation of Price
            float RedFeaturedSwiftCarPrice = RedFeaturedSwiftCar.CaliculatePrice();
            Console.WriteLine("price of {0} Featured Swift car: {1}", (int)RedFeaturedSwiftCar.Color, RedFeaturedSwiftCarPrice);
        }
    }
}
