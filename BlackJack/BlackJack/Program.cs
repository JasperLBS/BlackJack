using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Play newPlay = new Play();
            Hit newHit = new Hit();
            GameRules newGameRules = new GameRules();

            Console.WriteLine("type 'h' to hit\ntype 'f' to fold\ntype 'q' to quit\n");
            newPlay.playerPlay();
        }
    }
}
