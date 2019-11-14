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

            //Garages[0].createVehicle(vehicle, regNo, color, numOfWheels, unique);
            if (vehicle == "Car")
            {
                bool gickBra = CreateCar(regNo, color, numOfWheels, unique);
                Console.WriteLine("GickBra: " + gickBra);
            }
        }

        private static bool CreateCar(string regNo, string color, string numOfWheels, string unique)
        {
            Console.WriteLine("In createVehicle, vehicle = Car");
            //Console.WriteLine("In CreateCar:");
            //Console.WriteLine("RegNr: " + regNo);
            //Console.WriteLine("Color: " + color);
            //Console.WriteLine("Number of Wheels: " + numOfWheels);
            //Console.WriteLine("Fueltype: "  + unique);
            if (Garages[0].isFull) return false;
            int num = int.Parse(numOfWheels);
            Car c1 = new Car(regNo, color, num, unique);
            Garages[0].AddCar(c1);

            int antal = Garages[0].count;
            ListParkedVehicles(antal);
            return true;
        }

        private static void ListParkedVehicles(int antal)
        {
            Console.WriteLine("In ListParkedVehicles: ");

            //foreach (var item in Garages[0].vehicles)
            for (int i = 0; i < antal; i++)
            {
                //PropertyInfo[] v = item.GetType().GetProperties();
                //for (int i = 0; i < v.Length; i++)
                //{
                //    // Console.WriteLine(v.GetValue());
                //    Console.WriteLine(item.RegNr);
                //    Console.WriteLine(item.Color);
                //    Console.WriteLine(item.NumberOfWheels);
                //}

                Vehicle item = Garages[0].GetVehicle(i);

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

        public void PrintGarages()
        {
            foreach (var item in Garages)
            {
                System.Console.WriteLine($"Garage: {item.Name}");
            }
        }
    }
}