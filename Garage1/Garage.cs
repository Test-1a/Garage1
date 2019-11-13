using System;
using System.Collections;
using System.Collections.Generic;

namespace Garage1
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public string Name { get; set; }
        private Vehicle[] vehicles;

        public Garage(string name, int v)
        {
            Name = name;
            vehicles = new Vehicle[v];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in vehicles)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        internal void createVehicle(string vehicle, string regNo, string color, string numOfWheels, string unique)
        {

            Console.WriteLine("In createVehicle!");
            Console.WriteLine("In createVehicle, vehicle = " + vehicle); 
            if (vehicle == "Car")
            {
                CreateCar(regNo, color, numOfWheels, unique);
            }
        }

        private void CreateCar(string regNo, string color, string numOfWheels, object unique)
        {
            ////Console.WriteLine("In CreateCar:");
            ////Console.WriteLine("RegNr: " + regNo);
            ////Console.WriteLine("Color: " + color);
            ////Console.WriteLine("Number of Wheels: " + numOfWheels);
            ////Console.WriteLine("Fueltype: "  + unique);

        }
    }
}