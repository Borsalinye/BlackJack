using System;
using System.Collections.Generic;

namespace BlackJackConsole.Person
{
    sealed class Dealer : Person
    {
        private Dealer()
        {
            this.CardInHand = new List<Card>();
            this.PersonValue = 0;
            this.ThatsAll = true;
        }
        private static Dealer instance;
        public static Dealer GetInstance()
        {
            if (instance is null)
            {
                instance = new Dealer();
                return instance;
            }
            else
            {
                return instance;
            }
        }
        public override void GiveCard(Card card)
        {
            if (card.Value + PersonValue < Table.winPoint)
            {
                Console.WriteLine($"Дилеру выпала карта - {card.Rank} {card.Suit}");
                CardInHand.Add(card);
                PersonValue += card.Value;
            }
            else
            {
                ThatsAll = false;
            }
        }
    }
}
