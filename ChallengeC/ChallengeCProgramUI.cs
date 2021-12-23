using ChallengeCRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeC
{
    class ChallengeCProgramUI
    {
        PocosAndRepos _repo = new PocosAndRepos();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n\n Company BBQ Sales Tracker \n\n" +
                    "\n\n Please select an option:\n\n" +
                    "1. Bag of Popcorn\n" +
                    "2. Icecream\n" +
                    "3. HotDog\n" +
                    "4. Veggie Burger\n" +
                    "5. Hamburger\n" +
                    "6. Display Total Sale and Revenue\n" +
                    "7. Exit Application");

                string userInput = Console.ReadLine();
                Console.Clear();

                if (userInput == "1")
                {
                    //popcorn
                    _repo.PriceOfPopcorn++;
                }
                else if (userInput == "2")
                {
                    //icecream
                    _repo.PriceOfIceCream++;
                }
                else if (userInput == "3")
                {
                    //hotdog
                    _repo.PriceOfHotDog++;
                }
                else if (userInput == "4")
                {
                    //veggie
                    _repo.PriceOfVeggieBurger++;
                }
                else if (userInput == "5")
                {
                    //hamburger
                    _repo.PriceOfHamburger++;
                }
                else if (userInput == "6")
                {
                    PriceOfAllItems("Popcorn");
                    PriceOfAllItems("Icecream");
                    PriceOfAllItems("HotDog");
                    PriceOfAllItems("Veggie Burger");
                    PriceOfAllItems("Hamburger");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (userInput == "7")
                {
                    //exit
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Invalid input.\n" +
                        "Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        void PriceOfAllItems(string item_type)
        {
            if (item_type == "Popcorn")
            {
                Console.WriteLine("The Total amount made from Popcorn sold (" + _repo.PopcornBags + " units) is: $" + ((_repo.PopcornBags * _repo.PriceOfPopcorn) + (_repo.PopcornBags * _repo.PriceOfPackaging)));
            }
            else if (item_type == "Icecream")
            {
                Console.WriteLine("The Total amount made from Icecream sold (" + _repo.IceCream + " units) is: $"
                + ((_repo.IceCream * _repo.PriceOfIceCream) + (_repo.IceCream * _repo.PriceOfIceCream)));
            }
            else if (item_type == "HotDog")
            {
                Console.WriteLine("The Total amount made from Hotdogs sold (" + _repo.HotDogs + " units) is: $" + ((_repo.HotDogs * _repo.PriceOfHotDog) + (_repo.HotDogs * _repo.PriceOfHotDog)));
            }
            else if (item_type == "Veggie Burger")
            {
                Console.WriteLine("The Total amount made from Veggie Burgers sold (" + _repo.VeggieBurgers + " units) is: $" + ((_repo.VeggieBurgers * _repo.PriceOfVeggieBurger) + (_repo.VeggieBurgers * _repo.PriceOfVeggieBurger)));
            }
            else if (item_type == "Hamburger")
            {
                Console.WriteLine("The Total amount made from Hamburgers sold (" + _repo.Hamburgers + " units) is: $" + ((_repo.Hamburgers * _repo.PriceOfHamburger) + (_repo.Hamburgers * _repo.PriceOfHamburger)));
            }
            else
            {
                Console.WriteLine("Unknown Item: " + item_type);
            }
        }
    }
}