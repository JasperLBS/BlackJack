using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    class Play : GameRules
    {
        Hit newHit = new Hit();
        GameRules newGameRules = new GameRules();
        Reset newReset = new Reset();

        public void playerPlay()
        {
            //delar ut starting hand.
            newHit.DealerDraw();
            newHit.PlayerDraw();
            newHit.PlayerDraw();

            //loop som låter spelaren dra kort tills de förlorar eller foldar.
            for (int i = 0; i < 1; i++)
            {
                string input = Console.ReadLine();
                if (input == "h")
                {
                    newHit.PlayerDraw();
                    i--;
                    if (newHit.playerValue > 21)
                    {
                        newGameRules.PlayerLose();
                    }

                    //instant win om man får 21.
                    else if (newHit.playerValue == 21)
                    {
                        newGameRules.PlayerWin();
                    }
                }

                else if (input == "f")
                {

                } 

                else if (input == "q")
                {
                    Environment.Exit(0);
                }

                else
                {
                    //error handling.
                    Console.WriteLine(invalidInput);
                    i--;
                }
            }

            //dealern drar tills den har högre värde än spelaren.
            while (newHit.playerValue >= newHit.dealerValue)
            {
                newHit.DealerDraw();
            }

            //om dealer har över 21 så vinner spelaren.
            if (newHit.dealerValue > 21)
            {
                newGameRules.PlayerWin();
            }
            else
            {
                newGameRules.PlayerLose();
            }
        }
    }
}
