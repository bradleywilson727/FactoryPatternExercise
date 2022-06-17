using System;
namespace FactoryPatternExercise
{
    public class CarWithSpare : IVehicle
    {
        public CarWithSpare()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Building your Car and including a spare tire!");
        }
    }
}
