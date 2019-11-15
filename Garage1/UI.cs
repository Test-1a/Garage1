using System;
using System.Collections.Generic;
using System.Reflection;

namespace Garage1
{
    internal static class UI
    {
       // private static GarageHandler GH/* = new GarageHandler()*/; 

        public static void run()
        {
            while (true)
            {
                ShowMenu();
                string input = TryToReadInput();
                List<string> parkAnswers = new List<string>();

                switch (input)
                {
                    case "0":
                        return;

                    case "1":
                        //Create a garage
                        break;

                    case "2":
                        //Park a vehicle
                        Console.WriteLine("what kind of vehicle do you want to park?");
                        Console.WriteLine("'1':Car, '2': MC, '3':Bus, '4':Airplane, '5':Boat");
                        string answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "1":
                                parkAnswers.Add("Car");
                                break;

                            case "2":
                                parkAnswers.Add("MC");
                                break;

                            case "3":
                                parkAnswers.Add("Bus");
                                break;

                            case "4":
                                parkAnswers.Add("Airplane");
                                break;

                            case "5":
                                parkAnswers.Add("Boat");
                                break;

                            default:
                                Console.WriteLine("Please choose something!");
                                break;

                        }

                        List<string> parkQuestions = GarageHandler.GetParkQuestions(parkAnswers[0]);

                        foreach (var q in parkQuestions)
                        {
                            Console.WriteLine(q);
                            parkAnswers.Add(Console.ReadLine());

                        }
                        GarageHandler.ParkVehicle(parkAnswers);
                        break;

                    case "3":
                        //Unpark a vehicle
                        Console.WriteLine("What is the RegNr on the vehicle that you want to unpark?");
                        string input2 = Console.ReadLine();
                        GarageHandler.UnParkVehicle(input2);
                        break;

                    case "4":
                        //print all parked vehicles
                        GarageHandler.ListAllParkedVehicles();
                        break;

                    case "5":
                        GarageHandler.ListAllParkedVehiclesAndEachKind();
                        break;

                    case "6":
                        //List a specific vehicle based on its regNr
                        Console.WriteLine("What is the Reg Nr?");
                        string input3 = Console.ReadLine().ToUpper();
                         IEnumerable<Vehicle> ie = GarageHandler.FindVehicleBasedOnRegNr(input3);
                        foreach (var item in ie)
                        {
                            PropertyInfo[] props = item.GetType().GetProperties();
                            foreach (var prop in props)
                            {
                                Console.WriteLine($"{prop.Name}: {prop.GetValue(item)}");

                            }
                            Console.WriteLine();
                        }
                        break;

                    default:
                        break;
                }
            }

        }

        private static void ShowMenu()
        {
            Console.WriteLine("Hi and welcome to the GarageHandlers!");
            Console.WriteLine("What do you want to to?");
            Console.WriteLine("'0' to end this program");
            Console.WriteLine("'1' to create a Garege");
            Console.WriteLine("'2' to park");
            Console.WriteLine("'3' to unpark");
            Console.WriteLine("'4' to list all parked vehicles");
            Console.WriteLine("'5' to list all parked vehicles and how manu of each kind");
            Console.WriteLine("'6' to list a specific vehicle based on its regNr");



        }

        public static string TryToReadInput()
        {
            string input = "";

            try
            {
                input = Console.ReadLine();
                //firstLetter = answer[0];
            }
            catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
            {
                Console.Clear();
                Console.WriteLine("Please enter some input!");
            }

            return input;
        }


    }
}