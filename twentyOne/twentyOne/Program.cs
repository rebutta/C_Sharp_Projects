using System;
using System.IO;
using TheCasino;
using TheCasino.twentyOne;

namespace twentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";
            Console.WriteLine("Welcome to the the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 Right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" ||answer == "yeah" || answer == "y" || answer == "ya" || answer == "sure")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\Oconn\Documents\log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TheCasino.twentyOne.TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the Casino. Bye for now.");
            Console.ReadLine();
        }
    }
}
