using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    public class Card
    {
        // Card Class Properties 
        public string ID { get; set; }
        public string Suite { get; set; }
        public int Value { get; set; }

        public Card( string id, string suite, int value)
        {
            this.ID = id;
            this.Suite = suite;
            this.Value = value;
        }




    }
}
