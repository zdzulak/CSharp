using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1.Models;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> cars = new List<Vehicle>();

            cars.Add(new Vehicle("Honda", "Civic", 2015, 4, 4));

            cars.Add(new Vehicle("Ford", "Model T", 1909, 4, 4));

            cars.Add(new Vehicle("BMW", "600", 1958, 4, 4));

            cars.Add(new Vehicle("Mazda", "Mazda 3", 2008, 4, 4));

            cars.Add(new Vehicle("Nissan", "GT-R", 2009, 4, 2));

            cars.Add(new Vehicle("Hyundai", "Elantra", 2013, 4, 4));

            cars.Add(new Vehicle("Mitsubishi", "Lancer", 2012, 4, 4));

            cars.Add(new Vehicle("Honda", "Accord", 2011, 4, 4));

            cars.Add(new Vehicle("Honda", "Pilot", 2010, 4, 4));

            cars.Add(new Vehicle("Chevrolet", "Corvette", 2005, 4, 2));

            cars.Add(new Vehicle("Honda", "Civic", 2006, 4, 4));

            cars.Add(new Vehicle("Ford", "Thunderbird", 1984, 4, 2));

            cars.Add(new Vehicle("BMW", "x5", 2008, 4, 4));

            cars.Add(new Vehicle("Mazda", "Mazda 5", 2007, 4, 4));

            cars.Add(new Vehicle("Nissan", "GT-R", 2019, 4, 2));

            cars.Add(new Vehicle("Hyundai", "Scoupe", 1992, 4, 2));

            cars.Add(new Vehicle("Mitsubishi", "Eclipse", 1998, 4, 4));

            cars.Add(new Vehicle("Honda", "Accord", 2004, 4, 4));

            cars.Add(new Vehicle("Honda", "Pilot", 2003, 4, 4));

            cars.Add(new Vehicle("Chevrolet", "Corvette", 1998, 4, 2));

            Console.WriteLine("Zackary Zulak");
            Console.WriteLine("0902917");

            /**
             * foreach loop that outputs all the cars in the list
             */
            foreach(Vehicle car in cars)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
