using ChallengeARepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChallengeA
{
    public class ChallengeAProgramUI
    {
        private readonly MenuRepo _pocosAndRepos = new MenuRepo();
        public void Run()
        {
            InitialInfo();
            RunMenu();
        }
        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Clear();
                Console.WriteLine("\n\n [Welcome to the Cafe] \n\n" +
                    "Please select an option:\n" +
                    "1. Add Item to Menu\n" +
                    "2. View Entire Cafe Menu\n" +
                    "3. Delete Menu Items\n" +
                    "4. Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                        //add item
                        //display entire menu
                        //remove items from menu
                        //exit application
                    case "1":
                        CreateItem();
                        break;
                    case "2":
                        ShowEntireMenu();
                        break;
                    case "3":
                        DeleteMenuItems();
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, please select an option from 1-4.\n" +
                            "Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void CreateItem()
        {
            
        }
        private void ShowEntireMenu()
        {

        }
        private void DeleteMenuItems()
        {

        }

    }
}
