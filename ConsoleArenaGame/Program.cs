using System;
using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack, 2)} and caused {Math.Round(args.Damage, 2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }

        static Hero Battle(Hero heroA, Hero heroB)
        {
            GameEngine gameEngine = new GameEngine()
            {
                HeroA = heroA,
                HeroB = heroB,
                NotificationsCallBack = ConsoleNotification
            };

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
            Console.WriteLine();

            return gameEngine.Winner;
        }

        static void Main(string[] args)
        {
    
            Hero knight = new Knight("Knight", 10, 20, new Sword("Sword"));
            Hero assassin = new Assassin("Assassin", 10, 5, new Dagger("Dagger"));
            Hero wizard = new Wizard("Wizard", 10, 30, new MagicStaff("MagicStaff"));
            Hero goblin = new Goblin("Goblin", 20, 10, new Mace("Mace"));

            
            Console.WriteLine("First Battle: Assassin vs. Knight");
            Hero firstWinner = Battle(assassin, knight);

            
            Console.WriteLine("Second Battle: Goblin vs. Wizard");
            Hero secondWinner = Battle(goblin, wizard);
           
            Console.WriteLine($"Final Battle: {firstWinner.Name} vs. {secondWinner.Name}");
            Hero finalWinner = Battle(firstWinner, secondWinner);

            
            Console.WriteLine($"AreanaGame Champion: {finalWinner.Name}");
        }
    }
}


