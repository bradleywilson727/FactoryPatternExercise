using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var unicycle = new UniCycle();
            var motorcycle = new Motorcycle();
            var tricycle = new Tricycle();
            var car = new Car();
            var carWithSpare = new CarWithSpare();

            Console.WriteLine("How many tires would you like your vehicle to have? \nEnter a number 1 - 5.");
            int numberOfTires = Convert.ToInt16(Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(numberOfTires);
            vehicle.Drive();
            Console.ReadLine();
        }
    }
}