using System;


namespace ConsoleApplication
{

    public interface Automobile
    {
        ExhaustType Drive<FuelType,ExhaustType>(FuelType fuel);where ExhaustType : new();
    }
    public interface Fuel
    {
        ExhaustType consume<ExhaustType>() where ExhaustType : new();
    }

    public class UnleadedGasoline : Fuel
    {
        public Exhaust consume<Exhaust>() where Exhaust : new()
        {
            Console.WriteLine("...consuming unleaded gas...");
            return new Exhaust();
        }
    }

    public class Car2 : Automobile
    {
        public CleanExhaust Drive<UnleadedGasoline, CleanExhaust>(UnleadedGasoline fuel) where CleanExhaust : new()
        {
            return  (fuel as Fuel).consume<CleanExhaust>();
        }
    }
}