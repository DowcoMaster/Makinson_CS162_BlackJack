using System;
using CardClasses;

namespace CardTests
{
    class Program
    {
        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] suits = { "", "Clubs", "Diamonds", "Spades", "Hearts" };
        private static string[] options = { "IsAce", "IsBlack", "IsClub", "IsDiamond", "IsFaceCard", "IsHeart", "IsRed", "IsSpade", "HasMatchingSuit", "HasMatchingValues" };
        static void Main(string[] args)
        {
            Start();
        }
        static public void Start()
        {
            Console.Clear();
            Console.WriteLine("Hello, would you like to create a card (0) or pick one from random (1) ?");
            int option = int.Parse(Console.ReadLine());
            Card card;
            if (option == 0)
            {
                card = EnterCard();
            }
            else
            {
                card = new Card();
            }
            CheckCard(card);
        }
        static public void CheckCard(Card card)
        {
            Console.WriteLine("\nYou chose the " + card.ToString());
            Console.WriteLine("What would you like to check?");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " = " + options[i]);
            }
            Console.WriteLine("10 = Restart");
            int option = int.Parse(Console.ReadLine());
            if (option == 0)
            {
                Console.WriteLine(card.IsAce());
            }
            else if (option == 1)
            {
                Console.WriteLine(card.IsBlack());
            }
            else if (option == 2)
            {
                Console.WriteLine(card.IsClub());
            }
            else if (option == 3)
            {
                Console.WriteLine(card.IsDiamond());
            }
            else if (option == 4)
            {
                Console.WriteLine(card.IsFaceCard());
            }
            else if (option == 5)
            {
                Console.WriteLine(card.IsHeart());
            }
            else if (option == 6)
            {
                Console.WriteLine(card.IsRed());
            }
            else if (option == 7)
            {
                Console.WriteLine(card.IsSpade());
            }
            else if(option == 8)
            {
                Console.Clear();
                Console.WriteLine("\nYou will now create a card to compare the suits");
                Card card1 = EnterCard();
                //Console.WriteLine(card.HasMatchingSuit(card1));
                if (card.HasMatchingSuit(card1))
                {
                    Console.WriteLine(card1.ToString() + " and " +  card.ToString() + " have the same suits");
                }
                else
                {
                    Console.WriteLine(card1.ToString() + " and " + card.ToString() + " do not have the same suits");
                }
            }
            else if (option == 9)
            {
                Console.Clear();
                Console.WriteLine("\nYou will now create a card to compare the values");
                Card card1 = EnterCard();
                //Console.WriteLine(card.HasMatchingValue(card1));
                if (card.HasMatchingValue(card1))
                {
                    Console.WriteLine(card1.ToString() + " and " + card.ToString() + " have the same values");
                }
                else
                {
                    Console.WriteLine(card1.ToString() + " and " + card.ToString() + " do not have the same values");
                }
            }
            else if (option == 10)
            {
                Start();
            }
            CheckCard(card);
        }
        static public Card EnterCard()
        {
            Console.WriteLine("Enter a card value 1-13");
            for (int i = 1; i < 14; i++)
            {
                Console.WriteLine(i + " = " + values[i]);
            }
            int rank = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter a card suits 1-4");
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(i + " = " + suits[i]);
            }
            int suit = int.Parse(Console.ReadLine());
            Card card = new Card(rank, suit);
            Console.WriteLine("\nYou have the " + card.ToString());
            Console.WriteLine("Is this the correct card? (y/n)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                return card;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nPlease try again");
                return EnterCard();
            }
        }
    }
}
