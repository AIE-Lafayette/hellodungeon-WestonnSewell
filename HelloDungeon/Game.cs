using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            // Initializes player stats
            string playerName = "Jim";
            float testFloat = 3.2f;
            float hp = 10f;
            float atk = 10f;
            float mp = 5f;
            int areaNumber = 0;
            bool playerIsAlive = hp > 0;
            // print out name for player
            Console.WriteLine("Weston");
            Console.WriteLine("Sewell");
            // get input from palyer for first and last name
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();

            playerName = firstName + lastName;
            // display character name for mplayer feedback
            Console.WriteLine("Hello " + playerName + " to me games");
            // dialogue 1
            Console.WriteLine("You run into a strange man.");
            Console.WriteLine("He offers you a strange bottle of green fluid.");
            Console.WriteLine("Take it..?");

            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            // choices and answers 1
            string playerChoice = Console.ReadLine();

            if (playerChoice == "1");
            {
                Console.WriteLine("Tastes like an apple.");
                Console.WriteLine("Your skin hardens and you gain 5 HP.");
                hp += 5;
            }

            if (playerChoice == "2");
            {
                Console.WriteLine("You decline the offer.");
                Console.WriteLine("You feel oddly awful for this.");
            }
        }
    }
}
