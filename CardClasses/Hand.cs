using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClasses
{
    public class Hand
    {
        protected List<Card> cards;
        public int NumCards { get; }

        public void AddCard(Card c)
        {
            cards.Add(c);
        }
        public Card Discard(int i)
        {
            Card c = cards[i];
            cards.RemoveAt(i);
            return c;
        }
        public Card GetCard(int i)
        {
            return cards[i];
        }
        public Hand()
        {
            cards = new List<Card>();
        }
        public Hand(Deck d, int numCards)
        {
            cards = new List<Card>();
            for (int i = 0; i < numCards; i++)
            {
                cards.Add(d.Deal());
            }
        }
        public bool HasCard(Card c)
        {
            return IndexOf(c) != -1;
        }
        public bool HasCard(int v)
        {
            foreach (Card c in cards)
            {
                if (c.Value == v)
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasCard(int v, int s)
        {
            foreach (Card c in cards)
            {
                if (c.Value == v && c.Suit == s)
                {
                    return true;
                }
            }
            return false;
        }
        public int IndexOf(Card c)
        {
            return cards.IndexOf(c);
        }
        public int IndexOf(int v)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Value == v)
                {
                    return i;
                }
            }
            return -1;
        }
        public int IndexOf(int v, int s)
        {
            for (int i = 0; i < cards.Count; i++)
            {
                if (cards[i].Value == v && cards[i].Suit == s)
                {
                    return i;
                }
            }
            return -1;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}