//Rextester.Program.Main is the entry point for your code. Don't change it.
//Compiler version 4.0.30319.17929 for Microsoft (R) .NET Framework 4.5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fuelImp = new FuelImp<CleanExhaust>();
            var car = new Car();
            var easyCar = new EasyCar();
            car.drive(fuelImp);
            easyCar.drive(fuelImp);
        }

        public interface Automobile<F, E>
        {

            E drive(F fuel);
        }
        public interface Fuel<E>
        {

          E consume();
        }
        
           public interface Exhaust
           {
              
        }
        
        public class CleanExhaust  : Exhaust
        {}
        
        public class FuelImp<T> :  Fuel<T> where T : new()
        {
            public T consume() 
            {
            return new T();
            }
        }
        
        public interface Car<T1>: Automobile<FuelImp<T1>,T1> where T1: new()
        {
          
        }
        
        public class EasyCar: Car<CleanExhaust>
        {
          public CleanExhaust drive(FuelImp<CleanExhaust> fuel) {
              return fuel.consume();
          }
        }

        
        public class Car: Automobile<FuelImp<CleanExhaust>,CleanExhaust> 
        {
          public CleanExhaust drive(FuelImp<CleanExhaust> fuel) {
              return fuel.consume();
          }
        }
    }
}