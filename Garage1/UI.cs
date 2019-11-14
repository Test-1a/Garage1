using System;
using System.Collections.Generic;

namespace Garage1
{
    internal static class UI
    {
        private static GarageHandler GH/* = new GarageHandler()*/; 

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
            Console.WriteLine("'1' to park");
            Console.WriteLine("'2' to unpark");

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