using ArenaGameEngine;

namespace ArenaGameConsole
{
    class ConsoleGameEventListener : GameEventListener
    {
        public override void GameRound(Hero attacker, Hero defender, int attack)
        {
            string message = $"{attacker.Name} attacked {defender.Name} for {attack} points";
            if (defender.IsAlive)
            {
                message = message + $" but {defender.Name} survived.";
            }
            else
            {
                message = message + $" and {defender.Name} died.";
            }
            Console.WriteLine(message);
        }
        public override void GameRound2(Hero attackerB, Hero defenderB, int attack)
        {
            string message = $"{attackerB.Name} attacked {defenderB.Name} for {attack} points";
            if (defenderB.IsAlive)
            {
                message = message + $" but {defenderB.Name} survived.";
            }
            else
            {
                message = message + $" and {defenderB.Name} died.";
            }
            Console.WriteLine(message);
        }
    }

    
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight("Sir John");
            Rogue rogue = new Rogue("Slim Shady");
            Guardian guardian = new Guardian("Axel");
            Assassin assassin = new Assassin("Max");

            Arena arena = new Arena(knight, rogue);
            arena.EventListener = new ConsoleGameEventListener();
            NewArena arena2 = new NewArena(guardian, assassin);
            arena2.EventListener = new ConsoleGameEventListener();

            Console.WriteLine("Battle begins.");
            Hero winner = arena.Battle();
            Console.WriteLine($"Battle ended.  Winner is: {winner.Name} ,Enter for next battle");
            Console.ReadLine();
            Console.WriteLine("Second battle begins.");
            Hero winner2 = arena2.secondBattle();
            Console.WriteLine($"Battle ended. Winner is: {winner2.Name}");
            Console.ReadLine();

        }
    }
}
