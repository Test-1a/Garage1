using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

namespace Garage1
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private Vehicle[] vehicles;
        public int maxCapacity;
        public string Name { get; set; }
        //public int Count => vehicles.Length;
        public int count;
        public bool isFull => count >= maxCapacity;

        public Garage(string name, int v)
        {
            Name = name;
            vehicles = new Vehicle[v];
            maxCapacity = v;
            count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            //iterates the WHOLE array, NOT only over the created cars!!!!!!!!
            //so if 3 cars are parked, item will be null on the fourth cycle
            foreach (T item in vehicles)
            {
                if (item != null)
                {
                    yield return item;
                }
                
                
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //private void ListParkedVehicles()
        //{
        //    foreach (var item in vehicles)
        //    {
        //        Console.WriteLine("In ListParkedVehicles: ");
        //        //PropertyInfo[] v = item.GetType().GetProperties();
        //        //for (int i = 0; i < v.Length; i++)
        //        //{
        //        //    // Console.WriteLine(v.GetValue());
        //        //    Console.WriteLine(item.RegNr);
        //        //    Console.WriteLine(item.Color);
        //        //    Console.WriteLine(item.NumberOfWheels);
        //        //}

        //        if (item is Car castItem)
        //        {
        //            Console.WriteLine("It Is a CAR!!");
        //            Console.WriteLine($"RegNr: {castItem.RegNr}");
        //            Console.WriteLine($"Color: {castItem.Color}");
        //            Console.WriteLine($"Antal hjul: {castItem.NumberOfWheels}");
        //            Console.WriteLine($"Fueltype: {castItem.Fueltype}");
        //        }
        //        else break;


                
        //        //Console.WriteLine("Vehical: " + );
        //    }
        //}

        internal void AddVehicle(Vehicle v1)
        {
            Console.WriteLine("In AddVehicle!");
            vehicles[count] = v1;
            count++;
        }

        internal Vehicle GetVehicle(int i)
        {
            return vehicles[i];
        }

        internal IEnumerable AskArray()
        {
            string s = "Red";
            var Q = vehicles.Where(v => v.Color.Equals(s));
            return Q;
        }

        //internal void RemoveVehicle(IEnumerable<Vehicle> v)
        internal void RemoveVehicle(Vehicle v)
        {
            Console.WriteLine("In RemoveVehicle!");
            
            int removeIndex = Array.IndexOf(vehicles, v);
            Console.WriteLine("Index = " + removeIndex);
            vehicles[removeIndex] = null;
            count = count -1;

            for (int i = removeIndex; i < count; i++)
            {
                vehicles[i] = vehicles[i + 1];
            }
        }
    }
}