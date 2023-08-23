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
        }
    }
}
