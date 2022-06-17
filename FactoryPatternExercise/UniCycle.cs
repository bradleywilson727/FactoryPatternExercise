using System;
namespace FactoryPatternExercise
{
    public class UniCycle : IVehicle
    {
        public UniCycle()
        { 
        }

        public void Drive()
        {
            Console.WriteLine("Building your Unicycle!");
        }
    }
}
