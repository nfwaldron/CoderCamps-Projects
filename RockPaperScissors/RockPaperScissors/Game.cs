using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*The game Rock/Paper/Scissors has the following rules:
 * Scissors always wins against Rock
 * Rock always wins against Scissors
 * Paper always wins against Rock
 * 
 * Create the following three classes that follow these rules:
 * PlayerRock – Always performs the Act() of Rock.
 * PlayerScissors – Always performs the Act() of Scissors.
 * PlayerPaper – Always performs the Act() of Paper.
 * 
 * Create a Game class that has a method named Fight() that satisifies these requirements:
 * The Fight() method accepts two parameters:  Player1 and Player2.
 * The Fight() method calls both player's Act() methods.
 * The Fight() method returns the winning player using the Rock/Paper/Scissors rules above.
 */

namespace RockPaperScissors
{
        /*When you create a new class you are creating a new data type that you can use just like any other data type in 
         * the .NET framework. In particular, this means that you can create properties and methods that use the new class 
         * as a data type.
         */
    class Game
    {
        // Class Properties

        /* I want my game class to have access to the Rock, Paper and Scissors classes.
         * I can give the game class three properties that represent the Rock, Paper and Scissors classes.
         * I list the data type, which is the Class, the Name of the Property, and the Placeholders for Get and Set methods.
         */
        public PlayerPaper PlayerPaper { get; set; }
        public PlayerRock PlayerRock { get; set; }
        public PlayerScissors PlayerScissors { get; set; }

        // Class Method

        public Game ()
         /* Use the Game() constructor is used to initialize the Player_______ properties. 
          * If you neglect to initialize these properties then you will get a Null Reference Exception when you 
          * attempt to interact with the BillingAddress or ShippingAddress properties.
          */
	    {
            this.PlayerPaper = new PlayerPaper();
            this.PlayerRock = new PlayerRock();
            this.PlayerScissors = new PlayerScissors();         
	    }

        // What Data Type???
        // cannot be Object type because the Act() method would be blocked.
        //
        public void Fight( Player Player1, Player Player2 ) // Pass Object as a Parameter?
        {
            Player1.Act();
            Player2.Act();

            
        }
        
    }
}
