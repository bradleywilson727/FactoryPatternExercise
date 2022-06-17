using System;
namespace FactoryPatternExercise
{
    public class Tricycle : IVehicle
    {
        public Tricycle()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Building your Tricycle!");
        }
    }
}
