using System.Collections.Generic;

namespace CardGameUI
{
    public class Blackjack : Deck
    {
        public Blackjack()
        {
            CreateDek();
            ShuffleDeck();
        }
        public override List<PlayingCardModel> DealCard()
        {
            List<PlayingCardModel> output = new List<PlayingCardModel>();
            for (int i = 0; i < 2; i++)
            {
                output.Add(DrawOneCard());
            }
            return output;
        }
        public PlayingCardModel RequestCard()
        {
            return DrawOneCard();
        }
    }
}
