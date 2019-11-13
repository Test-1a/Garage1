using System;
using System.Collections.Generic;

namespace Garage1
{
    internal class GarageHandler
    {
        //private List<Garage<Vehicle>> garages;
        public List<Garage<Vehicle>> Garages { get; set; } 
        
        public GarageHandler()
        {
            Garages = new List<Garage<Vehicle>>();
        }

        public void CreateGarage(string name, int capacity)
        {
            Garage<Vehicle> garra = new Garage<Vehicle>(name, capacity);
            Garages.Add(garra);

        }

        internal static List<string> GetGarageNames()
        {
            List<string> LS = new List<string>();
            //foreach (var item in Garages)
            //{
            //    LS.Add(item.Name);
            //}
            return LS;
        }

        public void PrintGarages()
        {
            foreach (var item in Garages)
            {
                System.Console.WriteLine($"Garage: {item.Name}");
            }
        }
    }
}