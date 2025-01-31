﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle DONE
             * The vehicle class shall have three string properties Year, Make, and Model DONE
             * Set the defaults to something generic in the Vehicle class DONE
             * Vehicle shall have an abstract method called DriveAbstract with no implementation DONE
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation. DONE
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle DONE 
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle DONE
             * Provide the implementations for the abstract methods DONE
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var car = new Car();
            car.Year = "2005";
            car.Make = "Honda";
            car.Model = "Civic";

            var motorcycle = new Motorcycle();
            motorcycle.Year = "2019";
            motorcycle.Make = "Harley Davidson";
            motorcycle.Model = "Sportster S";

            var vehicle1 = new Car();
            vehicle1.Year = "2001";
            vehicle1.Make = "Mitsubishi";
            vehicle1.Model = "Evolution";

            var vehicle2 = new Motorcycle();
            vehicle2.Year = "2022";
            vehicle2.Make = "Kawasaki";
            vehicle2.Model = "Ninja";

            List<Vehicle> Vehicles = new List<Vehicle>();

            Vehicles.Add(vehicle1);
            Vehicles.Add(vehicle2);
            Vehicles.Add(car);
            Vehicles.Add(motorcycle);

            foreach (var vehicle in Vehicles)
            {
                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model}");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
            }
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
