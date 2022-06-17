using System;
namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {
            switch (numberOfTires)
            {
                case 1:
                    return new UniCycle();
                case 2:
                    return new Motorcycle();
                case 3:
                    return new Tricycle();
                case 4:
                    return new Car();
                case 5:
                    return new CarWithSpare();
                default:
                    return new UniCycle();
            }
        }
    }
}
