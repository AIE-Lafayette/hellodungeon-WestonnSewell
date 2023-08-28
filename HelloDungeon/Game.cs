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
            // Initializes player stats and more
            string playerName = "";
            string playerChoice = "";
            float testFloat = 3.2f;
            float hp = 10f;
            float atk = 10f;
            float scaledDamage = 7;
            float mp = 5f;
            float goblinHP = 10;
            int areaNumber = 0;
            bool playerIsAlive = hp > 0;
            // print out name for creator of game
            Console.WriteLine("Weston");
            Console.WriteLine("Sewell");


                //naming the player
                Console.Write("What is your name?");

                Console.Write(">");
                playerName = Console.ReadLine();

                Console.Write("Are you sure? Say Yes or No.");

                Console.Write(">");

                playerChoice = Console.ReadLine();
            // if choice is no
            if (playerChoice == "no")
            {
                Console.WriteLine("Alright. What is your name?");
                Console.Write(">");
                playerName = Console.ReadLine();
                Console.Write("Are you sure? Say Yes or No.");
                Console.Write(">");
            }

            else if (playerChoice == "yes")
            {
                Console.WriteLine("What a nice name...");
            }

            else
            {
                Console.WriteLine("Input invalid.");
            }


            // display character name for player feedback
            Console.WriteLine("Hello " + playerName + " to me games");
            // dialogue 1
            Console.WriteLine("You run into a strange man.");
            Console.WriteLine("He offers you a strange bottle of green fluid.");
            Console.WriteLine("Take it..?");

            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            // choices and answers 1
            Console.Write(">");
            playerChoice = Console.ReadLine();

            if (playerChoice == "1" || playerChoice == "yes")
            {
                Console.WriteLine("Tastes like an apple.");
                Console.WriteLine("Your skin hardens as you gain 5 HP.");
                hp += 5;
            }

            else if (playerChoice == "2" || playerChoice  == "no")
            {
                Console.WriteLine("You decline the offer.");
                Console.WriteLine("You feel oddly awful for this.");
            }

            // enemy encounter

            Console.WriteLine("You run into a creepy goblin!");
            Console.WriteLine("He says,");
            Console.WriteLine("Solve my riddle... WITH YOUR FISTS!");
            Console.WriteLine("What will you do?");
            Console.WriteLine("1. Fight");
            Console.WriteLine("2. Do nothing");
            Console.Write(">");
            playerChoice = Console.ReadLine();

            if (playerChoice == "1")
            {
                Console.WriteLine("You punch the goblin.");
                Console.WriteLine("He's rather weak. He loses 3 HP.");
            }

            else if (playerChoice == "2")
            {
                Console.WriteLine("You do nothing.");
                Console.WriteLine("You lost 1 HP from an attack!");
                hp -= 1;
            }

            // lowers enemy goblin hp
            while (playerChoice == "1")
                goblinHP -= 3;

            // end battle with goblin
            while (goblinHP == 10)
                Console.WriteLine("The goblin falls down and dies.");
            Console.WriteLine("YOU WON!");

            // HP danger and death
            if (hp <= 0)
            {
                Console.WriteLine("You died!");
            }

            else if (hp <= 5)
            {
                Console.WriteLine("DANGER!");
            }
            else

            {
                Console.WriteLine("Invalid input.");
            }

            // battle
            bool enemyAlive = true;

            if (playerIsAlive && enemyAlive)
            {
                // perform battle logic
            }
            else
            {
                // display battle results
            }

            bool enemyWonBattle = true;
            bool playerWonBattle = true;
        }
    }
}
