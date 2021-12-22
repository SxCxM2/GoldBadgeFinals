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
        private readonly PocosAndRepos _pocosAndRepos = new PocosAndRepos();

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
                Console.WriteLine("placeholdertext");

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
                        Console.WriteLine("pleaceholderText");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void CreateBadge()
        {
            int doorsCamelCase = 0;
            
            Console.WriteLine("placeholderText"); //ask for Badge Number
            int badgeNumber = Int16.Parse(Console.ReadLine());

            Console.WriteLine("placeholderText");
            string door = Console.ReadLine();
            _listOfRooms.Add(door);
            _pocosAndRepos.AddContentToDirectory(badgeNumber, _listOfRooms);
        }
        private void EditBadge()
        {

        }
        private void ShowBadges()
        {

        }
        private void InitialContent()
        {
            _badgeDictionary.AddContentToDirectory(1, );
            _badgeDictionary.AddContentToDirectory(2, );
            _badgeDictionary.AddContentToDirectory(3, );
        }
    }
}

