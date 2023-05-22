using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Reset : Cards
    {
        Hit newHit = new Hit();

        string reset = "type 'r' to restart\ntype 'q' to quit\n";

        public void Restart()
        {
            //startar om programmet från början.
            Console.Clear();
            System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);
            Environment.Exit(0);
        }

        public void Shuffle()
        {
            Console.WriteLine(reset);

            //inte elegant men det enda som fungerar för att "blanda kortleken" utan att få stack overflow errors.
            cardValues = new int[52] {1,  1,  1,  1,
                                      2,  2,  2,  2,
                                      3,  3,  3,  3,
                                      4,  4,  4,  4,
                                      5,  5,  5,  5,
                                      6,  6,  6,  6,
                                      7,  7,  7,  7,
                                      8,  8,  8,  8,
                                      9,  9,  9,  9,
                                      10, 10, 10, 10,
                                      10, 10, 10, 10,
                                      10, 10, 10, 10,
                                      10, 10, 10, 10
            };

            //tar bort korten från spelarna.
            newHit.dealerValue = 0;
            newHit.playerValue = 0;
        }
    }
}
