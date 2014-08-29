/* Question 8.1
 
Design the data structures for a generic deck of cards. Explain how you would subclass
the data structure to implement blackjack. 
 
 */
namespace CRCup150CSharp
{
    #region using
    using System;
    using System.Collections.Generic;
    #endregion

    public class Chapter08_Q01
    {
        public enum Suit
        {
            Club = 0,
            Diamon = 1,
            Heart = 2,
            Spade = 3
        }

        public abstract class Card
        {
            public bool Available { get; set; }
            public int FaceValue { get; set; }
            public Suit Suit { get; set; }
        }

        public class Hand
        {
            protected List<Card> cards = new List<Card>();

            public int Score()
            {
                int score = 0;
                foreach (Card c in cards)
                    score += c.FaceValue;
                return score;
            }

            public void AddCard(Card card)
            {
                this.cards.Add(card);
            }
        }

        public class Deck
        {
            private List<Card> cards = new List<Card>();
            private int dealtIndex = 0;

            public void SetDeckOfCards(List<Card> deckOfCards)
            {
            }

            public void Shuffle()
            {
            }

            public int RemainingCards()
            {
                return this.cards.Count - this.dealtIndex;
            }

            public Card[] DealHand(int index)
            {
                throw new NotImplementedException();
            }

            public Card DealCard()
            {
                throw new NotImplementedException();
            }
        }
    }
}
