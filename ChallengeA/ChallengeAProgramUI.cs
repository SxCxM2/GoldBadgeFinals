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
                        CreateMenu();
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
        private void CreateMenu()
        {
            MenuContent content = new MenuContent();
            //
            Console.WriteLine("Please, enter the Meal Number.");
            content.MealNumber = Int32.Parse(Console.ReadLine());
            //
            Console.WriteLine("Please, enter the Meal Name.");
            content.MealName = Console.ReadLine();
            //
            Console.WriteLine($"Please, enter the description for {content.MealName}.");
            content.Description = Console.ReadLine();
            //
            Console.WriteLine($"Please, enter the price of {content.MealPrice}.");
            content.MealPrice = double.Parse(Console.ReadLine());
            //
            Console.WriteLine($"Please list the ingredients of {content.MealName}.");
            content.Ingredients = Console.ReadLine();
            _pocosAndRepos.AddItemToMenu(content);
            //
        }
        private void DisplayMenu(MenuContent content)
        {
            Console.WriteLine($"{content.MealNumber}\n" +
                $"Meal Name=> {content.MealName}\n" +
                $"Ingredients=> {content.Ingredients}\n" +
                $"Description=> {content.Description}\n" +
                $"Price=> {content.MealPrice}\n" +
                $"__________________________________________________________________");
        }
        private void ShowEntireMenu()
        {
            Console.Clear();
            List<MenuContent> menuContents = _pocosAndRepos.ViewItems();

            foreach (MenuContent content in menuContents)
            {
                DisplayMenu(content);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void DeleteMenuItems()
        {
            Console.WriteLine("Please, enter the item you would like to remove from the menu.");
            List<MenuContent> contentList = _pocosAndRepos.ViewItems();
            int count = 0;
            foreach (var content in contentList)
            {
                count++;
                Console.WriteLine($"{count} {content.MealName}");
            }
            int itemID = int.Parse(Console.ReadLine());
            int exactItem = itemID - 1;
            if (exactItem >= 0 && exactItem < contentList.Count)
            {
                MenuContent wantItem = contentList[exactItem];
                if (_pocosAndRepos.DeleteItemFromMenu(wantItem))
                {
                    Console.WriteLine($"{wantItem.MealName} has been removed from the menu.");
                }
                else
                {
                    Console.WriteLine("Cannot remove current item from the menu.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input\n" +
                    "Press any key to continue...");
                Console.ReadKey();
            }
        }
        private void InitialInfo()
        {
            var menuOne = new MenuContent();
            var menuTwo = new MenuContent();
            var menuThree = new MenuContent();
            var menuFour = new MenuContent();
            var menuFive = new MenuContent();

            _pocosAndRepos.AddItemToMenu(menuOne);
            _pocosAndRepos.AddItemToMenu(menuTwo);
            _pocosAndRepos.AddItemToMenu(menuThree);
            _pocosAndRepos.AddItemToMenu(menuFour);
            _pocosAndRepos.AddItemToMenu(menuFive);
        }
    }
}
