using System.Collections.Generic;

namespace CardGameUI
{
    public class PokerDeck : Deck
    {
        public PokerDeck()
        {
            CreateDek();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCard()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();
            for(int i = 0; i < 5; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }
        public List<PlayingCardModel> RequestCards(List<PlayingCardModel> cardsToDiscard)
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();
            foreach (var card in cardsToDiscard)
            {
                output.Add(DrawOneCard());
                discardPile.Add(card);
            }
            return output;
        }
    }
}
