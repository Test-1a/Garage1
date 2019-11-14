using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Garage1
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public string Name { get; set; }
        private Vehicle[] vehicles;
        private int count;

        public Garage(string name, int v)
        {
            Name = name;
            vehicles = new Vehicle[v];
            count = 0;
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

        private void CreateCar(string regNo, string color, string numOfWheels, string unique)
        {
            //Console.WriteLine("In CreateCar:");
            //Console.WriteLine("RegNr: " + regNo);
            //Console.WriteLine("Color: " + color);
            //Console.WriteLine("Number of Wheels: " + numOfWheels);
            //Console.WriteLine("Fueltype: "  + unique);
            int num = int.Parse(numOfWheels);
            Car c1 = new Car(regNo, color, num, unique);
            vehicles[count] = c1;
            count++;

            ListParkedVehicles();
        }

        private void ListParkedVehicles()
        {
            foreach (var item in vehicles)
            {
                Console.WriteLine("In ListParkedVehicles: ");
                //PropertyInfo[] v = item.GetType().GetProperties();
                //for (int i = 0; i < v.Length; i++)
                //{
                //    // Console.WriteLine(v.GetValue());
                //    Console.WriteLine(item.RegNr);
                //    Console.WriteLine(item.Color);
                //    Console.WriteLine(item.NumberOfWheels);
                //}

                if (item is Car castItem)
                {
                    Console.WriteLine("It Is a CAR!!");
                    Console.WriteLine($"RegNr: {castItem.RegNr}");
                    Console.WriteLine($"Color: {castItem.Color}");
                    Console.WriteLine($"Antal hjul: {castItem.NumberOfWheels}");
                    Console.WriteLine($"Fueltype: {castItem.Fueltype}");
                }
                else break;


                
                //Console.WriteLine("Vehical: " + );
            }
        }
    }
}