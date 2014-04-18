using System;

class DeckOfCards
{
    static void Main(string[] args)
    {
        string spades = "♠";
        string clubs = "♣";
        string diams = "♦";
        string hearts = "♥";
        string[] sp = new string[13];
        string[] cl = new string[13];
        string[] di = new string[13];
        string[] hs = new string[13];
        string[] cards = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        for (int i = 0; i <= 12; i++)
        {
            sp[i] = (spades + cards[i]);
            cl[i] = (clubs + cards[i]);
            di[i] = (diams + cards[i]);
            hs[i] = (hearts + cards[i]);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" {0} ", sp[i]);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" {0} ", hs[i]);
            Console.WriteLine(" {0} ", di[i]);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" {0} ", cl[i]);




        }

    }
}

