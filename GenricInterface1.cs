using System;


namespace ConsoleApplication
{

    public interface Automobile
    {
        ExhaustType Drive<FuelType,ExhaustType>(FuelType fuel);
    }
    public interface Fuel
    {
        ExhaustType consume<ExhaustType>() where ExhaustType : new();
    }
    // public interface Exhaust1
    // {
    //     void emit();
    // }

    // public class UnleadedGasoline : Fuel
    // {
    //     Exhaust Fuel.consume<Exhaust>() 
    //     {
    //         Console.WriteLine("...consuming unleaded gas...");
    //         return new Exhaust();
    //     }
    // }

    public class UnleadedGasoline: Fuel 
    {
        // public Exhaust consume() 
        // {
        //     Console.WriteLine("...consuming unleaded gas...");
        //     return new Exhaust();
        // }
        public Exhaust consume<Exhaust>() where Exhaust : new()
        {
            Console.WriteLine("...consuming unleaded gas...");
            return new Exhaust();
        }
    }

    public class Car2 : Automobile
    {


        public CleanExhaust Drive<UnleadedGasoline, CleanExhaust>(UnleadedGasoline fuel)
        {
            return fuel.consume<CleanExhaust>();
        }
    }
}