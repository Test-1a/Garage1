using System;

namespace Garage1
{
    internal static class UI
    {
        public static void run()
        {
            while (true)
            {
                ShowMenu();
                string input = TryToReadInput();

                switch (input)
                {
                    case "0":
                        return;


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