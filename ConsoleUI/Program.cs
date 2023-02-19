using System;
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
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();



            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - set them up as one of each derived class
             * Set the properties with object initializer syntax
             */
            var ford = new Car();
            ford.Make = "Ford";
            ford.Year = "2023";
            ford.Model = "Mustang";
            ford.HasTrunk= true;

            var harley = new Motorcycle();
            harley.Year = "2021";
            harley.Model = "Harley";
            harley.Make = "Fatboy";
            harley.HasSideCart= true;

            Vehicle vehicle1 = new Car();
            vehicle1.Make = "Chevy";
            vehicle1.Year = "2020";
            vehicle1.Model = "Tahoe";
            
            Vehicle motorcycle1 = new Motorcycle();
            motorcycle1.Year = "2019";
            motorcycle1.Model = "Crotch Rocket";
            motorcycle1.Make = "Susuki";


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            vehicles.Add(ford);
            vehicles.Add(harley);
            vehicles.Add(vehicle1);
            vehicles.Add(motorcycle1);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.Model} {vehicle.Make} {vehicle.Year}");
            }
            // Call each of the drive methods for one car and one motorcycle
            harley.DriveVirtual();
            harley.DriveAbstract();

                #endregion
            Console.ReadLine();
        }
    }
}
