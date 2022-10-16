using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzCartGame
{
    public enum CardValue
    {
        SIX = 0, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING, ACE
    }

    public enum CardSuit
    {
        HEARTS = 0, DIAMONDS, CLUBS, SPADES
    }
    public class Card
    {

        public readonly CardValue value;
        public readonly CardSuit suit;

        public Card(CardValue value, CardSuit suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public override string ToString()
        {
            return $"{value} {suit}";
        }
    }
}
