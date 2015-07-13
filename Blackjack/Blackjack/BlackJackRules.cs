using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    //The BlackJackRules class will represent the rules of the black jack game.

    class BlackJackRules
    {
        // Array of strings to hold the values of the cards
        public static string[] ids = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        // Array of strings to hold the values of the suits
        public static string[] suits = { "C", "H", "S", "D" };

        // Array of values for the cards
        public static int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

        // The blackjack rules class should return a new deck

        public static Deck NewDeck()
        {
           
            
                var deck = new Deck();
                
                //
                foreach (string suit in suits)
                {
                    for (int i = 0; i < values.Length; i++)
                    {
                        // Assign the value of the card and the ids of the cards
                        deck.Add(new Card(ids[i], suit, values[i]));
                    }
                }

                return deck;
            
        }

        // Create a method to shuffle the deck of cards
        /*public static Deck ShuffleDeck
        {
         
         // randomly grab two cards, and then randomly insert those two cards, and repeat the process any number of times

        }
         */ 
        
    }
}
