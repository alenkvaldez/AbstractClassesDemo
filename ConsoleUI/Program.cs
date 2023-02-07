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

            var vehicles = new List<vehicle>();



            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            var car1 = new car()
            {
                HasTrunk = true,
                Year = "2004",
                Make = "acura",
                Model = "RSX"
               
            };
            var motorcycle1 = new motorcycle()
            {
                HasSide = true,
                Year = "1997",
                Make = "yamaha",
                Model = "banshee",

            };
            vehicle vehicle1 = new car()
            {
                Year = "1995",
                Make = "BMW",
                Model = "750i"
            };
            vehicle vehicle2 = new motorcycle()
            {
                Year = "2003",
                Make = "dodge",
                Model = "tomahawk"
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"year: {vehicle.Year}");
                Console.WriteLine($"make: {vehicle.Year}");
                Console.WriteLine($"model: {vehicle.Year}");
                Console.WriteLine();
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine();
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
