using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChallengeA
{
    public class ChallengeAProgramUI
    {
        private readonly PocosAndRepos _pocosAndRepos = new PocosAndRepos();
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
                Console.WriteLine();
            }
        }
    }
}
