using System;
using System.Collections.Generic;

namespace Garage1
{
    internal  class GarageHandler
    {
        //private List<Garage<Vehicle>> garages;
        public static List<Garage<Vehicle>> Garages { get; set; }
        
        public GarageHandler()
        {
            Garages = new List<Garage<Vehicle>>();
        }

        public void CreateGarage(string name, int capacity)
        {
            Garage<Vehicle> garra = new Garage<Vehicle>(name, capacity);
            Garages.Add(garra);

        }

        internal static List<string> GetParkQuestions(string veh)
        {
            List<string> lista = new List<string>();
            if (veh == "Car") lista = GetCarParkQuestions();
            else if (veh == "MC") lista = GetMcParkQuestions();
            else if (veh == "Bus") lista = GetBusParkQuestions();
            else if (veh == "Airplane") lista = GetAirParkQuestions();
            else if (veh == "Boat") lista = GetBoatParkQuestions();

            return lista;
        }

        private static List<string> GetBoatParkQuestions()
        {
            throw new NotImplementedException();
        }

        private static List<string> GetAirParkQuestions()
        {
            throw new NotImplementedException();
        }

        private static List<string> GetBusParkQuestions()
        {
            throw new NotImplementedException();
        }

        private static List<string> GetMcParkQuestions()
        {
            throw new NotImplementedException();
        }

        private static List<string> GetCarParkQuestions()
        {
            List<string> LS = new List<string>();
            LS.Add("What registration number does the vehicle have?");
            LS.Add("What color does the vehicle have?");
            LS.Add("What number of wheels does the vehicle have");
            LS.Add("What fueltype do you use?");

            return LS;
        }

        internal static void ParkVehicle(List<string> parkAnswers)
        {
            Console.WriteLine( "In ParkVehicle!");
            string vehicle = parkAnswers[0];
            string regNo = parkAnswers[1];
            string color = parkAnswers[2];
            string numOfWheels = parkAnswers[3];
            string unique = parkAnswers[4];

            Garages[0].createVehicle(vehicle, regNo, color, numOfWheels, unique);
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