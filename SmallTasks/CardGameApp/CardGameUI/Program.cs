using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CardGameUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PokerDeck deck = new PokerDeck();
            Blackjack blackjack = new Blackjack();

            List<PlayingCardModel> hand = deck.DealCard();
            List<PlayingCardModel> bHand = deck.DealCard();

            Console.WriteLine();
            Console.WriteLine("Deal a Poker hand now");
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            foreach (var card in hand)
            {
                Console.WriteLine($"{card.Suit.ToString()} of {card.Value.ToString()}");
            }

            Console.WriteLine();
            Console.WriteLine("Deal a Blackjack hand now");
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            foreach (var card in bHand)
            {
                Console.WriteLine($"{card.Suit} of {card.Value}");
            }

            Console.ReadLine();
        }
    }
}
