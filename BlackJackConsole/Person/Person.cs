using System.Collections.Generic;

namespace BlackJackConsole.Person
{
    abstract class Person
    {
        public bool ThatsAll { get; set; }
        public int PersonValue { get; set; }
        public List<Card> CardInHand { get; set; }
        public abstract void GiveCard(Card card);
    }
}
