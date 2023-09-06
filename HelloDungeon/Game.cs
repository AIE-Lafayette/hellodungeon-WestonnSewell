using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloDungeon
{
    class Game
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
        bool playerIsAlive = true;
        
        float Add(float a, float b)
        {
            float result = a + b;
            return result;
        }
        
        // shows stats
        void PrintStats(string playerName, float hp, float atk)
        {
            Console.WriteLine("Name: " + playerName);
            Console.WriteLine("HP: " + hp);
            Console.WriteLine("ATK: " + atk);
        }
        // player choices


        string DisplayMenu(string prompt, string option1, string option2)
        {
            string playerChoice = "";
            while (playerChoice != "1" && playerChoice != "2")
            {
                Console.Clear();

                Console.WriteLine(prompt);
                if (option2 != "")
                {
                    Console.WriteLine("1." + option1);
                }

                else if (option1 != "")
                {
                    Console.WriteLine("2." + option2);
                }

                Console.Write("> ");
                playerChoice = Console.ReadLine();

                if (playerChoice != "1" && playerChoice != "2");
                {
                    Console.Clear();
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);

                }
            }
            return playerChoice;
        }
        // room 1
        void DisplayScene1()
        {
            PrintStats(playerName, hp, atk);

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

            else if (playerChoice == "2" || playerChoice == "no")
            {
                Console.WriteLine("You decline the offer.");
                Console.WriteLine("You feel oddly awful for this.");
            }
        }
        // room 2
        void DisplayScene2()
        {

            Console.WriteLine("Entering the creepy forest...");

            // enemy encounter

            Console.WriteLine("You run into a creepy goblin!");
            Console.WriteLine("He says,");
            Console.WriteLine("Solve my riddle... WITH YOUR FISTS!");
            Console.WriteLine("What will you do?");
            while(goblinHP > 0)
            {
                Console.WriteLine("1. Fight");
                Console.WriteLine("2. Do nothing");
                Console.Write(">");
                playerChoice = Console.ReadLine();

                if (playerChoice == "1")
                {
                    Console.WriteLine("You punch the goblin.");
                    Console.WriteLine("He's rather weak. He loses 3 HP.");
                    goblinHP -= 3;
                    Console.WriteLine("The goblin attacks. You lose 1 HP.");
                    hp -= 1;
                }

                else if (playerChoice == "2")
                {
                    Console.WriteLine("You do nothing.");
                    Console.WriteLine("You lost 5 HP from an attack!");
                    hp -= 5;

                
                }
                if (hp <= 0)
                {
                    Console.WriteLine("You died!");
                    Console.WriteLine("Press anything to close the game.");
                    playerIsAlive = false;
                    return;
                }

            }
            Console.WriteLine("YOU WON!");
            Console.WriteLine("Gained 3 HP and 5 MP!");
            hp += 3;
            mp += 5;

            
        }

        void DisplayScene3()
        {
            Console.WriteLine("Entering the dark castle...");
            Console.WriteLine("You encounter a scary Dragon! She gives you a riddle.");
            Console.WriteLine("What has a head and a tail, but no body?");
            Console.Write(">");
            playerChoice = Console.ReadLine();
            if (playerChoice == "COIN")
            {
                Console.WriteLine("The dragon explodes from the correct answer! You defeated the dragon and won the game!");
                Console.WriteLine("Press anything to close the game.");
                return;
            }
            if (playerChoice == "")
            {
                Console.WriteLine("The dragon eats you. Game over!");
                Console.WriteLine("Press anything to close the game.");
                return;
            }

        }

        public void Run()
        {

            while (playerIsAlive)
            {
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
            if (playerChoice == "N")
            {
                Console.WriteLine("Alright. What is your name?");
                Console.Write(">");
                playerName = Console.ReadLine();
                Console.Write("Are you sure? Say Y or N.");
                Console.Write(">");
            }

            else if (playerChoice == "Y")
            {
                Console.WriteLine("What a nice name...");
            }

            else
            {
                Console.WriteLine("Input invalid.");
            }

            // room test 2
            DisplayScene1();
            DisplayScene2();
            DisplayScene3();


            // lowers enemy goblin hp
            if (playerChoice == "1")
                goblinHP -= 3;

            // end battle with goblin
            if (goblinHP == 10)
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
}
