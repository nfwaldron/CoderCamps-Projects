using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Player
    {
        // The player has a property hand

        public Deck Hand { get; set; }

        // Create a constructor for the player that has as a new deck 
        // for every time the player class is called

        public Player()
        {
            Hand = new Deck();
        }
    }
}
