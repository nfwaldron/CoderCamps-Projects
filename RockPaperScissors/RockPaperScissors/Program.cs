using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*The game Rock/Paper/Scissors has the following rules:
 * Scissors always wins against Rock
 * Rock always wins against Scissors
 * Paper always wins against Rock
 * Create the following three classes that follow these rules:
 * PlayerRock – Always performs the Act() of Rock.
 * PlayerScissors – Always performs the Act() of Scissors.
 * PlayerPaper – Always performs the Act() of Paper.
 * Create a Game class that has a method named Fight() that satisifies these requirements:
 * The Fight() method accepts two parameters:  Player1 and Player2.
 * The Fight() method calls both player's Act() methods.
 * The Fight() method returns the winning player using the Rock/Paper/Scissors rules above.
 */

/* The best approach is to use Inheritance. Create a base class Player, that has an abstract method called Act()
 * Abstract methods in the parent must be defined by the child class.
 * 
 */ 


namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
