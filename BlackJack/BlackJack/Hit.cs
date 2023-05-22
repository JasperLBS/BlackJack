using System;
using System.Collections.Generic;
using System.Text;

namespace BlackJack
{
    public class Hit : Cards
    {
        public int playerValue;
        public int dealerValue;
        Random random = new Random();
        string noDeck = "out of cards";

        public void PlayerDraw()
        {
            int randomIndex = random.Next(cardValues.Length);
            int randomValue = cardValues[randomIndex];

            try
            {
                //dra slumpmässigt kort ut ur arrayn och tar bort den från arrayn.
                cardValues[randomIndex] = cardValues[cardValues.Length - 1];
                Array.Resize(ref cardValues, cardValues.Length - 1);
                Console.WriteLine("you draw a " + randomValue);

                //lägger till värdet av kortet till spelarens hand.
                playerValue = randomValue + playerValue;
                Console.WriteLine("current hand value: " + playerValue + "\n");
            }

            //borde aldrig hända att man drar hela kortleken men error handling ändå om det skulle hända.
            catch
            {
                Console.WriteLine(noDeck);
                Environment.Exit(0);
            }
        }

        public void DealerDraw()
        {
            int randomIndex = random.Next(cardValues.Length);
            int randomValue = cardValues[randomIndex];

            try
            {
                //dealern drar slumpmässigt kort ut ur arrayn och tar bort den från arrayn.
                cardValues[randomIndex] = cardValues[cardValues.Length - 1];
                Array.Resize(ref cardValues, cardValues.Length - 1);
                Console.WriteLine("the dealer draws a " + randomValue);

                //lägger till värdet av kortet till dealerns hand.
                dealerValue = randomValue + dealerValue;
                Console.WriteLine("current dealer hand value: " + dealerValue + "\n");
            }

            //borde aldrig hända att man drar hela kortleken men error handling ändå om det skulle hända.
            catch
            {
                Console.WriteLine(noDeck);
                Environment.Exit(0);
            }
        }
    }
}


