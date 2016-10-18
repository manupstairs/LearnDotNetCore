using System;

namespace ConsoleApplication
{
    class Program
    {
        public static void Main(string[] args)
        {
            var gaso = new UnleadedGasoline<CleanExhaust>();
            var car = new Car();
            car.Drive(gaso).Emit();

            var simpleCar = new SimpleCar();
            simpleCar.Drive(gaso).Emit();
            
            var fuel = new UnleadedGasoline();
            var car2 = new Car2();
            car2.Drive<UnleadedGasoline,CleanExhaust>(fuel).Emit();
        }
    }
}