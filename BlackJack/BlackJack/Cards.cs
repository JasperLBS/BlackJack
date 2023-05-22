using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Cards
    {
        public int[] cardValues;

        public Cards()
        {
            //skapar kortleken med sina värden.
            //ess är alltid 1 och alla anda ansiktskort är 10.
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
        }
    }
}
