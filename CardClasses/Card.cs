using System;

namespace CardClasses
{
    public class Card
    {
        private static string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private static string[] suits = { "", "Clubs", "Diamonds", "Spades", "Hearts" };
        private static Random generator = new Random();

        private int val;
        private int suit;

        public override string ToString()
        {
            return values[this.val] + " of " + suits[this.suit];
        }
        public int Suit
        {
            get
            {
                return suit;
            }
            set
            {
                if (value >= 1 && value <= 4)
                {
                    this.suit = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Suit must be between 1 and 4");
                }
            }
        }
        public int Value
        {
            get
            {
                return val;
            }
            set
            {
                if (value >= 1 && value <= 13)
                {
                    this.val = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Value must be between 1 and 13");
                }
            }
        }
        public Card(int v, int s)
        {
            if (v >= 1 && v <= 13)
            {
                this.val = v;
            }
            else
            {
                Console.WriteLine("Value must be between 1 and 13");
                throw new ArgumentOutOfRangeException("Value must be between 1 and 13");
            }
            if (s >= 1 && s <= 4)
            {
                this.suit = s;
            }
            else
            {
                Console.WriteLine("Value must be between 1 and 4");
                throw new ArgumentOutOfRangeException("Suit must be between 1 and 4");
            }
        }
        public Card()
        {
            this.val = generator.Next(1, 14);
            this.suit = generator.Next(1, 5);
        }
        public bool HasMatchingSuit(Card other)
        {
            if (this.suit == other.suit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool HasMatchingValue(Card other)
        {
            if (this.val == other.val)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsAce()
        {
            if (this.val == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsBlack()
        {
            if (this.suit == 1 || this.suit == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsClub()
        {
            if (this.suit == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsDiamond()
        {
            if (this.suit == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsFaceCard()
        {
            if (this.val == 11 || this.val == 12 || this.val == 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsHeart()
        {
            if (this.suit == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsRed()
        {
            if (this.suit == 2 || this.suit == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsSpade()
        {
            if (this.suit == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
