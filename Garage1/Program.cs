using System;

namespace Garage1
{
    class Program
    {
        static void Main(string[] args)
        {
            GarageHandler GH = new GarageHandler();
            GH.CreateGarage("One", 250);
            GH.CreateGarage("Two", 350);
            UI.run();
        }
    }
}
