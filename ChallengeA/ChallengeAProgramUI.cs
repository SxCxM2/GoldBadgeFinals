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
                Console.ForegroundColor = ConsoleColor.White;
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
            var menuOne = new MenuContent(1, "Burger", "A juicy burger on sweet Hawaiian buns.", 3.50f, "2 beef patties, ketchup, mustard, mayonnaise, lettuce, red onions, and cheese.");
            var menuTwo = new MenuContent(2, "French Fries", "A hearty scoop of potato skins that are fried in a french way that is poatatoato skin  skins of the french variety.", 2.00f, "");
            var menuThree = new MenuContent(3, "6 Chicken Tenders", "6 crispy chicken tender strips.", 6.00f, "ingredients");
            var menuFour = new MenuContent(4, "12 Chicken Tenders", "12 crispy chicken tender strips.", 12.00f, "ingredients");
            var menuFive = new MenuContent(5, "Fish Sandwich", "This fried fish sandwich doesn't stray far from the classic fast-food staple: breaded fish, a soft bun, a slice of cheese and tangy tartar sauce.", 12.00f, "Breaded fish patty, soft sandwich buns, cheese, tartar sauce.");

            _pocosAndRepos.AddItemToMenu(menuOne);
            _pocosAndRepos.AddItemToMenu(menuTwo);
            _pocosAndRepos.AddItemToMenu(menuThree);
            _pocosAndRepos.AddItemToMenu(menuFour);
            _pocosAndRepos.AddItemToMenu(menuFive);
        }
    }
}
