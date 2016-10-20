using System;


namespace ConsoleApplication
{

    public interface Automobile<FuelType, ExhaustType>
    {
        ExhaustType Drive(FuelType fuel);
    }
    public interface Fuel<ExhaustType>
    {
        ExhaustType consume();
    }
    public interface Exhaust 
    {
        void Emit();
    }

    public class UnleadedGasoline<Exhaust> : Fuel<Exhaust> where Exhaust : new()
    {
        public Exhaust consume()
        {
            Console.WriteLine("...consuming unleaded gas...");
            return new Exhaust();
        }
    }
    public class CleanExhaust : Exhaust
    {
        public void Emit()
        {
            Console.WriteLine("...this is some clean exhaust...");
        }
    }
    public class Car : Automobile<UnleadedGasoline<CleanExhaust>, CleanExhaust>
    {
        public CleanExhaust Drive(UnleadedGasoline<CleanExhaust> fuel)
        {
            return fuel.consume();
        }
    }

    public interface Car1<T1> : Automobile<UnleadedGasoline<T1>, T1> where T1 : new()
    {

    }

    public class SimpleCar : Car1<CleanExhaust>
    {
        public CleanExhaust Drive(UnleadedGasoline<CleanExhaust> fuel)
        {
            return fuel.consume();
        }
    }

}