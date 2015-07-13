using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// HOW TO CREATE THE DECK
// 

namespace Blackjack
{
    // The deck class will inheirit from the List class, and will contain the card object
    class Deck: List<Card>
    {
        // IEnumerable supports iteration over a collection of a specified type. In this case
        // I want to enumerate through a collection of Card objects.
        // the 'base' initializes a new instance of list that contains elements from the 
        // copied list
        public Deck(IEnumerable<Card> collection) : base(collection) { }
        public Deck() : base(52) { } // Initiate the capacity of the collection.

    // Get the value of the deck
        public int Value { get; set; }

    }
}
