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
                        //create a new garage
                        Console.WriteLine("What name should the Garage have?");
                        string input11 = Console.ReadLine();
                        Console.WriteLine("Which capacity should the garage have?");
                        string input12 = Console.ReadLine();
                        GarageHandler.CreateGarage(input11, int.Parse(input12));

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

                    case "7":
                        //Find a vehicles depending on its properties
                        Console.WriteLine("Which properties do you want to search for?");
                        Console.WriteLine("1. Color, 2. Number of wheels, 3. Both Color and Number of wheels");
                        string input4 = Console.ReadLine();
                        IEnumerable<Vehicle> ReturnedVehicles = null;
                        string empty = "";
                        switch (input4)
                        {
                            case "1":
                                Console.WriteLine("Which color do you want to search for?");
                                string input41 = Console.ReadLine();
                                ReturnedVehicles = GarageHandler.FindVehicle("Color", input41, empty);
                                break;

                            case "2":
                                Console.WriteLine("How many wheels do you want to search for?");
                                string input42 = Console.ReadLine();
                                ReturnedVehicles = GarageHandler.FindVehicle("Wheels", input42, empty);
                                break;

                            case "3":
                                Console.WriteLine("Which color do you want to search for?");
                                string input431 = Console.ReadLine();
                                Console.WriteLine("How many wheels do you want to search for?");
                                string input432 = Console.ReadLine();
                                ReturnedVehicles = GarageHandler.FindVehicle("Both", input431, input432);
                                break;

                            default:
                                break;
                        }
                        if(ReturnedVehicles != null)
                        {
                            foreach (var item in ReturnedVehicles)
                            {
                                PropertyInfo[] props = item.GetType().GetProperties();
                                Console.WriteLine(item.GetType().Name);
                                foreach (var prop in props)
                                {
                                    
                                    Console.WriteLine($"{prop.Name}: {prop.GetValue(item)}");

                                }
                                Console.WriteLine();
                            }
                        }
                        break;

                    case "8":
                        //change maximum capacity
                        Console.WriteLine("How many vehicles should the maximum capacity be changed to?");
                        string input8 = Console.ReadLine();
                        string answerBack = GarageHandler.ChangeMaximumCapacity(int.Parse(input8));
                        Console.WriteLine(answerBack);
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
            Console.WriteLine("'1' to create a new Garege");
            Console.WriteLine("'2' to park");
            Console.WriteLine("'3' to unpark");
            Console.WriteLine("'4' to list all parked vehicles");
            Console.WriteLine("'5' to list all parked vehicles and how manu of each kind");
            Console.WriteLine("'6' to list a specific vehicle based on its regNr");
            Console.WriteLine("'7' to search for a specific vehicle based on its properties");
            Console.WriteLine("'8' to change the maximum capacity of the garage");
            



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