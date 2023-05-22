using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class GameRules
    {
        Reset newReset = new Reset();

        public int playerValue;
        public string lossMessage = "you lose!";
        public string winMessage = "you win!";
        public string invalidInput = "invalid input, try again\n";

        public void PlayerLose()
        {
            Console.WriteLine(lossMessage);
            newReset.Shuffle();

            for (int l = 0; l < 1; l++)
            {
                string input = Console.ReadLine();
                if (input == "r")
                {
                    newReset.Restart();
                }
                else if (input == "q")
                {
                    Environment.Exit(0);
                }
                else
                {
                    //error handling.
                    Console.WriteLine(invalidInput);
                    l--;
                }
            }
        }
        public void PlayerWin()
        {
            Console.WriteLine(winMessage);
            newReset.Shuffle();

            for (int k = 0; k < 1; k++)
            {
                string input = Console.ReadLine();
                if (input == "r")
                {
                    newReset.Restart();
                }

                else if (input == "q")
                {
                    Environment.Exit(0);
                }

                else
                {
                    //error handling.
                    Console.WriteLine(invalidInput);
                    k--;
                }
            }
        }
    }
}
