﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Garage1
{
    internal class GarageHandler
    {
        //private List<Garage<Vehicle>> garages;
        public static List<Garage<Vehicle>> Garages { get; set; }

        public GarageHandler()
        {
            Garages = new List<Garage<Vehicle>>();
        }

        public static void CreateGarage(string name, int capacity)
        {
            Garage<Vehicle> garra = new Garage<Vehicle>(name, capacity);
            Garages.Add(garra);
            
            PrintGarages();
            
        }

        internal static List<string> GetParkQuestions(string veh)
        {
            List<string> lista = new List<string>();
            lista.Add("What registration number does the vehicle have?");
            lista.Add("What color does the vehicle have?");
            lista.Add("What number of wheels does the vehicle have");
            if (veh == "Car") lista.Add("What fueltype do you use?");
            else if (veh == "MC") lista.Add("What cylinder volume do you have?");
            else if (veh == "Bus") lista.Add("How many seats do you have?");
            else if (veh == "Airplane") lista.Add("How many engines do you have?");
            else if (veh == "Boat") lista.Add("How long is your boat?");

            return lista;
        }

       
        internal static void ParkVehicle(List<string> parkAnswers)
        {
            Console.WriteLine("In ParkVehicle!");
            string vehicle = parkAnswers[0];
            string regNo = parkAnswers[1].ToUpper();
            string color = parkAnswers[2].ToUpper();
            string numOfWheels = parkAnswers[3];
            string unique = parkAnswers[4];

            //Garages[0].createVehicle(vehicle, regNo, color, numOfWheels, unique);
            if (vehicle == "Car")
            {
                bool gickBra = CreateCar(regNo, color, numOfWheels, unique);
                Console.WriteLine("GickBra: " + gickBra);
            }
            else if(vehicle == "MC")
            {
                bool gickBra = CreateMC(regNo, color, numOfWheels, unique);
                Console.WriteLine("GickBra: " + gickBra);
            }
            else if(vehicle == "Bus")
            {
                bool gickBra = CreateBus(regNo, color, numOfWheels, unique);
                Console.WriteLine("GickBra: " + gickBra);
            }
            else if (vehicle == "Airplane")
            {
                bool gickBra = CreateAirplane(regNo, color, numOfWheels, unique);
                Console.WriteLine("GickBra: " + gickBra);
            }
            else if (vehicle == "Boat")
            {
                bool gickBra = CreateBoat(regNo, color, numOfWheels, unique);
                Console.WriteLine("GickBra: " + gickBra);
            }
        }

        private static bool CreateBoat(string regNo, string color, string numOfWheels, string unique)
        {
            Console.WriteLine("In createVehicle, vehicle = Boat");

            if (Garages[0].isFull) return false;
            int num = int.Parse(numOfWheels);
            Boat boat1 = new Boat(regNo, color, num, unique);
            Garages[0].AddVehicle(boat1);

            ListAllParkedVehicles();
            return true;
        }

        
        private static bool CreateAirplane(string regNo, string color, string numOfWheels, string unique)
        {
            Console.WriteLine("In createVehicle, vehicle = Airplane");

            if (Garages[0].isFull) return false;
            int num = int.Parse(numOfWheels);
            Airplane a1 = new Airplane(regNo, color, num, unique);
            Garages[0].AddVehicle(a1);

            ListAllParkedVehicles();
            return true;
        }

        private static bool CreateBus(string regNo, string color, string numOfWheels, string unique)
        {
            Console.WriteLine("In createVehicle, vehicle = Bus");

            if (Garages[0].isFull) return false;
            int num = int.Parse(numOfWheels);
            Bus b1 = new Bus(regNo, color, num, unique);
            Garages[0].AddVehicle(b1);

            ListAllParkedVehicles();
            return true;
        }

        private static bool CreateMC(string regNo, string color, string numOfWheels, string unique)
        {
            Console.WriteLine("In createVehicle, vehicle = MC");

            if (Garages[0].isFull) return false;
            int num = int.Parse(numOfWheels);
            MC mc1 = new MC(regNo, color, num, unique);
            Garages[0].AddVehicle(mc1);

            ListAllParkedVehicles();
            return true;
        }


        private static bool CreateCar(string regNo, string color, string numOfWheels, string unique)
        {
            Console.WriteLine("In createVehicle, vehicle = Car");
            
            if (Garages[0].isFull) return false;
            int num = int.Parse(numOfWheels);
            Car c1 = new Car(regNo, color, num, unique);
            Garages[0].AddVehicle(c1);

            //int antal = Garages[0].count;
            //ListAllParkedVehicles(antal);
            ListAllParkedVehicles();
            return true;
        }

        public static void ListAllParkedVehicles()
        {
            Console.WriteLine("In ListAllParkedVehicles: ");

            int antal = Garages[0].count;

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
                else if(item is MC castItem2)
                {
                    Console.WriteLine("It Is a MC!!");
                    Console.WriteLine($"RegNr: {castItem2.RegNr}");
                    Console.WriteLine($"Color: {castItem2.Color}");
                    Console.WriteLine($"Antal hjul: {castItem2.NumberOfWheels}");
                    Console.WriteLine($"Cylinder Volume: {castItem2.cylinderVolume}");
                }
                else if (item is Bus castItem3)
                {
                    Console.WriteLine("It Is a Bus!!");
                    Console.WriteLine($"RegNr: {castItem3.RegNr}");
                    Console.WriteLine($"Color: {castItem3.Color}");
                    Console.WriteLine($"Antal hjul: {castItem3.NumberOfWheels}");
                    Console.WriteLine($"Number of seats: {castItem3.numberOfSeats}");
                }
                else if (item is Airplane castItem4)
                {
                    Console.WriteLine("It Is an Airplane!!");
                    Console.WriteLine($"RegNr: {castItem4.RegNr}");
                    Console.WriteLine($"Color: {castItem4.Color}");
                    Console.WriteLine($"Antal hjul: {castItem4.NumberOfWheels}");
                    Console.WriteLine($"Number of engines: {castItem4.numberOfEngines}");
                }
                else if (item is Boat castItem5)
                {
                    Console.WriteLine("It Is a Boat!!");
                    Console.WriteLine($"RegNr: {castItem5.RegNr}");
                    Console.WriteLine($"Color: {castItem5.Color}");
                    Console.WriteLine($"Antal hjul: {castItem5.NumberOfWheels}");
                    Console.WriteLine($"Length: {castItem5.length}");
                }
                else break;



                //Console.WriteLine("Vehical: " + );
            }
        }

        internal static string ChangeMaximumCapacity(int v)
        {
            string answerString = "";

            if(v < Garages[0].count)
            {
                Garages[0].MaxCapacity = Garages[0].count;
                answerString = "New value is smaller than number of cars in the garage, new value is set to the number of cars in the garage";

            }
            else
            {
                Garages[0].MaxCapacity = v;
                answerString = "Maximum capacity set to suggested value";
            }

            return answerString;
        }

        public static void PrintGarages()
        {
            foreach (var item in Garages)
            {
                System.Console.WriteLine($"Garage: {item.Name}");
            }
        }

        public static void ListAllParkedVehiclesAndEachKind()
        {
            ListAllParkedVehicles();

            //fungerar
            //foreach (var vehicle in Garages[0])
            //{
            //    Console.WriteLine(vehicle);
            //}

            //Console.WriteLine("Before LiNQ");
            //string ss = "RED";
            //string sss = "v.Color";
            ////var vehicleQuery =  Garages[0].Where(v => v.Color == "RED");
            //var vehicleQuery = Garages[0].Where(v => v.Color == ss);
            ////var vehicleQuery = Garages[0].Where(v => sss == ss);      //Funkar inte

            //foreach (var item in vehicleQuery)
            //{
            //    Console.WriteLine(item.RegNr);
            //}
            //Console.WriteLine("After LiNQ");

            //foreach (var item in Garages[0])
            //{
            //    int cCar = 0, cMC = 0, cBus = 0, cAirplane = 0, cBoat = 0;
            //    if (item is Car) cCar++;
            //    else if (item is MC) cMC++;
            //    else if (item is Bus) cBus++;
            //}

            var vehiclesPerType = from vehicle in Garages[0]
                                  group vehicle by vehicle.GetType().Name into vehicleGroup
                                  select new 
                                  {
                                      Type = vehicleGroup.Key,
                                      Count = vehicleGroup.Count(),
                                  };

            foreach (var item in vehiclesPerType)
            {
                Console.WriteLine(item);
            }
        }

        internal static IEnumerable<Vehicle> FindVehicleBasedOnRegNr(string input3)
        {
            var vehicleQuery = Garages[0].Where(v => v.RegNr == input3);

            return vehicleQuery;
        }
        internal static void UnParkVehicle(string input2)
        {
            //FirstOrDefault stops after first HIT and returns ONE vehicle
            //Where iterates over all of them and returns a list of vehicles
            string input2Upper = input2.ToUpper();
            var vehicleQuery = Garages[0].FirstOrDefault(v => v.RegNr == input2.ToUpper());
           
            //Garages[0] = Garages[0].Where(v => v.RegNr != input2Upper).ToArray();

            //int removeIndex = Array.IndexOf(Garages[0], vehicleQuery);

            //skickar enbart 1 vehicle
            Garages[0].RemoveVehicle(vehicleQuery);
        }


        internal static IEnumerable<Vehicle> FindVehicle(string v, string input41, string input42)
        {
            if (v == "Color")
            {
                var vehicleQuery = Garages[0].Where(v => v.Color == input41.ToUpper());
                return vehicleQuery;
            }
            else if (v == "Wheels")
            {
                var vehicleQuery = Garages[0].Where(v => v.NumberOfWheels == int.Parse(input41));
                return vehicleQuery;
            }
            else if (v == "Both")
            {
                var vehicleQuery = Garages[0].Where(v => v.Color == input41.ToUpper() && v.NumberOfWheels == int.Parse(input42));
                return vehicleQuery;
            }
            else return null;
        }
    }
}