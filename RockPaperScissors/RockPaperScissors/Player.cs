using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    // Create bass class. Anything that inherits from this class can implement the Act() method. Child classes are
    // required to implement and define the abstract method 'Act()'
    abstract class Player
    {
        //abstract  class method
        public abstract void Act();
        
    }
}
