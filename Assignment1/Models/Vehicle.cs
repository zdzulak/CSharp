using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    class Vehicle
    {
        Guid VehicleId;
        string Make;
        string Model;
        int Year;
        int NumberOfWheels;
        int NumberOfDoors;

        /// <summary>
        /// Method to give the vehicle properties values
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="wheelNum"></param>
        /// <param name="doorNum"></param>
        /// 
        /// <code>
        /// Vehicle car = (new Vehicle("Honda", "Civic", 2015, 4, 4));
        /// </code>
        public Vehicle(string make, string model, int year, int wheelNum, int doorNum)
        {
            /*
             *  making the inputted values equal to the car properties
             */
            Make = make;
            Model = model;
            Year = year;
            NumberOfWheels = wheelNum;
            NumberOfDoors = doorNum;
            // giving each car a unique ID
            VehicleId = Guid.NewGuid();
        }

        /// <summary>
        /// ToString for outputting the cars
        /// </summary>
        /// <returns></returns>
        /// 
        /// <code>
        /// 
        /// Vehicle car = (new Vehicle("Honda", "Civic", 2015, 4, 4));
        /// Console.WriteLine(car);
        /// 
        /// Honda Civic 2015
        /// # of Wheels: 4
        /// # of Doors: 4
        /// </code>
        /// 
        public override string ToString()
        {
            return $"{ Make } { Model }, { Year }\n" +
                $"# of Wheels: { NumberOfWheels }\n" +
                $"# of Doors: { NumberOfDoors }\n" +
                $"Vehicle ID: { VehicleId }\n";
        }
    }
}
