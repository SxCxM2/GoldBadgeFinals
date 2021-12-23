using ChallengeBRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeB
{
    public class ChallengeBProgramUI
    {
        private readonly BadgeRepository _badgeRepository = new BadgeRepository();

        public Dictionary<int, string> _badgeDictionary = new Dictionary<int, string>();
        public List<string> _listOfRooms = new List<string>();

        public void Run()
        {
            InitialContent();
            RunMenu();
        }
        public void RunMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("\n\n BADGE SECURITY \n\n" +
                    "Please select an option by entering a number displayed below:\n" +
                    "1. Create New Badge\n" +
                    "2. Edit Existing Badge\n" +
                    "3. View All Existing Badges\n" +
                    "4. Exit Application");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //new user and badge access
                        CreateBadge();
                        break;
                    case "2":
                        //badge abilities (add, update, delete)
                        EditBadge();
                        break;
                    case "3":
                        //show all badges
                        ShowBadges();
                        break;
                    case "4":
                        //exit application
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("placeholderText");
                        Console.ReadKey();
                        break;
                }
            }

        }

        private void CreateBadge()
        {
            int someCamelCase = 0;

            Console.WriteLine("Enter New Badge Number.\n");
            int badgeNumber = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter an access point for this particular Badge.\n");
            string door = Console.ReadLine();
            _listOfRooms.Add(door);
            _badgeRepository.AddBadgeToDirectory(badgeNumber, _listOfRooms);

            do
            {
                Console.WriteLine("Would you like to add another door? enter 1 for yes, and 2 for no.");
                string userInput = Console.ReadLine();
                if (userInput == "1")
                {
                    Console.WriteLine("Enter another access point for this particular Badge.\n");
                    door = Console.ReadLine();
                    _listOfRooms.Add(door);
                    someCamelCase = 0;
                }
                else if (userInput == "2")
                {
                    someCamelCase = 1;
                }
                else
                {
                    Console.WriteLine("Invalid input...\n" +
                        "..............Press any key to continue..............");
                }
            }
            while (someCamelCase == 0);
        }
        private void ShowBadges()
        {
            Console.Clear();
            Dictionary<int, List<string>> listOfBadges = _badgeRepository.GetContents();

            Console.WriteLine("Key Badge ID__________Door Access\n" +
                "________________________________________________________________________________");
            foreach (KeyValuePair<int, List<string>> badges in listOfBadges)
            {
                foreach (string badgeString in badges.Value)
                {
                    Console.WriteLine(" {0},        {1}", badges.Key, badgeString);
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        private void EditBadge()
        {
            Console.WriteLine("Enter the badge number that needs updating:");
            int badgeUpdate = Int32.Parse(Console.ReadLine());
            List<string> allDoors = _badgeRepository.GetDoorsByKey(badgeUpdate);

            foreach (string door in allDoors)
            {
                Console.WriteLine("Badge Number ____ has access to ____", badgeUpdate, door);
            }
            Console.WriteLine
                ("Please select an option:\n" +
                "1. Remove a door\n" +
                "2. Add a door\n" +
                "3. Delete all doors for BadgeID");

            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput == 1) //remove
            {
                Console.WriteLine("Enter door you would like to remove:");
                string door = Console.ReadLine();
                allDoors.Remove(door);
                Console.WriteLine("Door ____ is not associated with BadgeID anymore.");
                Console.ReadLine();
            }
            else if (userInput == 2) //add
            {
                Console.WriteLine("Enter the door you would like to add?");
                string newDoor = Console.ReadLine();
                allDoors.Add(newDoor);
                Console.WriteLine("Door ____ is now associated with BadgeID", newDoor, badgeUpdate);
                Console.ReadLine();
            }
            else if (userInput == 3) //delete
            {
                int removeAllDoors = Math.Max(0, allDoors.Count);
                allDoors.RemoveRange(0, removeAllDoors);
                Console.WriteLine("All doors that are associated with this particular Badge have been removed", badgeUpdate);
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
        }
        private void InitialContent()
        {
            List<string> _firstList = new List<string>();
            _firstList.Add("A1");
            _firstList.Add("A2");
            _firstList.Add("A3");
            _firstList.Add("A4");
            _firstList.Add("A5");
            _firstList.Add("A6");

            List<string> _secondList = new List<string>();
            _secondList.Add("B1");
            _secondList.Add("B2");
            _secondList.Add("B3");
            _secondList.Add("B4");
            _secondList.Add("B5");
            _secondList.Add("B6");

            List<string> _thirdList = new List<string>();
            _thirdList.Add("C1");
            _thirdList.Add("C2");
            _thirdList.Add("C3");
            _thirdList.Add("C4");
            _thirdList.Add("C5");
            _thirdList.Add("C6");

            List<string> _fourthList = new List<string>();
            _fourthList.Add("D1");
            _fourthList.Add("D2");
            _fourthList.Add("D3");
            _fourthList.Add("D4");
            _fourthList.Add("D5");
            _fourthList.Add("D6");

            _badgeRepository.AddBadgeToDirectory(1, _firstList);
            _badgeRepository.AddBadgeToDirectory(2, _secondList);
            _badgeRepository.AddBadgeToDirectory(3, _thirdList);
            _badgeRepository.AddBadgeToDirectory(4, _fourthList);
        }
    }
}

