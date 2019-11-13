using System.Collections.Generic;

namespace Garage1
{
    internal class GarageHandler
    {
        private List<Garage<Vehicle>> garages;
        public List<Garage<Vehicle>> Garages { get; set; } 
        
        public GarageHandler()
        {
            Garages = new List<Garage<Vehicle>>();
        }

        public void CreateGarege(string name, int capacity)
        {
            Garage<Vehicle> garra = new Garage<Vehicle>(name, capacity);
            Garages.Add(garra);

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