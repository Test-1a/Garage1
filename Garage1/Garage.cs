﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace Garage1
{
    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private Vehicle[] vehicles;
        private int maxCapacity;
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
            foreach (T item in vehicles)
            {
                yield return item;
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

        internal void AddCar(Car c1)
        {
            Console.WriteLine("In AddCar!");
            vehicles[count] = c1;
            count++;
        }

        internal Vehicle GetVehicle(int i)
        {
            return vehicles[i];
        }
    }
}