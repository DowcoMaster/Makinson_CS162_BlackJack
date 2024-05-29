using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CardClasses;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d = new Deck();
            d.Shuffle();

            BJHand player = new BJHand(d, 2);
            BJHand dealer = new BJHand(d, 2);

            Console.WriteLine("Your hand: \n" + player.ToString());
            Console.WriteLine("Dealer's hand: \n" + dealer.ToString());
            Wait();
            Console.WriteLine("Your score: " + player.Score);
            Console.WriteLine("Dealer's score: " + dealer.Score);
            Console.WriteLine("Your turn");
            Console.WriteLine("Hit or Stand? H or S");
            string input = Console.ReadLine();
            while (input.ToLower() == "h")
            {
                Wait();
                player.AddCard(d.Deal());
                Console.WriteLine("Your hand: \n" + player.ToString());
                Console.WriteLine("Your score: " + player.Score);
                Console.WriteLine("Hit or Stand? H or S");
                input = Console.ReadLine();
            }
            Console.WriteLine("Dealer's turn");
            while (dealer.Score < 17)
            {
                Wait();
                dealer.AddCard(d.Deal());
                Console.WriteLine("Dealer's hand: \n" + dealer.ToString());
                Console.WriteLine("Dealer's score: " + dealer.Score);
            }
            Wait();
            if (player.IsBusted)
            {
                Console.WriteLine("Player busted");
            }
            else if (dealer.IsBusted)
            {
                Console.WriteLine("Dealer busted");
            }
            else if (player.Score > dealer.Score)
            {
                Console.WriteLine("Player wins");
            }
            else if (player.Score < dealer.Score)
            {
                Console.WriteLine("Dealer wins");
            }
            else
            {
                Console.WriteLine("Tie");
            }
            Console.WriteLine("Do you want to play again? Y or N");
            string input2 = Console.ReadLine();
            if (input2.ToLower() == "y")
            {
                Console.Clear();
                Main(args);
            }
            else
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
        static void Wait()
        {
            System.Threading.Thread.Sleep(500);
        }
    }
}