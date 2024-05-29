using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJHand;

namespace CardClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hallo, we are testing the Hand class");
            Hand h = new Hand();
            Console.WriteLine("Empty hand: " + h.ToString());
            Console.WriteLine("Testing AddCard");
            h.AddCard(new Card(1, 1));
            h.AddCard(new Card(2, 1));
            h.AddCard(new Card(3, 1));

            Console.WriteLine("\nTesting ToString");
            Console.WriteLine(h.ToString());

            Console.WriteLine("Testing HasCard");
            Console.WriteLine("Hand has 3 cards: " + h.HasCard(3));
            Console.WriteLine("Hand has 4 cards: " + h.HasCard(4));

            Console.WriteLine("\nTesting Discard");
            Console.WriteLine("Now removing index 0 and we get " + h.Discard(0));

            Console.WriteLine("\nTesting GetCard");
            Console.WriteLine("Getting the card from index 0: " + h.GetCard(0));

            Console.WriteLine("\nTesting IndexOf with Value");
            Console.WriteLine("Index of a card with a value 2: " + h.IndexOf(2));

            Card test = new Card(3, 1);
            Console.WriteLine("\nTesting IndexOf with Card");
            Console.WriteLine("Index of a 3 of Clubs: " + h.IndexOf(test));

            Console.WriteLine("\nTesting IndexOf with Value & Suit");
            Console.WriteLine("Index of a 2 of Clubs: " + h.IndexOf(2, 1));
            Console.WriteLine("We are now done testing the Hand class");
            Console.WriteLine("Testing the BJHand class");
            BJHand bh = new BJHand();
            Deck d = new Deck();
            d.Shuffle();
            BJHand dealer = new BJHand(d, 2);

            Console.WriteLine("What's on hand: \n" + dealer.ToString());

            Console.WriteLine("\nTesting HasAce");
            Console.WriteLine("Hand has an Ace: " + bh.HasAce);

            Console.WriteLine("\nTesting IsBusted");
            Console.WriteLine("Are we busted? " + bh.IsBusted);

            Console.WriteLine("\nTesting Score");
            Console.WriteLine("Score of hand: " + bh.Score);
        }
    }
}