using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAlgorithmPractice.CardDeck
{
    public class Deck
    {
        public List<Card> Cards { get; set; }

        public Deck()
        {
            BuildDeck();
        }
        public void BuildDeck()
        {
            Cards = Enumerable.Range(1, 4)
                .SelectMany(s => Enumerable.Range(1, 13)
                                    .Select(c => new Card()
                                    {
                                        Suit = (Suit)s,
                                        CardNumber = (CardNumber)c
                                    }
                                            )
                            )
                   .ToList();
        }

        public void Shuffle()
        {
            Cards = Cards.OrderBy(c => Guid.NewGuid())
                         .ToList();
        }

    }
}
