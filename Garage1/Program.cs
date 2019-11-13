using System;

namespace Garage1
{
    class Program
    {
        static void Main(string[] args)
        {
            GarageHandler GH = new GarageHandler();
            GH.CreateGarege("One", 250);
            GH.CreateGarege("Two", 350);
            GH.PrintGarages();
            //Garage<Vehicle> garageOne = new Garage<Vehicle>(250);
            UI.run();
        }
    }
}
