using System;
using System.Collections.Generic;
using System.Linq;

namespace CardGameUI
{
    public abstract class Deck
    {
        protected List<PlayingCardModel> fullDeck = new List<PlayingCardModel>();
        protected List<PlayingCardModel> drawPile = new List<PlayingCardModel>();
        protected List<PlayingCardModel> discardPile = new List<PlayingCardModel>();

        protected void CreateDek()
        {
            // elibereaza variabila, dar mentine memoria pentru un nou pachet
            fullDeck.Clear();

            // create a deck of card
            for (int suite = 0; suite < 4; suite++)
            {
                for (int val = 0; val < 13; val++)
                {
                    fullDeck.Add(new PlayingCardModel { Suit = (CardSuit)suite, Value = (CardValue)val });
                }
            }
        }
        public virtual void ShuffleDeck()
        {
            // shuffle the cards
            var rand = new Random();
            drawPile = fullDeck.OrderBy(x => rand.Next()).ToList();

        }
        public abstract List<PlayingCardModel> DealCard();
        protected virtual PlayingCardModel DrawOneCard()
        {
            // take doar ia o carte nu o si alege
            // take returneaza un enum(mai multe numere), astfel specificam cu .First() care carte o vrem
            PlayingCardModel output = drawPile.Take(1).First();

            // eliminam cartea extrasa din pachet
            drawPile.Remove(output);

            return output;
        }


    }
}
