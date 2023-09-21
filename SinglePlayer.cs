using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SinglePlayer
    {
        public static void player()
        {
            const int winningPos = 100;
            int playerPos = 0;
            Random random = new Random();
            while(playerPos< winningPos)
            {
                int diceRoll = random.Next(1,7);
                int option = random.Next(0, 3);
                switch (option)
                {
                    case 0:
                        //no play
                        break;
                    case 1:
                        Console.WriteLine("Ladder! You move ahead by " + diceRoll + " positions.");
                        playerPos += diceRoll;
                        break;
                    case 2:
                        Console.WriteLine("Snake! You move back by " + diceRoll + " positions. ");
                        playerPos -= diceRoll;
                        break;
                }
                Console.WriteLine("Current position: " + playerPos);
                if(playerPos == winningPos)
                {
                    Console.WriteLine("Congratulations! You've reached the winning position.");
                    break;
                }
                Console.WriteLine("Press Enter to roll the dice...");
                Console.ReadLine();
            }
            Console.WriteLine("Game Over!");
        }
    }
}
